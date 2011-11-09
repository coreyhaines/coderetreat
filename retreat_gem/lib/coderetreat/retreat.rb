require 'etc'
require 'fileutils'

include FileUtils

module CodeRetreat  
  class UsageError < Exception; end
  class EnvError < Exception; end
  
  class Path  
    # Defines a delegator method to File  
    def self.def_file_op(name) 
      file_op = name.to_sym
      define_method(file_op) do |*args|
        File.send(file_op, @path, *args)
      end
    end
            
    def initialize(*elements)
      relative_path = File.join(*elements)
      @path = File.expand_path(relative_path)
    end
    
    def_file_op :exists?
    def_file_op :directory?
    def_file_op :file?
    def_file_op :writable?
    def_file_op :basename
        
    def dirname
      Path.new(File.dirname(@path))
    end
    
    def join(*elements)
      Path.new(@path, *elements)
    end
    
    def to_s
      @path.clone
    end
    
    def copy_to(target)
      cp_r @path, target.to_s
    end
                
    def ls
      Dir["#{@path}/*"].map{|listing_item| Path.new(listing_item)}
    end
    
    def flip_into_and_run
      starting_dir = Dir.getwd
      begin
        Dir.chdir @path
        yield
      ensure
        Dir.chdir starting_dir
      end
    end
  end
  
  class Git
    def self.clone(source_repo, local_repo)
      %x{git clone #{source_repo} #{local_repo}}
      raise EnvError.new("Could not clone #{source_repo}") unless $? == 0
    end
    
    def self.pull(local_repo)
      local_repo.flip_into_and_run do
        %x{git pull origin master}
        raise EnvError.new("Could not pull origin master into #{local_repo}") unless $? == 0
      end
    end
  end
  
  module Actions
    class Action
      def initialize
        @home = Path.new(Etc.getpwuid.dir, '.retreat')
        @local_repo = Path.new(Etc.getpwuid.dir, '.retreat', 'coderetreat')
        @source_repo = "https://github.com/coreyhaines/coderetreat.git"
        @starting_points = @local_repo.join("starting_points")
      end
    end
    
    class Start < Action
      def self.run!(args)
        new(args).run!
      end
      
      def initialize(args)
        super()
        @language = args[0]
        @source = @starting_points.join(@language)
        @target = args[1] ? Path.new(args[1]) : Path.new('.')
      end
      
      def run!
        validate_environment!
        @source.copy_to(@target)
        puts "Created #{@language} iteration starting point at #{@target}"
      end
      
      def validate_environment!
        raise EnvError.new("No sources found.  Try running 'retreat install' first") unless @source.directory?
        raise EnvError.new("Cannot create #{@target}") unless @target.dirname.writable?
      end
    end
    
    class Install < Action
      def self.run!
        new.run!
      end

      def run!
        validate_environment!
        puts "Pulling coderetreat repo into #{@local_repo}..."
        Git.clone @source_repo, @local_repo
        puts "\nInstallation completed!  Here is some information..."        
        Info.run!
        puts "\nRun 'retreat start <language> [location]' to start a new iteration"
      end
      
      def validate_environment!
        if @local_repo.exists? 
          raise EnvError.new("retreat has already been installed.  Run 'retreat update' to get the latest starting points.")
        end
      end
    end
    
    class Update < Action
      def self.run!
        new.run!
      end 
      
      def run!
        validate_environment!
        puts "Updating sources at #{@local_repo}"
        Git.pull @local_repo
      end
      
      def validate_environment!
        raise EnvError.new("retreat is not installed.  Run 'retreat install' to get started.") unless @local_repo.exists? 
      end
    end
    
    class Info < Action
      def self.run!
        new.run!
      end

      def run!
        result =<<EOS
        
#{message}
EOS
        puts result
      end
      
      def message
        result =<<EOS
  Source Repo: #{@source_repo}
  Local Repo: #{@local_repo}
  Languages Available: #{languages.join(", ")}
EOS
     
      result
      end
      
      def languages
        @starting_points.ls.map{|path| path.basename}
      end
    end
  end
end