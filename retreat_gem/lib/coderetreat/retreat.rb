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
      end

      def default_user
        'coreyhaines'
      end

      def repo_url_for user
        "https://github.com/#{user}/coderetreat.git"
      end
  
      def repo_path user
        repo_path = @home.join user
        unless repo_path.exists?
          puts "Pulling #{user}/coderetreat repo into #{repo_path}..."
          Git.clone repo_url_for(user), repo_path
          puts "\nInstallation completed!  Here is some information..."              
        end
        repo_path
      end

      def language user, language
        repo_path(user).join('starting_points', language)
      end

      def languages user
        repo_path(user).join('starting_points').ls.map{|path| path.basename}
      end
    end

    class Start < Action
      def self.run!(args)
        new(args).run!
      end

      def initialize(args)
        super()
        @user, @language = args[0].split('/')
        @user, @language = default_user, @user unless @language
        @target = args[1] ? Path.new(args[1]) : Path.new('.')
      end
  
      def run!
        validate_environment!
        language(@user, @language).copy_to(@target)
        puts "Created #{@language} iteration starting point at #{@target}"
      end
      
      def validate_environment!
        raise EnvError.new("Cannot create #{@target}") unless @target.dirname.writable?
      end
    end
    
    class Install < Action
      def self.run!(args)
        new(args).run!
      end

      def initialize(args)
        super()
        @user = args[0] || default_user
      end

      def run!
        repo_path @user
        Info.run! [@user]
        puts "\nRun 'retreat start <language> [location]' to start a new iteration"
      end
    end

    class Update < Action
      def self.run!(args)
        new(args)
      end

      def initialize(args)
        super()
        @user = args[0] || default_user
        puts "Updating sources at #{repo_path @user}"
        Git.pull repo_path(@user)
      end
    end

    class Info < Action
      def self.run!(args)
        new(args)
      end

      def initialize(args)
        super()
        @user = args[0] || default_user
        result =<<EOS
        
#{message}
EOS
        puts result
      end
      
      def message
        result =<<EOS
  Source Repo: #{repo_url_for @user}
  Local Repo: #{repo_path @user}
  Languages Available: #{languages(@user).join(", ")}
EOS
     
      result
      end
    end
  end
end