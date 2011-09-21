Just open GameOfLife.linq with LINQPad, write tests using λUnit, and off you go!

Wait a minute, λUnit - what it that? It's a unit testing framework with support for acceptance testing for use in LINQPad.

Get LINQPad here (it's free!): http://www.linqpad.net/

-----------------------------------------------------------------------------------------------------------------

Reference (tl;dr version)

Treat it just like you would NUnit's fluent syntax. If it exists there, it probably exists in λUnit.

This example should be all you need to know to get started:

class Example : TestFixture
{
	[Test]
	public void ExampleTest()
	{
		Assert.That("actualValue", Is.EqualTo("expectedValue"));
		Assert.That(() => {}, Throws.Exception<InvalidOperationException>());
	}
}

-----------------------------------------------------------------------------------------------------------------

Reference

IAssert members (there is an Assert member in TestFixture and Feature):
	That(object actual, IExpectation expectation)
	That(Action expression, IExceptionExpectation expectation)
	Fail(string message)
	Pass(string message)
	Inconclusive(string message)

Is members (all inheritors of IExpectation are accessed through the static 'Is' class):
	EqualTo(object expectedValue)
	NotEqualTo(object expectedValue)
	SameAs(object expectedValue)
	NotSameAs(object expectedValue)
	GreaterThan(object expectedValue)
	GreaterThanOrEqualTo(object expectedValue)
	LessThan(object expectedValue)
	LessThanOrEqualTo(object expectedValue)
	AssignableFrom(Type expectedType)
	AssignableTo(Type expectedType)
	EquivalentTo(IEnumerable expected)
	NotEquivalentTo(IEnumerable expected)
	True
	False
	Null
	NotNull
	NaN
	NotNaN
	Empty
	NotEmpty

Throws members (all inheritors of IExceptionExpectation are accessed through the static 'Throws' class):
	Exception()
	Exception<TException>()
	Exception(string expectedMessage)
	Exception<TException>(string expectedMessage)
	ExceptionOfType(Type expectedExceptionType)
	ExceptionOfType(Type expectedExceptionType, string expectedMessage)
	Nothing

-----------------------------------------------------------------------------------------------------------------

Unit Tests

Treat λUnit much as you would NUnit with its fluent syntax. One notable difference: test fixtures must inherit from the TestFixture class.

Example (see TDDExamples.linq for more examples):

class KataUnitTests : TestFixture
{
    [Test]
    public void MyTest()
    {
        Assert.That("foo", Is.EqualTo("bar"));
    }
    
    [TestCase("foo", "bar")]
    [TestCase("bar", "baz")]
    public void MyTestCases(string expected, string actual)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void ExceptionExpected()
    {
        Assert.That(() => { throw new InvalidOperationException(); }, Throws.Exception<InvalidOperationException>());
    }
}

This result in the following output:

Kata Unit Tests 


Failed: My Test - Expected: "bar" But was: "foo" 
Failed: My Test Cases - Expected: "foo" But was: "bar" 
Failed: My Test Cases - Expected: "bar" But was: "baz" 
Success: Exception Expected 


Tests failed: 3, passed: 1, inconclusive: 0 

-----------------------------------------------------------------------------------------------------------------

Acceptance Tests

I tried to make acceptance tests work very similarly to SpecFlow. I did not, however, create a Gherkin parser. However, like SpecFlow,
if a step has not been implemented, the framework will output a stub method that will satisfy the step.

All features must inherit from the Feature class. The Feature class has a non-default constructor, so you'll need to provide three
strings: inOrderTo, asA, and iWant. It also requires that you override the Scenarios property. It is meant that you yield a series of
Scenarios (or ScenarioOutline).

There exists a method, TestRunner.DisplayAllFeatures(), that outputs each feature in Gherkin. You (theoretically) should be able to use
with SpecFlow or Cucumber. You (again, theoretically) should also be able to take the step definitions and copy and paste them in a C#
project that uses SpeckFlow.

Example (see BDDExamples.linq for more examples):

class KataAcceptanceTests : Feature
{
    public Kata()
        : base(
            /*In order to*/ "improve my skills",
            /*As a*/ "developer",
            /*I want*/ "to do this kata")
    {}

    public override IEnumerable<IScenario> Scenarios
    {
        get
        {
            yield return Scenario("Suck Less")
                .Given("the desire to improve my skills")
                .When("I regularly perform code katas")
                .Then("perhaps I will become a better developer");
        }
    }

    [Given(@"the desire to improve my skills")]
    private void TheDesireToImproveMySkills()
    {
        Assert.Pass("Because I want to improve my skills");
    }

    [When(@"I regularly perform code katas")]
    private void IRegularlyPerformCodeKatas()
    {
        Assert.Pass("I am regularly performing code katas");
    }

    [Then(@"perhaps I will become a better developer")]
    private void PerhapsIWillBecomeABetterDeveloper()
    {
        Assert.Pass("and I am becoming a better developer because of it");
    }
}

This results in the following output:

Kata Acceptance Tests 


Feature: Kata Acceptance Tests 
    In order to improve my skills 
    As a developer 
    I want to do this kata 


  Scenario: Suck Less 
      Given the desire to improve my skills         -> Pass - Because I want to improve my skills 
      When I regularly perform code katas           -> Pass - I am regularly performing code katas 
      Then perhaps I will become a better developer -> Pass - and I am becoming a better developer because of it 


Scenarios failed: 0, passed: 1, inconclusive: 0, pending: 0 