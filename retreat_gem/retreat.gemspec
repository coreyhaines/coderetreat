require 'rubygems'

SPEC = Gem::Specification.new do |s|
  s.name = "retreat"
  s.version = '0.1.2'
  s.author = "Adrian Mowat"
  s.homepage = "https://github.com/coreyhaines/coderetreat"
  s.summary = "Command line utilities for coderetreat"
  s.description = <<EOS
retreat allows you to easily start new coderetreat iterations in different languges.  Starting point "skeletons" are held in a git repo and copied as needed.
EOS
  s.has_rdoc = false
  
  s.files       = `git ls-files`.split("\n")
  s.test_files  = `git ls-files -- {spec,features}/*`.split("\n")
  s.executables = `git ls-files -- bin/*`.split("\n").map{ |f| File.basename(f) }
  s.require_paths = ["lib"]
end
