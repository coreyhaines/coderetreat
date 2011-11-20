$:.unshift(File.dirname(__FILE__) + '/../../lib')
require 'life'

Given /^I have called rocks method$/ do
  @life = Life.new
end

When /^I ask for$/ do
  @result = @life.rocks?()
end

Then /^I get "([^"]*)"$/ do |value|
  value.should == "rocks"
end
