<Query Kind="Program" />

#region Copyright (C) 2011 by Brian Friesen
/*
Copyright (C) 2011 by Brian Friesen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

void Main()
{
    TestRunner.RunAll();
}

class _TestAttribute_Tests : TestFixture
{
    public override void SetupTestFixture()
    {
        Console.WriteLine("SetupTestFixture");
    }

    public override void TearDownTestFixture()
    {
        Console.WriteLine("TearDownTestFixture");
    }

    public override void Setup()
    {
////        Uncomment the below line to write "Setup" before every test.
//        Console.WriteLine("Setup");
    }

    public override void TearDown()
    {
////        Uncomment the below line to write "TearDown" after every test.
//        Console.WriteLine("TearDown");
    }

    [Test]
    public void _EqualTo_Passes()
    {
        Assert.That(1, Is.EqualTo(1));
    }

    [Test]
    public void _EqualTo_Fails()
    {
        Assert.That(1, Is.EqualTo(2));
    }

    [Test]
    public void _NotEqualTo_Passes()
    {
        Assert.That(1, Is.NotEqualTo(2));
    }

    [Test]
    public void _NotEqualTo_Fails()
    {
        Assert.That(1, Is.NotEqualTo(1));
    }

    [Test]
    public void _SameAs_Passes()
    {
        var obj1 = new object();
        var obj2 = obj1;
        Assert.That(obj1, Is.SameAs(obj2));
    }

    [Test]
    public void _SameAs_Fails()
    {
        var obj1 = new object();
        var obj2 = new object();
        Assert.That(obj1, Is.SameAs(obj2));
    }

    [Test]
    public void _NotSameAs_Passes()
    {
        var obj1 = new object();
        var obj2 = new object();
        Assert.That(obj1, Is.NotSameAs(obj2));
    }

    [Test]
    public void _NotSameAs_Fails()
    {
        var obj1 = new object();
        var obj2 = obj1;
        Assert.That(obj1, Is.NotSameAs(obj2));
    }

    [Test]
    public void _GreaterThan_Passes()
    {
        Assert.That(1, Is.GreaterThan(0));
    }

    [Test]
    public void _GreaterThan_Fails()
    {
        Assert.That(1, Is.GreaterThan(1));
    }

    [Test]
    public void _GreaterThanOrEqualTo_Passes()
    {
        Assert.That(1, Is.GreaterThanOrEqualTo(0));
        Assert.That(1, Is.GreaterThanOrEqualTo(1));
    }

    [Test]
    public void _GreaterThanOrEqualTo_Fails()
    {
        Assert.That(0, Is.GreaterThanOrEqualTo(1));
    }

    [Test]
    public void _LessThan_Passes()
    {
        Assert.That(0, Is.LessThan(1));
    }

    [Test]
    public void _LessThan_Fails()
    {
        Assert.That(1, Is.LessThan(1));
    }

    [Test]
    public void _LessThanOrEqualTo_Passes()
    {
        Assert.That(0, Is.LessThanOrEqualTo(0));
        Assert.That(0, Is.LessThanOrEqualTo(1));
    }

    [Test]
    public void _LessThanOrEqualTo_Fails()
    {
        Assert.That(1, Is.LessThanOrEqualTo(0));
    }

    [Test]
    public void _AssignableFrom_Passes()
    {
        Assert.That(typeof(Base), Is.AssignableFrom(typeof(Derived)));
    }

    [Test]
    public void _AssignableFrom_Fails()
    {
        Assert.That(typeof(Other), Is.AssignableFrom(typeof(Derived)));
    }

    [Test]
    public void _AssignableTo_Passes()
    {
        Assert.That(typeof(Derived), Is.AssignableTo(typeof(Base)));
    }

    [Test]
    public void _AssignableTo_Fails()
    {
        Assert.That(typeof(Other), Is.AssignableTo(typeof(Base)));
    }

    [Test]
    public void _EquivalentTo_Passes()
    {
        Assert.That(new[] { 1, 2, 3 }, Is.EquivalentTo(new[] { 3, 2, 1 }));
    }

    [Test]
    public void _EquivalentTo_Fails()
    {
        Assert.That(new[] { 1, 2, 3, 4 }, Is.EquivalentTo(new[] { 1, 2, 3 }));
    }

    [Test]
    public void _NotEquivalentTo_Passes()
    {
        Assert.That(new[] { 1, 2, 3, 4 }, Is.NotEquivalentTo(new[] { 1, 2, 3 }));
    }

    [Test]
    public void _NotEquivalentTo_Fails()
    {
        Assert.That(new[] { 1, 2, 3 }, Is.NotEquivalentTo(new[] { 3, 2, 1 }));
    }

    [Test]
    public void TruePasses()
    {
        Assert.That(true, Is.True);
    }

    [Test]
    public void TrueFails()
    {
        Assert.That(false, Is.True);
    }

    [Test]
    public void FalsePasses()
    {
        Assert.That(false, Is.False);
    }

    [Test]
    public void FalseFails()
    {
        Assert.That(true, Is.False);
    }

    [Test]
    public void NullPasses()
    {
        Assert.That(null, Is.Null);
    }

    [Test]
    public void NullFails()
    {
        Assert.That(new object(), Is.Null);
    }

    [Test]
    public void _NotNull_Passes()
    {
        Assert.That(new object(), Is.NotNull);
    }

    [Test]
    public void _NotNull_Fails()
    {
        Assert.That(null, Is.NotNull);
    }

    [Test]
    public void _NaN_Passes()
    {
        Assert.That(double.NaN, Is.NaN);
        Assert.That(float.NaN, Is.NaN);
    }

    [Test]
    public void _NaN_Fails()
    {
        Assert.That(1D, Is.NaN);
    }

    [Test]
    public void _NotNaN_Passes()
    {
        Assert.That(1D, Is.NotNaN);
    }

    [Test]
    public void _NotNaN_Fails()
    {
        Assert.That(double.NaN, Is.NotNaN);
    }

    [Test]
    public void EmptyPasses()
    {
        Assert.That(new int[0], Is.Empty);
    }

    [Test]
    public void EmptyFails()
    {
        Assert.That(new int[] { 1, 2, 3 }, Is.Empty);
    }

    [Test]
    public void _NotEmpty_Passes()
    {
        Assert.That(new int[] { 1, 2, 3 }, Is.NotEmpty);
    }

    [Test]
    public void _NotEmpty_Fails()
    {
        Assert.That(new int[0], Is.NotEmpty);
    }

    [Test]
    public void ThrowsExceptionPasses()
    {
        Assert.That(() => { throw new Exception(); }, Throws.Exception());
        Assert.That(() => { throw new InvalidOperationException(); }, Throws.Exception());
        Assert.That(() => { throw new Exception("abcd"); }, Throws.Exception());
        Assert.That(() => { throw new InvalidOperationException("abcd"); }, Throws.Exception());
    }

    [Test]
    public void ThrowsExceptionFails()
    {
        Assert.That(() => { }, Throws.Exception());
    }

    [Test]
    public void ThrowsExceptionWithMessagePasses()
    {
        Assert.That(() => { throw new Exception("abcd"); }, Throws.Exception("abcd"));
        Assert.That(() => { throw new InvalidOperationException("abcd"); }, Throws.Exception("abcd"));
    }

    [Test]
    public void ThrowsExceptionWithMessageFails()
    {
        Assert.That(() => { throw new Exception("abcd"); }, Throws.Exception("1234"));
    }

    [Test]
    public void ThrowsSpecificExceptionPasses()
    {
        Assert.That(() => { throw new InvalidOperationException(); }, Throws.Exception<InvalidOperationException>());
        Assert.That(() => { throw new ArgumentNullException(); }, Throws.Exception<ArgumentException>());
    }

    [Test]
    public void ThrowsSpecificExceptionFails()
    {
        Assert.That(() => { throw new ArgumentException(); }, Throws.Exception<InvalidOperationException>());
    }

    [Test]
    public void ThrowsSpecificExceptionWithMessagePasses()
    {
        Assert.That(() => { throw new InvalidOperationException("abcd"); }, Throws.Exception<InvalidOperationException>("abcd"));
        Assert.That(() => { throw new ArgumentNullException("abcd", new Exception()); }, Throws.Exception<ArgumentException>("abcd"));
    }

    [Test]
    public void ThrowsSpecificExceptionWithMessageFails()
    {
        Assert.That(() => { throw new InvalidOperationException("abcd"); }, Throws.Exception<InvalidOperationException>("1234"));
    }

    [Test]
    public void ThrowsNothingPasses()
    {
        Assert.That(() => { }, Throws.Nothing);
    }

    [Test]
    public void ThrowsNothingFails()
    {
        Assert.That(() => { throw new Exception(); }, Throws.Nothing);
    }

    [Test]
    public void TestFail()
    {
        Assert.Fail("I'm such a failure... All or Nothing FTW!!!");
    }

    [Test]
    public void TestPass()
    {
        Assert.Pass("Because it just works [)@|\\/||\\/|1+");
    }

    [Test]
    public void TestInconclusive()
    {
        Assert.Inconclusive("Yes, i mean no, i mean yes, i mean no... oh wait thats indecisive");
    }

    [Test]
    public void TestParameterErrors(int input)
    {
    }
}

class _TestCaseAttribute_Tests : TestFixture
{
    public override void SetupTestFixture()
    {
        Console.WriteLine("SetupTestFixture");
    }

    public override void TearDownTestFixture()
    {
        Console.WriteLine("TearDownTestFixture");
    }

    public override void Setup()
    {
////        Uncomment the below line to write "Setup" before every test.
//        Console.WriteLine("Setup");
    }

    public override void TearDown()
    {
////        Uncomment the below line to write "TearDown" after every test.
//        Console.WriteLine("TearDown");
    }

    [TestCase(1, 1)]
    public void _EqualTo_Passes(int actual, int expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1, 2)]
    public void _EqualTo_Fails(int actual, int expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1, 2)]
    public void _NotEqualTo_Passes(int actual, int expected)
    {
        Assert.That(actual, Is.NotEqualTo(expected));
    }

    [TestCase(1, 1)]
    public void _NotEqualTo_Fails(int actual, int expected)
    {
        Assert.That(actual, Is.NotEqualTo(expected));
    }

    [TestCase(2, 1)]
    public void _GreaterThan_Passes(int actual, int expected)
    {
        Assert.That(actual, Is.GreaterThan(expected));
    }

    [TestCase(1, 1)]
    [TestCase(0, 1)]
    public void _GreaterThan_Fails(int actual, int expected)
    {
        Assert.That(actual, Is.GreaterThan(expected));
    }

    [TestCase(2, 1)]
    [TestCase(1, 1)]
    public void _GreaterThanOrEqualTo_Passes(int actual, int expected)
    {
        Assert.That(actual, Is.GreaterThanOrEqualTo(expected));
    }

    [TestCase(0, 1)]
    public void _GreaterThanOrEqualTo_Fails(int actual, int expected)
    {
        Assert.That(actual, Is.GreaterThanOrEqualTo(expected));
    }

    [TestCase(0, 1)]
    public void _LessThan_Passes(int actual, int expected)
    {
        Assert.That(actual, Is.LessThan(expected));
    }

    [TestCase(1, 1)]
    [TestCase(2, 1)]
    public void _LessThan_Fails(int actual, int expected)
    {
        Assert.That(actual, Is.LessThan(expected));
    }

    [TestCase(0, 1)]
    [TestCase(1, 1)]
    public void _LessThanOrEqualTo_Passes(int actual, int expected)
    {
        Assert.That(actual, Is.LessThanOrEqualTo(expected));
    }

    [TestCase(2, 1)]
    public void _LessThanOrEqualTo_Fails(int actual, int expected)
    {
        Assert.That(actual, Is.LessThanOrEqualTo(expected));
    }

    [TestCase(typeof(Base), typeof(Derived))]
    public void _AssignableFrom_Passes(Type actual, Type expected)
    {
        Assert.That(actual, Is.AssignableFrom(expected));
    }

    [TestCase(typeof(Other), typeof(Derived))]
    public void _AssignableFrom_Fails(Type actual, Type expected)
    {
        Assert.That(actual, Is.AssignableFrom(expected));
    }

    [TestCase(typeof(Derived), typeof(Base))]
    public void _AssignableTo_Passes(Type actual, Type expected)
    {
        Assert.That(actual, Is.AssignableTo(expected));
    }

    [TestCase(typeof(Other), typeof(Base))]
    public void _AssignableTo_Fails(Type actual, Type expected)
    {
        Assert.That(actual, Is.AssignableTo(expected));
    }

    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    public void _EquivalentTo_Passes(IEnumerable<int> actual, IEnumerable<int> expected)
    {
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 })]
    public void _EquivalentTo_Fails(IEnumerable<int> actual, IEnumerable<int> expected)
    {
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 })]
    public void _NotEquivalentTo_Passes(IEnumerable<int> actual, IEnumerable<int> expected)
    {
        Assert.That(actual, Is.NotEquivalentTo(expected));
    }

    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    public void _NotEquivalentTo_Fails(IEnumerable<int> actual, IEnumerable<int> expected)
    {
        Assert.That(actual, Is.NotEquivalentTo(expected));
    }

    [TestCase(true)]
    public void TruePasses(bool actual)
    {
        Assert.That(actual, Is.True);
    }

    [TestCase(false)]
    public void TrueFails(bool actual)
    {
        Assert.That(actual, Is.True);
    }

    [TestCase(false)]
    public void FalsePasses(bool actual)
    {
        Assert.That(actual, Is.False);
    }

    [TestCase(true)]
    public void FalseFails(bool actual)
    {
        Assert.That(actual, Is.False);
    }

    [TestCase("Some String")]
    public void NullFails(string actual)
    {
        Assert.That(actual, Is.Null);
    }

    [TestCase("Some String")]
    public void _NotNull_Passes(string actual)
    {
        Assert.That(actual, Is.NotNull);
    }

    [TestCase(double.NaN)]
    [TestCase(float.NaN)]
    public void _NaN_Passes(double actual)
    {
        Assert.That(actual, Is.NaN);
    }

    [TestCase(0D)]
    [TestCase(0F)]
    public void _NaN_Fails(double actual)
    {
        Assert.That(actual, Is.NaN);
    }

    [TestCase(0D)]
    [TestCase(0F)]
    public void _NotNaN_Passes(double actual)
    {
        Assert.That(actual, Is.NotNaN);
    }

    [TestCase(double.NaN)]
    [TestCase(float.NaN)]
    public void _NotNaN_Fails(double actual)
    {
        Assert.That(actual, Is.NotNaN);
    }

    [TestCase(new int[0])]
    public void EmptyPasses(IEnumerable<int> actual)
    {
        Assert.That(actual, Is.Empty);
    }

    [TestCase(new[] { 1, 2, 3 })]
    public void EmptyFails(IEnumerable<int> actual)
    {
        Assert.That(actual, Is.Empty);
    }

    [TestCase(new[] { 1, 2, 3 })]
    public void _NotEmpty_Passes(IEnumerable<int> actual)
    {
        Assert.That(actual, Is.NotEmpty);
    }

    [TestCase(new int[0])]
    public void _NotEmpty_Fails(IEnumerable<int> actual)
    {
        Assert.That(actual, Is.NotEmpty);
    }

    [TestCase]
    public void ThrowsExceptionPasses()
    {
        Assert.That(() => { throw new Exception(); }, Throws.Exception());
        Assert.That(() => { throw new InvalidOperationException(); }, Throws.Exception());
        Assert.That(() => { throw new Exception("abcd"); }, Throws.Exception());
        Assert.That(() => { throw new InvalidOperationException("abcd"); }, Throws.Exception());
    }

    [TestCase]
    public void ThrowsExceptionFails()
    {
        Assert.That(() => { }, Throws.Exception());
    }

    [TestCase("abcd")]
    public void ThrowsExceptionWithMessagePasses(string message)
    {
        Assert.That(() => { throw new Exception("abcd"); }, Throws.Exception(message));
    }

    [TestCase("1234")]
    public void ThrowsExceptionWithMessageFails(string message)
    {
        Assert.That(() => { throw new Exception("abcd"); }, Throws.Exception(message));
    }

    [TestCase(typeof(ArgumentException))]
    public void ThrowsSpecificExceptionPasses(Type expectedExceptionType)
    {
        Assert.That(() => { throw new ArgumentException(); }, Throws.ExceptionOfType(expectedExceptionType));
        Assert.That(() => { throw new ArgumentNullException(); }, Throws.ExceptionOfType(expectedExceptionType));
    }

    [TestCase(typeof(InvalidOperationException))]
    [TestCase(typeof(ArgumentNullException))]
    public void ThrowsSpecificExceptionFails(Type expectedExceptionType)
    {
        Assert.That(() => { throw new ArgumentException(); }, Throws.ExceptionOfType(expectedExceptionType));
    }

    [TestCase(typeof(ArgumentException), "abcd")]
    public void ThrowsSpecificExceptionWithMessagePasses(Type expectedExceptionType, string expectedMessage)
    {
        Assert.That(() => { throw new ArgumentException("abcd"); }, Throws.ExceptionOfType(expectedExceptionType, expectedMessage));
        Assert.That(() => { throw new ArgumentNullException("abcd", new Exception()); }, Throws.ExceptionOfType(expectedExceptionType, expectedMessage));
    }

    [TestCase(typeof(ArgumentNullException), "abcd")]
    [TestCase(typeof(ArgumentException), "1234")]
    [TestCase(typeof(ArgumentNullException), "1234")]
    [TestCase(typeof(InvalidOperationException), "abcd")]
    [TestCase(typeof(InvalidOperationException), "1234")]
    public void ThrowsSpecificExceptionWithMessageFails(Type expectedExceptionType, string expectedMessage)
    {
        Assert.That(() => { throw new ArgumentException("abcd"); }, Throws.ExceptionOfType(expectedExceptionType, expectedMessage));
    }

    [TestCase]
    public void ThrowsNothingPasses()
    {
        Assert.That(() => { }, Throws.Nothing);
    }

    [TestCase]
    public void ThrowsNothingFails()
    {
        Assert.That(() => { throw new Exception(); }, Throws.Nothing);
    }

    [TestCase]
    public void TestFail()
    {
        Assert.Fail("I'm such a failure... All or Nothing FTW!!!");
    }

    [TestCase]
    public void TestPass()
    {
        Assert.Pass("Because it just works [)@|\\/||\\/|1+");
    }

    [TestCase]
    public void TestInconclusive()
    {
        Assert.Inconclusive("Yes, i mean no, i mean yes, i mean no... oh wait thats indecisive");
    }

    [TestCase(1, 2)]
    public void TestParameterErrors()
    {
    }
}

class Base
{
}

class Derived : Base
{
}

class Other
{
}

#region LinqPadUnitTestingFramework

public interface IAssert
{
    void That(object actual, IExpectation expectation);

    void That(Action expression, IExceptionExpectation expectation);

    void Fail(string message = null);

    void Pass(string message = null);

    void Inconclusive(string message = null);
}

public interface IConsole
{
    void WriteLine();

    void WriteLine(object obj);

    void WriteLine(string format, params object[] args);

    void Print(PrintParams printParams, string formatString, params object[] args);
}

public interface IExceptionExpectation
{
    void Evaluate(Action expression);
}

public interface IExpectation
{
    void Evaluate(object actualValue);
}

interface IFifthIntermediateScenarioOutline : IScenario
{
    IFifthIntermediateScenarioOutline Define(params object[] scenarioParameters);

    IFifthIntermediateScenarioOutline Scenarios(string scenarioName);
}

interface IFirstIntermediateScenario
{
    ISecondIntermediateScenario Given(string action, params object[] args);

    IThirdIntermediateScenario When(string action, params object[] args);
}

interface IFirstIntermediateScenarioOutline
{
    ISecondIntermediateScenarioOutline Given(string action, params string[] parameterNames);

    IThirdIntermediateScenarioOutline When(string action, params string[] parameterNames);
}

interface IFourthIntermediateScenario : IScenario
{
    IFourthIntermediateScenario And(string action, params object[] args);
}

interface IFourthIntermediateScenarioOutline
{
    IFourthIntermediateScenarioOutline And(string action, params string[] parameterNames);

    IFifthIntermediateScenarioOutline Scenarios(string scenarioName);
}

interface IScenario
{
    IEnumerable<ScenarioResult> Evaluate();

    void Print();
}

interface ISecondIntermediateScenario
{
    ISecondIntermediateScenario And(string action, params object[] args);

    IThirdIntermediateScenario When(string action, params object[] args);
}

interface ISecondIntermediateScenarioOutline
{
    ISecondIntermediateScenarioOutline And(string action, params string[] parameterNames);

    IThirdIntermediateScenarioOutline When(string action, params string[] parameterNames);
}

interface IThirdIntermediateScenario
{
    IThirdIntermediateScenario And(string action, params object[] args);

    IFourthIntermediateScenario Then(string action, params object[] args);
}

interface IThirdIntermediateScenarioOutline
{
    IThirdIntermediateScenarioOutline And(string action, params string[] parameterNames);

    IFourthIntermediateScenarioOutline Then(string action, params string[] parameterNames);
}

public class Assert : IAssert
{
    public void That(object actualValue, IExpectation expectation)
    {
        expectation.Evaluate(actualValue);
    }

    public void That(Action expression, IExceptionExpectation expectation)
    {
        expectation.Evaluate(expression);
    }

    public void Fail(string message = null)
    {
        if (message == null)
        {
            message = string.Empty;
        }

        throw new AssertionException(message);
    }

    public void Pass(string message = null)
    {
        if (message == null)
        {
            message = string.Empty;
        }

        throw new SuccessException(message);
    }

    public void Inconclusive(string message = null)
    {
        if (message == null)
        {
            message = string.Empty;
        }

        throw new InconclusiveException(message);
    }
}

public class AssertionException : Exception
{
    public AssertionException(string message)
        : base(message)
    {
    }
}

public static class Display
{
    public static void Print(PrintParams printParams, string formatString, params object[] args)
    {
        var style = new StringBuilder();

        if (printParams.UseBold)
        {
            style.Append("font-weight: bold;");
        }

        if (printParams.Highlight)
        {
            style.Append("background-color:yellow;");
        }

        if (printParams.UseMonospace)
        {
            style.Append("font-family:consolas,monospace;");
        }
        else
        {
            style.Append("font-family:Verdana,sans-serif;");
        }

        if (printParams.Color != null)
        {
            style.AppendFormat("color:{0};", printParams.Color);
        }

        style.AppendFormat("font-size:{0}px;", printParams.FontSize);

        var xElement = new XElement("span", new XText(string.Format(formatString, args).Replace("  ", "\u00A0\u00A0")));
        xElement.Add(new XAttribute("style", style.ToString()));

        Util.RawHtml(xElement).Dump();
    }
}

abstract class Feature
{
    private readonly IAssert assert = new Assert();

    private readonly string inOrderTo;

    private readonly string asA;

    private readonly string iWant;

    private readonly string[] freeFormDescriptionLines;

    protected Feature(string inOrderTo, string asA, string iWant)
    {
        this.inOrderTo = inOrderTo;
        this.asA = asA;
        this.iWant = iWant;
    }

    protected Feature(string description)
    {
        this.freeFormDescriptionLines = description.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
    }

    public abstract IEnumerable<IScenario> Scenarios { get; }

    protected IFirstIntermediateScenario Scenario(string scenarioName)
    {
        return UserQuery.Scenario.Create(this, scenarioName);
    }

    protected IFirstIntermediateScenarioOutline ScenarioOutline(string scenarioName)
    {
        return UserQuery.ScenarioOutline.Create(this, scenarioName);
    }

    protected IAssert Assert
    {
        get
        {
            return this.assert;
        }
    }

    public IEnumerable<TestResult> Evaluate()
    {
        this.DisplayFeatureDefinition();

        var scenarioResults = this.Scenarios.SelectMany(scenario => scenario.Evaluate()).ToList();

        var missingMethods = new Dictionary<string, StepResult.MissingMethodCheck>();

        int failedScenarios = 0, passedScenarios = 0, inconclusiveScenarios = 0, pendingScenarios = 0;
        var testResults = new List<TestResult>();

        foreach (var scenarioResult in scenarioResults)
        {
            var scenarioTestResult = ProcessScenarioResult(scenarioResult, missingMethods);

            testResults.Add(scenarioTestResult);

            switch (scenarioTestResult)
            {
                case TestResult.Pass:
                    passedScenarios++;
                    break;
                case TestResult.Fail:
                    failedScenarios++;
                    break;
                case TestResult.Pending:
                    pendingScenarios++;
                    break;
                case TestResult.Inconclusive:
                    inconclusiveScenarios++;
                    break;
            }
        }

        if (missingMethods.Any())
        {
            Console.WriteLine();

            Display.Print(new PrintParams(useMonospace: true), "Stubs for Missing Methods:");
            Console.WriteLine();

            foreach (var missingMethod in missingMethods.Values.Select(o => o.MissingMethodStubLines))
            {
                foreach (var line in missingMethod)
                {
                    Display.Print(new PrintParams(useMonospace: true), "{0}", line);
                }
            }
        }

        Console.WriteLine();

        Display.Print(
            new PrintParams(
                13,
                failedScenarios > 0
                     ? "red"
                     : pendingScenarios > 0
                        ? "blue"
                        : inconclusiveScenarios > 0
                            ? "orange"
                            : "green",
                failedScenarios > 0 || inconclusiveScenarios > 0 || pendingScenarios > 0),
            "Scenarios failed: {0}, passed: {1}, inconclusive: {2}, pending: {3}",
            failedScenarios,
            passedScenarios,
            inconclusiveScenarios,
            pendingScenarios);

        return testResults;
    }

    public void DisplayDefinition()
    {
        this.DisplayFeatureDefinition();

        Console.WriteLine();

        var scenarios = this.Scenarios.ToArray();
        for (int i = 0; i < scenarios.Length; i++)
        {
            if (i > 0)
            {
                Console.WriteLine();
            }

            scenarios[i].Print();
        }
    }

    private void DisplayFeatureDefinition()
    {
        Display.Print(new PrintParams(useMonospace: true), "Feature: {0}", Helper.UnCamelCase(this.GetType().Name));

        if (freeFormDescriptionLines != null)
        {
            foreach (var line in freeFormDescriptionLines)
            {
                if (line == string.Empty)
                {
                    Console.WriteLine();
                }
                else
                {
                    Display.Print(new PrintParams(useMonospace:true), line);
                }
            }
        }
        else
        {
            Display.Print(new PrintParams(useMonospace: true), "    In order to {0}", this.inOrderTo);
            Display.Print(new PrintParams(useMonospace: true), "    As a {0}", this.asA);
            Display.Print(new PrintParams(useMonospace: true), "    I want {0}", this.iWant);
        }
    }

    private static TestResult ProcessScenarioResult(ScenarioResult scenarioResult, Dictionary<string, StepResult.MissingMethodCheck> missingMethods)
    {
        Console.WriteLine();

        var scenerioString = string.Format("  Scenario: {0}", scenarioResult.ScenarioName);

        Display.Print(new PrintParams(useMonospace: true), scenerioString);

        var padLength = scenarioResult.StepResults.Select(o => o.Message.Length + 6).Concat(new[] { scenerioString.Length }).Max() + 1;

        bool foundNonPassingStep = false;
        TestResult scenarioTestResult = TestResult.Pass;

        foreach (var stepResult in scenarioResult.StepResults)
        {
            var hasMissingMethod = stepResult.CheckForMissingMethod(missingMethods);

            string color = "green";
            string message;

            if (!foundNonPassingStep)
            {
                message = stepResult.TestResult.ToString();
                if (!string.IsNullOrEmpty(stepResult.ErrorMessage))
                {
                    message += " - " + stepResult.ErrorMessage;
                }

                if (stepResult.TestResult != TestResult.Pass)
                {
                    foundNonPassingStep = true;

                    switch (stepResult.TestResult)
                    {
                        case TestResult.Fail:
                            scenarioTestResult = TestResult.Fail;
                            color = "red";
                            break;
                        case TestResult.Pending:
                            scenarioTestResult = TestResult.Pending;
                            color = "blue";
                            break;
                        case TestResult.Inconclusive:
                            scenarioTestResult = TestResult.Inconclusive;
                            color = "orange";
                            break;
                    }
                }
            }
            else
            {
                if (hasMissingMethod)
                {
                    message = string.Format("Pending - Missing method: '{0}'", stepResult.StepDefinition);
                    color = "blue";
                }
                else
                {
                    message = "Not evaluated because of previous non-passing step";
                    color = "purple";
                }
            }

            Display.Print(new PrintParams(color: color, useMonospace: true), string.Concat(string.Format("      {0}", stepResult.Message).PadRight(padLength), "-> ", message));
        }

        return scenarioTestResult;
    }

    //private static bool CheckForMissingMethod(StepResult stepResult, Dictionary<string, Tuple<StepResult, List<string>>> missingMethods)
    //{
    //    if (!stepResult.HasMissingMethod)
    //    {
    //        return false;
    //    }

    //    var parameterDefinitions =
    //        string.Join(
    //            ", ",
    //            stepResult.ParameterTypes.Select((parameterType, i) => string.Format("{0} arg{1}", Helper.GetAlias(stepResult.ParameterTypes[i]), i)));
    //    var key = stepResult.StepDefinition + parameterDefinitions;

    //    if (missingMethods.ContainsKey(key))
    //    {
    //        return true;
    //    }

    //    string stepDefinitionRegex = stepResult.StepDefinition;
    //    for (int i = stepResult.ParameterTypes.Length - 1; i >= 0; i--)
    //    {
    //        var parameterType = stepResult.ParameterTypes[i];

    //        string parameterRegex;
    //        if (parameterType == typeof(float)
    //            || parameterType == typeof(double)
    //            || parameterType == typeof(decimal))
    //        {
    //            parameterRegex = @"(\d+(\.\d+)?)";
    //        }
    //        else if (parameterType == typeof(byte)
    //            || parameterType == typeof(sbyte)
    //            || parameterType == typeof(short)
    //            || parameterType == typeof(ushort)
    //            || parameterType == typeof(int)
    //            || parameterType == typeof(uint)
    //            || parameterType == typeof(long)
    //            || parameterType == typeof(ulong))
    //        {
    //            parameterRegex = @"(\d+)";
    //        }
    //        else
    //        {
    //            parameterRegex = "(.*)";
    //        }

    //        stepDefinitionRegex = stepDefinitionRegex.Replace(string.Format("_{0}", i), parameterRegex);
    //    }

    //    string attribute;
    //    switch (stepResult.StepType & (~StepType.And))
    //    {
    //        case StepType.Given:
    //            attribute = "Given";
    //            break;
    //        case StepType.When:
    //            attribute = "When";
    //            break;
    //        case StepType.Then:
    //            attribute = "Then";
    //            break;
    //        default:
    //            throw new InvalidOperationException();
    //    }

    //    var missingMethod = new List<string>
    //    {
    //        string.Format("    [{0}(@\"{1}\")]", attribute, stepDefinitionRegex),
    //        string.Format("    private void {0}({1})", Helper.CamelCase(stepResult.StepDefinition), parameterDefinitions),
    //        "    {",
    //        "        ScenarioContext.Current.Pending()&#59;",
    //        "    }"
    //    };

    //    missingMethods.Add(key, new Tuple<StepResult, List<string>>(stepResult, missingMethod));

    //    return true;
    //}
}

[AttributeUsage(AttributeTargets.Method)]
class GivenAttribute : StepAttribute
{
    public GivenAttribute(string regex)
        : base(regex)
    {
    }
}

public class Helper
{
    public static string GetString(object obj)
    {
        // TODO: Write tests for GetString
        // NOTE: We're not handling nullable types correctly.

        if (obj == null)
        {
            return "null";
        }

        if (obj is string)
        {
            return string.Format("\"{0}\"", obj);
        }

        if (obj is IEnumerable)
        {
            var collection = (IEnumerable)obj;
            var list = (from object item in collection
                        select item.ToString()).ToList();

            return string.Format("< {0} >", string.Join(", ", list));
        }

        if (obj is Type)
        {
            return string.Format("< {0} >", GetAlias((Type)obj));
        }

        if (obj is bool)
        {
            return (bool)obj ? "True" : "False";
        }

        if (obj is byte
            || obj is sbyte
            || obj is short
            || obj is ushort
            || obj is int
            || obj is uint
            || obj is long
            || obj is ulong
            || obj is float
            || obj is double
            || obj is decimal)
        {
            return obj.ToString();
        }

        return string.Format("< {0} >", obj);
    }

    public static string UnCamelCase(string input, bool toLower = false)
    {
        // NOTE: We're handling numerable values wrong.
        //      For example, 'ThereIsA0Here' should transform to 'There Is A 0 Here'
        //          But currently transforms to 'There Is A0 Here'
        // TODO: Fix numerical value handling.

        // We want to keep replacement indicators (_0, _1, ... _10, _11) together.
        input = Regex.Replace(input, @"(?<!^)_\d+", " $0");

        char? previousCharacter = null;
        var sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            var c = input[i];

            if (c == '_')
            {
                // We want to keep words surrounded by underscores together
                if (i == input.Length - 1 || !char.IsDigit(input[i + 1]))
                {
                    if (i > 0)
                    {
                        sb.Append(' ');
                    }

                    for (i = i + 1; i < input.Length && input[i] != '_'; i++)
                    {
                        sb.Append(input[i]);
                        previousCharacter = input[i];
                    }

                    continue;
                }
            }

            if (previousCharacter != null)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(' ');
                }
            }

            sb.Append(toLower ? char.ToLower(c) : c);
            previousCharacter = c;
        }

        return sb.ToString();
    }

    public static string CamelCase(string input)
    {
        var sb = new StringBuilder();

        foreach (var word in input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
        {
            sb.Append(char.ToUpper(word[0])).Append(word.Substring(1));
        }

        return sb.ToString();
    }

    public static string GetAlias(Type type)
    {
        switch (type.ToString())
        {
            case "System.Boolean":
                return "bool";
            case "System.Byte":
                return "byte";
            case "System.SByte":
                return "sbyte";
            case "System.Char":
                return "char";
            case "System.Decimal":
                return "decimal";
            case "System.Double":
                return "double";
            case "System.Single":
                return "float";
            case "System.Int32":
                return "int";
            case "System.UInt32":
                return "uint";
            case "System.Int64":
                return "long";
            case "System.UInt64":
                return "ulong";
            case "System.Object":
                return "object";
            case "System.Int16":
                return "short";
            case "System.UInt16":
                return "ushort";
            case "System.String":
                return "string";
            default:
                return type.ToString().Replace("UserQuery+", "");
        }
    }
}

class InconclusiveException : Exception
{
    public InconclusiveException()
        : base(string.Empty)
    {
    }

    public InconclusiveException(string message)
        : base(message)
    {
    }
}

static class Is
{
    public static IExpectation EqualTo(object expectedValue)
    {
        return new EqualToExpectation(expectedValue);
    }

    public static IExpectation NotEqualTo(object expectedValue)
    {
        return new NotEqualToExpectation(expectedValue);
    }

    public static IExpectation SameAs(object expectedValue)
    {
        return new SameAsExpectation(expectedValue);
    }

    public static IExpectation NotSameAs(object expectedValue)
    {
        return new NotSameAsExpectation(expectedValue);
    }

    public static IExpectation GreaterThan(object expectedValue)
    {
        return new GreaterThanExpectation(expectedValue);
    }

    public static IExpectation GreaterThanOrEqualTo(object expectedValue)
    {
        return new GreaterThanOrEqualToExpectation(expectedValue);
    }

    public static IExpectation LessThan(object expectedValue)
    {
        return new LessThanExpectation(expectedValue);
    }

    public static IExpectation LessThanOrEqualTo(object expectedValue)
    {
        return new LessThanOrEqualToExpectation(expectedValue);
    }

    public static IExpectation AssignableFrom(Type expectedType)
    {
        return new AssignableFromExpectation(expectedType);
    }

    public static IExpectation AssignableTo(Type expectedType)
    {
        return new AssignableToExpectation(expectedType);
    }

    public static IExpectation EquivalentTo(IEnumerable expected)
    {
        return new EquivalentToExpectation(expected);
    }

    public static IExpectation NotEquivalentTo(IEnumerable expected)
    {
        return new NotEquivalentToExpectation(expected);
    }

    public static IExpectation True
    {
        get
        {
            return new TrueExpectation();
        }
    }

    public static IExpectation False
    {
        get
        {
            return new FalseExpectation();
        }
    }

    public static IExpectation Null
    {
        get
        {
            return new NullExpectation();
        }
    }

    public static IExpectation NotNull
    {
        get
        {
            return new NotNullExpectation();
        }
    }

    public static IExpectation NaN
    {
        get
        {
            return new NaNExpectation();
        }
    }

    public static IExpectation NotNaN
    {
        get
        {
            return new NotNaNExpectation();
        }
    }

    public static IExpectation Empty
    {
        get
        {
            return new EmptyExpectation();
        }
    }

    public static IExpectation NotEmpty
    {
        get
        {
            return new NotEmptyExpectation();
        }
    }

    private class EqualToExpectation : IExpectation
    {
        private readonly object expectedValue;

        public EqualToExpectation(object expectedValue)
        {
            this.expectedValue = expectedValue;
        }

        public void Evaluate(object actualValue)
        {
            if (!Equals(this.expectedValue, actualValue))
            {
                throw new AssertionException(string.Format("Expected: {0} But was: {1}", Helper.GetString(this.expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class NotEqualToExpectation : IExpectation
    {
        private readonly object expectedValue;

        public NotEqualToExpectation(object expectedValue)
        {
            this.expectedValue = expectedValue;
        }

        public void Evaluate(object actualValue)
        {
            if (Equals(this.expectedValue, actualValue))
            {
                throw new AssertionException(string.Format("Expected: not {0} But was: {1}", Helper.GetString(this.expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class SameAsExpectation : IExpectation
    {
        private readonly object expectedValue;

        public SameAsExpectation(object expectedValue)
        {
            this.expectedValue = expectedValue;
        }

        public void Evaluate(object actualValue)
        {
            if (!ReferenceEquals(this.expectedValue, actualValue))
            {
                throw new AssertionException(string.Format("Expected: same as {0} But was: {1}", Helper.GetString(this.expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class NotSameAsExpectation : IExpectation
    {
        private readonly object expectedValue;

        public NotSameAsExpectation(object expectedValue)
        {
            this.expectedValue = expectedValue;
        }

        public void Evaluate(object actualValue)
        {
            if (ReferenceEquals(this.expectedValue, actualValue))
            {
                throw new AssertionException(string.Format("Expected: not same as {0} But was: {1}", Helper.GetString(this.expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class GreaterThanExpectation : ComparableExpectation
    {
        public GreaterThanExpectation(object expectedValue)
            : base(expectedValue)
        {
        }

        protected override void Evaluate(IComparable expectedValue, IComparable actualValue)
        {
            if (actualValue.CompareTo(expectedValue) <= 0)
            {
                throw new AssertionException(string.Format("Expected: greater than {0} But was: {1}", Helper.GetString(expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class GreaterThanOrEqualToExpectation : ComparableExpectation
    {
        public GreaterThanOrEqualToExpectation(object expectedValue)
            : base(expectedValue)
        {
        }

        protected override void Evaluate(IComparable expectedValue, IComparable actualValue)
        {
            if (actualValue.CompareTo(expectedValue) < 0)
            {
                throw new AssertionException(string.Format("Expected: greater than or equal to {0} But was: {1}", Helper.GetString(expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class LessThanExpectation : ComparableExpectation
    {
        public LessThanExpectation(object expectedValue)
            : base(expectedValue)
        {
        }

        protected override void Evaluate(IComparable expectedValue, IComparable actualValue)
        {
            if (actualValue.CompareTo(expectedValue) >= 0)
            {
                throw new AssertionException(string.Format("Expected: less than {0} But was: {1}", Helper.GetString(expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class LessThanOrEqualToExpectation : ComparableExpectation
    {
        public LessThanOrEqualToExpectation(object expectedValue)
            : base(expectedValue)
        {
        }

        protected override void Evaluate(IComparable expectedValue, IComparable actualValue)
        {
            if (actualValue.CompareTo(expectedValue) > 0)
            {
                throw new AssertionException(string.Format("Expected: less than or equal to {0} But was: {1}", Helper.GetString(expectedValue), Helper.GetString(actualValue)));
            }
        }
    }

    private class AssignableFromExpectation : IExpectation
    {
        private readonly Type expectedType;

        public AssignableFromExpectation(Type expectedType)
        {
            this.expectedType = expectedType;
        }

        public void Evaluate(object actualValue)
        {
            if (actualValue == null)
            {
                throw new AssertionException(string.Format("Expected: assignable from {0} But was: null", Helper.GetString(this.expectedType)));
            }

            var actualType = actualValue as Type;
            if (actualType == null)
            {
                throw new AssertionException(string.Format("Expected: assignable from {0} But was: {1}", Helper.GetString(this.expectedType), Helper.GetString(actualType)));
            }

            if (!actualType.IsAssignableFrom(this.expectedType))
            {
                throw new AssertionException(string.Format("Expected: assignable from {0} But was: {1}", Helper.GetString(this.expectedType), Helper.GetString(actualValue)));
            }
        }
    }

    private class AssignableToExpectation : IExpectation
    {
        private readonly Type expectedType;

        public AssignableToExpectation(Type expectedType)
        {
            this.expectedType = expectedType;
        }

        public void Evaluate(object actualValue)
        {
            if (actualValue == null)
            {
                throw new AssertionException(string.Format("Expected: assignable to {0} But was: null", Helper.GetString(this.expectedType)));
            }

            var actualType = actualValue as Type;
            if (actualValue == null)
            {
                throw new AssertionException(string.Format("Expected: assignable to {0} But was: {1}", Helper.GetString(this.expectedType), Helper.GetString(actualType)));
            }

            if (!this.expectedType.IsAssignableFrom(actualType))
            {
                throw new AssertionException(string.Format("Expected: assignable to {0} But was: {1}", Helper.GetString(this.expectedType), Helper.GetString(actualType)));
            }
        }
    }

    private class EquivalentToExpectation : IExpectation
    {
        private readonly IEnumerable expectedCollection;

        public EquivalentToExpectation(IEnumerable expectedCollection)
        {
            this.expectedCollection = expectedCollection;
        }

        public void Evaluate(object actualValue)
        {
            var actualCollection = (IEnumerable)actualValue;

            if (!CollectionsAreEquivalent(this.expectedCollection, actualCollection))
            {
                throw new AssertionException(string.Format("Expected: equivalent to {0} But was: {1}", Helper.GetString(this.expectedCollection), Helper.GetString(actualCollection)));
            }
        }

        private static bool CollectionsAreEquivalent(IEnumerable left, IEnumerable right)
        {
            Func<IEnumerable, int> count = collection => collection.Cast<object>().Count();

            if (count(left) != count(right))
            {
                return false;
            }


            var dict = new Hashtable();

            foreach (var member in left)
            {
                if (dict.ContainsKey(member) == false)
                {
                    dict[member] = 1;
                }
                else
                {
                    var value = (int)dict[member];
                    value++;
                    dict[member] = value;
                }
            }

            foreach (var member in right)
            {
                if (dict.ContainsKey(member) == false)
                {
                    return false;
                }

                var value = (int)dict[member];
                value--;
                dict[member] = value;
            }

            return dict.Values.Cast<object>().All(value => (int)value == 0);
        }
    }

    private class NotEquivalentToExpectation : IExpectation
    {
        private readonly IEnumerable expectedCollection;

        private readonly EquivalentToExpectation innerExpectation;

        public NotEquivalentToExpectation(IEnumerable expectedCollection)
        {
            this.expectedCollection = expectedCollection;
            this.innerExpectation = new EquivalentToExpectation(expectedCollection);
        }

        public void Evaluate(object actualValue)
        {
            bool areEquivalent;
            try
            {
                innerExpectation.Evaluate(actualValue);
                areEquivalent = true;
            }
            catch (AssertionException)
            {
                areEquivalent = false;
            }

            if (areEquivalent)
            {
                var actualCollection = (IEnumerable)actualValue;
                throw new AssertionException(string.Format("Expected: not equivalent to {0} But was: {1}", Helper.GetString(this.expectedCollection), Helper.GetString(actualCollection)));
            }
        }
    }

    private class TrueExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            if (!(actualValue is bool) || (bool)actualValue != true)
            {
                throw new AssertionException(string.Format("Expected: True But was: {0}", Helper.GetString(actualValue)));
            }
        }
    }

    private class FalseExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            if (!(actualValue is bool) || (bool)actualValue)
            {
                throw new AssertionException(string.Format("Expected: False But was: {0}", Helper.GetString(actualValue)));
            }
        }
    }

    private class NullExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            if (actualValue != null)
            {
                throw new AssertionException(string.Format("Expected: null But was: {0}", Helper.GetString(actualValue)));
            }
        }
    }

    private class NotNullExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            if (actualValue == null)
            {
                throw new AssertionException(string.Format("Expected: not null But was: {0}", Helper.GetString(actualValue)));
            }
        }
    }

    private class NaNExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            if (actualValue is double)
            {
                if (!double.IsNaN((double)actualValue))
                {
                    throw new AssertionException(string.Format("Expected: NaN But was: {0}", Helper.GetString(actualValue)));
                }
            }
            else if (actualValue is float)
            {
                if (!float.IsNaN((float)actualValue))
                {
                    throw new AssertionException(string.Format("Expected: NaN But was: {0}", Helper.GetString(actualValue)));
                }
            }
            else
            {
                throw new AssertionException(string.Format("Expected: NaN But was: {0}", Helper.GetString(actualValue)));
            }
        }
    }

    private class NotNaNExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            if ((actualValue is double && double.IsNaN((double)actualValue)) || (actualValue is float && float.IsNaN((float)actualValue)))
            {
                throw new AssertionException(string.Format("Expected: not NaN But was: NaN"));
            }
        }
    }

    private class EmptyExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            var collection = ((IEnumerable)actualValue).Cast<object>();

            if (collection.Any())
            {
                throw new AssertionException(string.Format("Expected: <empty> But was: {0}", Helper.GetString(collection)));
            }
        }
    }

    private class NotEmptyExpectation : IExpectation
    {
        public void Evaluate(object actualValue)
        {
            var collection = (IEnumerable)actualValue;
            var enumerator = collection.GetEnumerator();
            if (!enumerator.MoveNext())
            {
                throw new AssertionException("Expected: not <empty> But was: <empty>");
            }
        }
    }

    private abstract class ComparableExpectation : IExpectation
    {
        private readonly IComparable expectedValue;

        protected ComparableExpectation(object expectedValue)
        {
            this.expectedValue = (IComparable)expectedValue;
        }

        public void Evaluate(object actualValue)
        {
            Evaluate(this.expectedValue, (IComparable)actualValue);
        }

        protected abstract void Evaluate(IComparable expectedValue, IComparable actualValue);
    }
}

public class LinqPadConsole : IConsole
{
    public void WriteLine()
    {
        Console.WriteLine();
    }

    public void WriteLine(object obj)
    {
        Console.WriteLine(obj);
    }

    public void WriteLine(string format, params object[] args)
    {
        Console.WriteLine(format, args);
    }

    public void Print(PrintParams printParams, string formatString, params object[] args)
    {
        var style = new StringBuilder();

        if (printParams.UseBold)
        {
            style.Append("font-weight: bold;");
        }

        if (printParams.Highlight)
        {
            style.Append("background-color:yellow;");
        }

        if (printParams.UseMonospace)
        {
            style.Append("font-family:consolas,monospace;");
        }
        else
        {
            style.Append("font-family:Verdana,sans-serif;");
        }

        if (printParams.Color != null)
        {
            style.AppendFormat("color:{0};", printParams.Color);
        }

        style.AppendFormat("font-size:{0}px;", printParams.FontSize);

        var xElement = new XElement("span", new XText(string.Format(formatString, args).Replace("  ", "\u00A0\u00A0")));
        xElement.Add(new XAttribute("style", style.ToString()));

        Util.RawHtml(xElement).Dump();
    }
}

class PendingException : Exception
{
    public PendingException()
        : this(string.Empty)
    {
    }

    public PendingException(string message)
        : base(message)
    {
    }
}

public class PrintParams
{
    private readonly int fontSize = 14;

    private readonly string color = "black";

    private readonly bool useBold;

    private readonly bool highlight;

    private readonly bool useMonospace;

    public PrintParams(int fontSize = 12, string color = "black", bool useBold = false, bool highlight = false, bool useMonospace = false)
    {
        this.fontSize = fontSize;
        this.color = color;
        this.useBold = useBold;
        this.highlight = highlight;
        this.useMonospace = useMonospace;
    }

    public int FontSize
    {
        get
        {
            return fontSize;
        }
    }

    public string Color
    {
        get
        {
            return color;
        }
    }

    public bool UseBold
    {
        get
        {
            return useBold;
        }
    }

    public bool Highlight
    {
        get
        {
            return highlight;
        }
    }

    public bool UseMonospace
    {
        get
        {
            return useMonospace;
        }
    }
}

class Scenario : IFirstIntermediateScenario, ISecondIntermediateScenario, IThirdIntermediateScenario, IFourthIntermediateScenario
{
    private readonly Feature feature;

    private readonly string scenarioName;

    private readonly List<Step> contexts = new List<Step>();

    private readonly List<Step> operations = new List<Step>();

    private readonly List<Step> expectations = new List<Step>();

    private Scenario(Feature feature, string scenarioName)
    {
        this.feature = feature;
        this.scenarioName = scenarioName;
    }

    IEnumerable<ScenarioResult> IScenario.Evaluate()
    {
        yield return new ScenarioResult
        {
            ScenarioName = scenarioName,
            StepResults = contexts.Concat(operations).Concat(expectations).Select(o => o.Evaluate())
        };
    }

    void IScenario.Print()
    {
        Display.Print(new PrintParams(useMonospace: true), "Scenario: {0}", this.scenarioName);

        foreach (var step in contexts.Concat(operations).Concat(expectations))
        {
            Display.Print(new PrintParams(useMonospace: true), "    {0}", step.Message);
        }
    }

    public static IFirstIntermediateScenario Create(Feature feature, string scenarioName)
    {
        return new Scenario(feature, scenarioName);
    }

    ISecondIntermediateScenario IFirstIntermediateScenario.Given(string action, params object[] args)
    {
        contexts.Add(new Step(this, StepType.Given, action, args));
        return this;
    }

    IThirdIntermediateScenario IFirstIntermediateScenario.When(string action, params object[] args)
    {
        operations.Add(new Step(this, StepType.When, action, args));
        return this;
    }

    ISecondIntermediateScenario ISecondIntermediateScenario.And(string action, params object[] args)
    {
        contexts.Add(new Step(this, StepType.Given | StepType.And, action, args));
        return this;
    }

    IThirdIntermediateScenario ISecondIntermediateScenario.When(string action, params object[] args)
    {
        operations.Add(new Step(this, StepType.When, action, args));
        return this;
    }

    IThirdIntermediateScenario IThirdIntermediateScenario.And(string action, params object[] args)
    {
        operations.Add(new Step(this, StepType.When | StepType.And, action, args));
        return this;
    }

    IFourthIntermediateScenario IThirdIntermediateScenario.Then(string action, params object[] args)
    {
        expectations.Add(new Step(this, StepType.Then, action, args));
        return this;
    }

    IFourthIntermediateScenario IFourthIntermediateScenario.And(string action, params object[] args)
    {
        expectations.Add(new Step(this, StepType.Then | StepType.And, action, args));
        return this;
    }

    private class Step
    {
        private readonly StepType stepType;

        private readonly string stepDefinition;

        private readonly Type[] parameterTypes;

        private readonly Action evaluateAction;

        private readonly Func<bool> hasMissingMethodFunction;

        public Step(Scenario scenario, StepType stepType, string stepDefinition, params object[] parameters)
        {
            this.stepType = stepType;
            this.stepDefinition = stepDefinition;
            parameterTypes = parameters.Select(p => p.GetType()).ToArray();

            var methods = scenario.feature.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            var method = methods.Where(
                m =>
                {
                    switch (stepType & (~StepType.And))
                    {
                        case StepType.Given:
                            if (!m.IsDefined(typeof(GivenAttribute), false))
                            {
                                return false;
                            }
                            break;
                        case StepType.When:
                            if (!m.IsDefined(typeof(WhenAttribute), false))
                            {
                                return false;
                            }
                            break;
                        case StepType.Then:
                            if (!m.IsDefined(typeof(ThenAttribute), false))
                            {
                                return false;
                            }
                            break;
                    }

                    var stepAttribute = (StepAttribute)m.GetCustomAttributes(typeof(StepAttribute), false)[0];

                    if (!Regex.IsMatch(GetFormattedStepDefinition(stepDefinition, parameters), stepAttribute.Regex))
                    {
                        return false;
                    }

                    var methodParameters = m.GetParameters();
                    if (methodParameters.Length != parameters.Length)
                    {
                        return false;
                    }

                    return !methodParameters.Where((t, i) => !t.ParameterType.IsAssignableFrom(parameters[i].GetType())).Any();
                }).SingleOrDefault();

            this.hasMissingMethodFunction = () => method == null;

            if (method == null)
            {
                this.evaluateAction = () =>
                {
                    throw new PendingException(string.Format("Missing method: '{0}'", stepDefinition));
                };
            }
            else
            {
                this.evaluateAction = () =>
                {
                    try
                    {
                        method.Invoke(method.IsStatic ? null : scenario.feature, parameters);
                    }
                    catch (TargetInvocationException ex)
                    {
                        if (ex.InnerException != null)
                        {
                            throw ex.InnerException;
                        }

                        throw;
                    }
                };
            }

            this.SetMessage(stepType, GetFormattedStepDefinition(stepDefinition, parameters));
        }

        private static string GetFormattedStepDefinition(string stepDefinition, object[] parameters)
        {
            var formattedStepDefinition = stepDefinition;

            for (int i = parameters.Length - 1; i >= 0; i--)
            {
                formattedStepDefinition = formattedStepDefinition.Replace(string.Format("_{0}", i), Helper.GetString(parameters[i]));
            }

            return formattedStepDefinition;
        }

        public string Message { get; private set; }

        public StepResult Evaluate()
        {
            return new StepResult(evaluateAction, hasMissingMethodFunction)
            {
                StepType = this.stepType,
                StepDefinition = this.stepDefinition,
                ParameterTypes = this.parameterTypes,
                Message = this.Message
            };
        }

        private void SetMessage(StepType stepType, string stepDefinition)
        {
            string s;

            if ((stepType & StepType.And) == StepType.And)
            {
                s = "And";
            }
            else
            {
                s = stepType.ToString();
            }

            this.Message = string.Concat(s, " ", stepDefinition.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t"));
        }
    }
}

class ScenarioContext : Dictionary<string, object>
{
    private ScenarioContext()
    {
    }

    public static ScenarioContext Current { get; private set; }

    public static void Reset()
    {
        Current = new ScenarioContext();
    }

    public void Pending()
    {
        throw new PendingException();
    }

    public T Get<T>()
    {
        return this.Get<T>(typeof(T).FullName);
    }

    public T Get<T>(string key)
    {
        return (T)this[key];
    }

    public void Set<T>(T data)
    {
        this.Set(data, typeof(T).FullName);
    }

    public void Set<T>(T data, string key)
    {
        this[key] = data;
    }

    public bool TryGetValue<T>(out T value)
    {
        var key = typeof(T).FullName;
        return this.TryGetValue(key, out value);
    }

    public bool TryGetValue<T>(string key, out T value)
    {
        if (this.ContainsKey(key))
        {
            value = (T)this[key];
            return true;
        }

        value = default(T);
        return false;
    }
}

class ScenarioOutline : IFirstIntermediateScenarioOutline,
                    ISecondIntermediateScenarioOutline,
                    IThirdIntermediateScenarioOutline,
                    IFourthIntermediateScenarioOutline,
                    IFifthIntermediateScenarioOutline
{
    private readonly Feature feature;

    private readonly string scenarioName;

    private readonly List<OutlineStep> contexts = new List<OutlineStep>();

    private readonly List<OutlineStep> operations = new List<OutlineStep>();

    private readonly List<OutlineStep> expectations = new List<OutlineStep>();

    private readonly Dictionary<string, List<object[]>> scenarios = new Dictionary<string, List<object[]>>();

    private List<object[]> currentScenario;

    private int stepParameterIndex;

    private ScenarioOutline(Feature feature, string scenarioName)
    {
        this.feature = feature;
        this.scenarioName = scenarioName;
    }

    IEnumerable<ScenarioResult> IScenario.Evaluate()
    {
        foreach (var kvp in this.scenarios)
        {
            foreach (var parameterSet in kvp.Value)
            {
                var parameters = parameterSet; // Because of lazy evaluation, we modify the parameterSet closure. Store it in a local variable to fix.
                yield return new ScenarioResult
                {
                    ScenarioName = kvp.Key,
                    StepResults = contexts.Concat(operations).Concat(expectations).Select(o => o.Evaluate(parameters))
                };
            }
        }
    }

    void IScenario.Print()
    {
        Display.Print(new PrintParams(useMonospace: true), "Scenario Outline: {0}", this.scenarioName);

        foreach (var step in contexts.Concat(operations).Concat(expectations))
        {
            Display.Print(new PrintParams(useMonospace: true), "    {0}", step.Message);
        }

        foreach (var kvp in this.scenarios)
        {
            Console.WriteLine();

            Display.Print(new PrintParams(useMonospace: true), "        Scenarios: {0}", kvp.Key);

            var steps = contexts.Concat(operations).Concat(expectations);
            var header = new List<string>();
            var headerLongestValues = new List<int>();

            foreach (var step in steps)
            {
                foreach (var parameterName in step.ParameterNames)
                {
                    header.Add(parameterName);
                    headerLongestValues.Add(parameterName.Length);
                }
            }

            var table = new List<List<string>>();
            var longestValues = new List<int>(headerLongestValues);
            table.Add(header);

            var scenarioParameterSet = scenarios[kvp.Key];

            foreach (var scenarioParameters in scenarioParameterSet)
            {
                var row = new List<string>();

                for (int i = 0; i < scenarioParameters.Length; i++)
                {
                    row.Add(scenarioParameters[i].ToString());
                    longestValues[i] = Math.Max(longestValues[i], scenarioParameters.Length);
                }

                table.Add(row);
            }

            foreach (var row in table)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < row.Count; i++)
                {
                    sb.AppendFormat("| {0} ", row[i].PadRight(longestValues[i]));
                }

                sb.Append("|");

                Display.Print(new PrintParams(useMonospace: true), "            {0}", sb);
            }
        }
    }

    public static IFirstIntermediateScenarioOutline Create(Feature feature, string scenarioName)
    {
        return new ScenarioOutline(feature, scenarioName);
    }

    ISecondIntermediateScenarioOutline IFirstIntermediateScenarioOutline.Given(string action, params string[] parameterNames)
    {
        contexts.Add(new OutlineStep(this, StepType.Given, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    IThirdIntermediateScenarioOutline IFirstIntermediateScenarioOutline.When(string action, params string[] parameterNames)
    {
        operations.Add(new OutlineStep(this, StepType.When, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    ISecondIntermediateScenarioOutline ISecondIntermediateScenarioOutline.And(string action, params string[] parameterNames)
    {
        contexts.Add(new OutlineStep(this, StepType.Given | StepType.And, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    IThirdIntermediateScenarioOutline ISecondIntermediateScenarioOutline.When(string action, params string[] parameterNames)
    {
        operations.Add(new OutlineStep(this, StepType.When, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    IThirdIntermediateScenarioOutline IThirdIntermediateScenarioOutline.And(string action, params string[] parameterNames)
    {
        operations.Add(new OutlineStep(this, StepType.When | StepType.And, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    IFourthIntermediateScenarioOutline IThirdIntermediateScenarioOutline.Then(string action, params string[] parameterNames)
    {
        expectations.Add(new OutlineStep(this, StepType.Then, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    IFourthIntermediateScenarioOutline IFourthIntermediateScenarioOutline.And(string action, params string[] parameterNames)
    {
        expectations.Add(new OutlineStep(this, StepType.Then | StepType.And, action, ref this.stepParameterIndex, parameterNames));
        return this;
    }

    IFifthIntermediateScenarioOutline IFourthIntermediateScenarioOutline.Scenarios(string scenarioName)
    {
        if (!this.scenarios.ContainsKey(scenarioName))
        {
            this.scenarios.Add(scenarioName, new List<object[]>());
        }

        this.currentScenario = this.scenarios[scenarioName];

        return this;
    }

    IFifthIntermediateScenarioOutline IFifthIntermediateScenarioOutline.Define(params object[] scenarioParameters)
    {
        this.currentScenario.Add(scenarioParameters);

        return this;
    }

    IFifthIntermediateScenarioOutline IFifthIntermediateScenarioOutline.Scenarios(string scenarioName)
    {
        if (!this.scenarios.ContainsKey(scenarioName))
        {
            this.scenarios.Add(scenarioName, new List<object[]>());
        }

        this.currentScenario = this.scenarios[scenarioName];

        return this;
    }

    private class OutlineStep
    {
        private readonly StepType stepType;

        private readonly string stepDefinition;

        private readonly string[] parameterNames;

        private readonly Action<object[]> evaluateAction;

        private readonly Func<object[], bool> hasMissingMethodFunction;

        private readonly int firstParameterIndex;

        private readonly int parametersLength;

        public OutlineStep(ScenarioOutline scenario, StepType stepType, string stepDefinition, ref int firstParameterIndex, params string[] parameterNames)
        {
            this.stepType = stepType;
            this.stepDefinition = stepDefinition;
            this.parameterNames = parameterNames;
            this.firstParameterIndex = firstParameterIndex;
            this.parametersLength = parameterNames.Length;
            firstParameterIndex += parametersLength;

            var methods = scenario.feature.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .Where(
                    m =>
                    {
                        switch (stepType & (~StepType.And))
                        {
                            case StepType.Given:
                                if (!m.IsDefined(typeof(GivenAttribute), false))
                                {
                                    return false;
                                }
                                break;
                            case StepType.When:
                                if (!m.IsDefined(typeof(WhenAttribute), false))
                                {
                                    return false;
                                }
                                break;
                            case StepType.Then:
                                if (!m.IsDefined(typeof(ThenAttribute), false))
                                {
                                    return false;
                                }
                                break;
                        }

                        var stepAttribute = (StepAttribute)m.GetCustomAttributes(typeof(StepAttribute), false)[0];

                        if (!Regex.IsMatch(GetFormattedStepDefinition(stepDefinition, parameterNames.Length), stepAttribute.Regex))
                        {
                            return false;
                        }

                        var methodParameters = m.GetParameters();
                        if (methodParameters.Length != parameterNames.Length)
                        {
                            return false;
                        }

                        return true;
                    });

            this.hasMissingMethodFunction = parameters =>
            {
                return GetMethod(methods, parameters) == null;
            };

            this.evaluateAction = parameters =>
            {
                var method = GetMethod(methods, parameters);

                if (method == null)
                {
                    throw new PendingException(string.Format("Missing method: '{0}'", stepDefinition));
                }
                
                try
                {
                    method.Invoke(method.IsStatic ? null : scenario.feature, parameters);
                }
                catch (TargetInvocationException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw ex.InnerException;
                    }

                    throw;
                }
            };

            this.SetMessage(stepType, stepDefinition);
        }

        private static MethodInfo GetMethod(IEnumerable<MethodInfo> candidateMethods, object[] parameters)
        {
            return candidateMethods.Where(m =>
            {
                int i = 0;
                foreach (var parameterType in m.GetParameters().Select(p => p.ParameterType))
                {
                    if (i >= parameters.Length || !parameterType.IsAssignableFrom(parameters[i].GetType()))
                    {
                        return false;
                    }

                    i++;
                }

                return true;
            }).SingleOrDefault();
        }

        private static string GetFormattedStepDefinition(string stepDefinition, int parameterNamesLength)
        {
            var formattedStepDefinition = stepDefinition;

            for (int i = 0; i < parameterNamesLength; i++)
            {
                formattedStepDefinition = formattedStepDefinition.Replace(string.Format("_{0}", i), "0"); // "0" is the most inclusive and should pass any step definition regex
            }

            return formattedStepDefinition;
        }

        public string Message { get; private set; }

        public string[] ParameterNames
        {
            get
            {
                return this.parameterNames;
            }
        }

        public StepResult Evaluate(IEnumerable<object> parameters)
        {
            var parametersForThisStep = parameters.Skip(this.firstParameterIndex).Take(this.parametersLength).ToArray();
            string formattedMessage = this.Message;

            for (int i = parametersForThisStep.Length - 1; i >= 0; i--)
            {
                formattedMessage = formattedMessage.Replace(string.Format("_{0}", i), Helper.GetString(parametersForThisStep[i]));
            }

            return new StepResult(() => evaluateAction(parametersForThisStep), () => this.hasMissingMethodFunction(parametersForThisStep))
            {
                StepType = this.stepType,
                StepDefinition = this.stepDefinition,
                ParameterTypes = parametersForThisStep.Select(parameter => parameter.GetType()).ToArray(),
                Message = formattedMessage,
                ParameterNames = this.ParameterNames
            };
        }

        private void SetMessage(StepType stepType, string stepDefinition)
        {
            string s;

            if ((stepType & StepType.And) == StepType.And)
            {
                s = "And";
            }
            else
            {
                s = stepType.ToString();
            }

            this.Message = string.Concat(s, " ", stepDefinition.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t"));

            for (int i = 0; i < this.ParameterNames.Length; i++)
            {
                this.Message = this.Message.Replace(string.Format("_{0}", i), string.Format("<{0}>", this.ParameterNames[i]));
            }
        }
    }
}

class ScenarioResult
{
    private List<StepResult> cachedStepResults;

    private IEnumerable<StepResult> stepResults;

    public string ScenarioName { get; set; }

    public IEnumerable<StepResult> StepResults
    {
        get
        {
            if (cachedStepResults != null)
            {
                return cachedStepResults;
            }

            return GetStepResults();
        }
        set
        {
            this.stepResults = value;
        }
    }

    private IEnumerable<StepResult> GetStepResults()
    {
        ScenarioContext.Reset();

        cachedStepResults = new List<StepResult>();

        foreach (var stepResult in stepResults)
        {
            cachedStepResults.Add(stepResult);
            yield return stepResult;
        }
    }
}

abstract class StepAttribute : Attribute
{
    protected StepAttribute(string regex)
    {
        if (!regex.StartsWith("^"))
        {
            regex = "^" + regex;
        }

        if (!regex.EndsWith("$"))
        {
            regex = regex + "$";
        }

        this.Regex = regex;
    }

    public string Regex { get; private set; }
}

class StepResult
{
    private readonly Action evaluationAction;

    private readonly Func<bool> hasMissingMethodFunction;

    private TestResult testResult;

    private string errorMessage;

    private bool hasBeenEvaluated;

    public StepResult(Action evaluationAction, Func<bool> hasMissingMethodFunction)
    {
        this.evaluationAction = evaluationAction;
        this.hasMissingMethodFunction = hasMissingMethodFunction;
    }

    public StepType StepType { get; set; }

    public string StepDefinition { get; set; }

    public Type[] ParameterTypes { get; set; }

    public string Message { get; set; }

    public TestResult TestResult
    {
        get
        {
            if (!hasBeenEvaluated)
            {
                Evaluate();
            }

            return testResult;
        }
    }

    public string ErrorMessage
    {
        get
        {
            if (!hasBeenEvaluated)
            {
                Evaluate();
            }

            return errorMessage;
        }
    }

    public string[] ParameterNames { get; set; }

    public bool CheckForMissingMethod(Dictionary<string, MissingMethodCheck> missingMethods)
    {
        var hasMissingMethod = this.hasMissingMethodFunction();

        if (!hasMissingMethod)
        {
            return false;
        }

        var check = new MissingMethodCheck
            {
                StepResult = this
            };

        string parameterDefinitions;
        
        if (this.ParameterNames == null)
        {
            parameterDefinitions =
                string.Join(
                    ", ",
                    this.ParameterTypes.Select(
                        (parameterType, i) =>
                        string.Format("{0} arg{1}", Helper.GetAlias(this.ParameterTypes[i]), i)));
        }
        else
        {
            parameterDefinitions =
                string.Join(
                    ", ",
                    this.ParameterTypes.Select(
                        (parameterType, i) =>
                        string.Format("{0} {1}", Helper.GetAlias(this.ParameterTypes[i]), this.ParameterNames[i])));
        }

        check.MissingMethodKey = this.StepDefinition + parameterDefinitions;

        if (missingMethods.ContainsKey(check.MissingMethodKey))
        {
            return true;
        }

        string stepDefinitionRegex = this.StepDefinition;
        for (int i = this.ParameterTypes.Length - 1; i >= 0; i--)
        {
            var parameterType = this.ParameterTypes[i];

            string parameterRegex;
            if (parameterType == typeof(float)
                || parameterType == typeof(double)
                || parameterType == typeof(decimal))
            {
                parameterRegex = @"(\d+(\.\d+)?)";
            }
            else if (parameterType == typeof(byte)
                || parameterType == typeof(sbyte)
                || parameterType == typeof(short)
                || parameterType == typeof(ushort)
                || parameterType == typeof(int)
                || parameterType == typeof(uint)
                || parameterType == typeof(long)
                || parameterType == typeof(ulong))
            {
                parameterRegex = @"(\d+)";
            }
            else
            {
                parameterRegex = "(.*)";
            }

            stepDefinitionRegex = stepDefinitionRegex.Replace(string.Format("_{0}", i), parameterRegex);
        }

        string attribute;
        switch (this.StepType & (~StepType.And))
        {
            case StepType.Given:
                attribute = "Given";
                break;
            case StepType.When:
                attribute = "When";
                break;
            case StepType.Then:
                attribute = "Then";
                break;
            default:
                throw new InvalidOperationException();
        }

        var missingMethod = new List<string>
        {
            string.Format("    [{0}(@\"{1}\")]", attribute, stepDefinitionRegex),
            string.Format("    private void {0}({1})", Helper.CamelCase(this.StepDefinition), parameterDefinitions),
            "    {",
            "        ScenarioContext.Current.Pending();",
            "    }"
        };

        check.MissingMethodStubLines = missingMethod.ToArray();

        missingMethods.Add(check.MissingMethodKey, check);

        return true;
    }

    private void Evaluate()
    {
        try
        {
            evaluationAction();
            testResult = TestResult.Pass;
        }
        catch (SuccessException ex)
        {
            testResult = TestResult.Pass;
            errorMessage = ex.Message;
        }
        catch (InconclusiveException ex)
        {
            testResult = TestResult.Inconclusive;
            errorMessage = ex.Message;
        }
        catch (PendingException ex)
        {
            testResult = TestResult.Pending;
            errorMessage = ex.Message;
        }
        catch (AssertionException ex)
        {
            testResult = TestResult.Fail;
            errorMessage = ex.Message;
        }
        catch (Exception ex)
        {
            testResult = TestResult.Fail;
            errorMessage = ex.Message;
        }

        hasBeenEvaluated = true;
    }

    public class MissingMethodCheck
    {
        public StepResult StepResult { get; set; }

        public string MissingMethodKey { get; set; }

        public string[] MissingMethodStubLines { get; set; }
    }
}

class SuccessException : Exception
{
    public SuccessException(string message)
        : base(message)
    {
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class TestAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TestCaseAttribute : Attribute
{
    public object[] Parameters
    {
        get;
        private set;
    }

    public TestCaseAttribute(params object[] parameters)
    {
        this.Parameters = parameters;
    }
}

public abstract class TestFixture
{
    private readonly IAssert assert = new Assert();

    protected IAssert Assert
    {
        get
        {
            return this.assert;
        }
    }

    public IConsole Console { get; set; }

    public virtual void SetupTestFixture()
    {
        // Do nothing - leave it up to inheritors to define.
    }

    public virtual void TearDownTestFixture()
    {
        // Do nothing - leave it up to inheritors to define.
    }

    public virtual void Setup()
    {
        // Do nothing - leave it up to inheritors to define.
    }

    public virtual void TearDown()
    {
        // Do nothing - leave it up to inheritors to define.
    }

    public void RunTests(out int passedTests, out int failedTests, out int inconclusiveTests, out int parameterErrors)
    {
        this.SetupTestFixture();

        var methods = this.GetType().GetMethods();

        passedTests = 0;
        failedTests = 0;
        inconclusiveTests = 0;
        parameterErrors = 0;
        int totalTests = 0;

        foreach (var method in methods.Where(o => o.IsDefined(typeof(TestAttribute), false) || o.IsDefined(typeof(TestCaseAttribute), false)))
        {
            totalTests++;

            if (method.IsDefined(typeof(TestCaseAttribute), false))
            {
                var testCaseAttributes = method.GetCustomAttributes(typeof(TestCaseAttribute), false).Cast<TestCaseAttribute>();
                foreach (var testCaseAttribute in testCaseAttributes)
                {
                    string methodName = Helper.UnCamelCase(method.Name);

                    for (int i = testCaseAttribute.Parameters.Length - 1; i >= 0; i--)
                    {
                        methodName = methodName.Replace("_" + i, Helper.GetString(testCaseAttribute.Parameters[i]));
                    }

                    var testResult = this.RunTest(method, methodName, testCaseAttribute.Parameters);
                    IncrementCounts(testResult, ref passedTests, ref failedTests, ref inconclusiveTests, ref parameterErrors);
                }
            }
            else
            {
                var testResult = this.RunTest(method, Helper.UnCamelCase(method.Name), null);
                IncrementCounts(testResult, ref passedTests, ref failedTests, ref inconclusiveTests, ref parameterErrors);
            }
        }

        this.TearDownTestFixture();

        if (totalTests > 0)
        {
            this.Console.WriteLine();
        }

        if (parameterErrors > 0)
        {
            this.Console.Print(new PrintParams(highlight: true), "TEST PARAMETER ERRORS: {0}", parameterErrors);
        }

        this.Console.Print(new PrintParams(color: failedTests > 0 ? "red" : "green", useBold: failedTests > 0), "Tests failed: {0}, passed: {1}, inconclusive: {2}", failedTests, passedTests, inconclusiveTests);
    }

    private static void IncrementCounts(TestResult testResult, ref int passedTests, ref int failedTests, ref int inconclusiveTests, ref int parameterErrors)
    {
        switch (testResult)
        {
            case TestResult.Pass:
                passedTests++;
                break;
            case TestResult.Fail:
                failedTests++;
                break;
            case TestResult.Inconclusive:
                inconclusiveTests++;
                break;
            case TestResult.ParameterError:
                parameterErrors++;
                break;
        }
    }

    private TestResult RunTest(MethodInfo testMethod, string methodName, object[] parameters)
    {
        this.Setup();

        methodName = methodName.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t");

        try
        {
            testMethod.Invoke(this, parameters);

            this.Console.Print(new PrintParams(color: "green"), "Success: {0}", methodName);

            return TestResult.Pass;
        }
        catch (TargetInvocationException ex)
        {
            if (ex.InnerException is AssertionException)
            {
                if (!string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    this.Console.Print(
                        new PrintParams(color: "red"), "Failed: {0} - {1}", methodName, ex.InnerException.Message);
                }
                else
                {
                    this.Console.Print(
                        new PrintParams(color: "red"), "Failed: {0}", methodName);
                }

                return TestResult.Fail;
            }
            else if (ex.InnerException is SuccessException)
            {
                this.Console.Print(new PrintParams(color: "green"), "Success: {0} - {1}", methodName, ex.InnerException.Message);

                return TestResult.Pass;
            }
            else if (ex.InnerException is InconclusiveException)
            {
                this.Console.Print(new PrintParams(color: "orange"), "Inconclusive: {0} - {1}", methodName, ex.InnerException.Message);

                return TestResult.Inconclusive;
            }
            else
            {
                this.Console.Print(new PrintParams(color: "red"), "Failed: {0} - {1}: {2}", methodName, ex.InnerException.GetType().Name, ex.InnerException.Message);

                return TestResult.Fail;
            }
        }
        catch (TargetParameterCountException)
        {
            this.Console.Print(new PrintParams(highlight: true), "ERROR: Parameter mismatch in {0}", methodName);

            return TestResult.ParameterError;
        }
        finally
        {
            this.TearDown();
        }
    }
}

public static class TestRunner
{
    public static IConsole Console { get; set; }

    public static void RunAll()
    {
        CheckConsole();

        var testFixtures = GetTestFixtures();
        var features = GetFeatures();

        if (testFixtures.Any())
        {
            Run(testFixtures);
        }

        if (features.Any())
        {
            EvaluateFeatures(features);
        }
    }

    public static void Run(params TestFixture[] testFixtures)
    {
        CheckConsole();

        int totalPassedTests = 0, totalFailedTests = 0, totalInclusiveTests = 0, totalParameterErrors = 0;

        for (int i = 0; i < testFixtures.Length; i++)
        {
            var testFixture = testFixtures[i];

            if (i > 0)
            {
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.Print(new PrintParams(18, useBold: true), Helper.UnCamelCase(testFixture.GetType().Name));
            Console.WriteLine();

            int passedTests, failedTests, inclusiveTests, parameterErrors;
            testFixture.RunTests(out passedTests, out failedTests, out inclusiveTests, out parameterErrors);

            totalPassedTests += passedTests;
            totalFailedTests += failedTests;
            totalInclusiveTests += inclusiveTests;
            totalParameterErrors += parameterErrors;
        }

        if (testFixtures.Length > 1)
        {
            Console.WriteLine();
            Console.WriteLine();

            if (totalParameterErrors > 0)
            {
                Console.Print(new PrintParams(18, highlight: true), "TEST PARAMETER ERRORS: {0}", totalParameterErrors);
            }

            Console.Print(
                new PrintParams(
                    18,
                    (totalFailedTests > 0 ? "red" : (totalInclusiveTests > 0 ? "orange" : "green")),
                    totalFailedTests > 0),
                "Total tests failed: {0}, passed: {1}, inconclusive: {2}",
                totalFailedTests,
                totalPassedTests,
                totalInclusiveTests);
        }
    }

    public static void DisplayAllFeatures()
    {
        CheckConsole();

        var features = GetFeatures();

        if (features.Any())
        {
            DisplayFeatures(features);
        }
    }

    private static TestFixture[] GetTestFixtures()
    {
        var testFixtureType = typeof(TestFixture);
        var testFixtures =
            typeof(TestRunner).Assembly.GetTypes()
                .Where(t => testFixtureType.IsAssignableFrom(t) && testFixtureType != t)
                .Select(t => (TestFixture)Activator.CreateInstance(t))
                .ToArray();
        
        foreach (var testFixture in testFixtures)
        {
            testFixture.Console = Console;
        }

        return testFixtures;
    }

    private static Feature[] GetFeatures()
    {
        var testFixtureType = typeof(Feature);
        return
            typeof(TestRunner).Assembly.GetTypes()
                .Where(t => testFixtureType.IsAssignableFrom(t) && testFixtureType != t)
                .Select(t => (Feature)Activator.CreateInstance(t))
                .ToArray();
    }

    private static void EvaluateFeatures(Feature[] features)
    {
        int totalPassedActions = 0, totalFailedActions = 0, totalInclusiveActions = 0, totalPendingActions = 0;

        for (int i = 0; i < features.Length; i++)
        {
            var feature = features[i];

            if (i > 0)
            {
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.Print(new PrintParams(20, useBold: true), Helper.UnCamelCase(feature.GetType().Name));
            Console.WriteLine();

            foreach (var testResult in feature.Evaluate())
            {
                switch (testResult)
                {
                    case TestResult.Pass:
                        totalPassedActions++;
                        break;
                    case TestResult.Fail:
                        totalFailedActions++;
                        break;
                    case TestResult.Inconclusive:
                        totalInclusiveActions++;
                        break;
                    case TestResult.Pending:
                        totalPendingActions++;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        if (features.Length > 1)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.Print(
                new PrintParams(
                    20,
                    (totalFailedActions > 0
                         ? "red"
                         : (totalPendingActions > 0 ? "blue" : (totalInclusiveActions > 0 ? "orange" : "green"))),
                    totalFailedActions > 0),
                "Total scenarios failed: {0}, passed: {1}, inconclusive: {2}, pending: {3}",
                totalFailedActions,
                totalPassedActions,
                totalInclusiveActions,
                totalPendingActions);
        }
    }

    private static void DisplayFeatures(Feature[] features)
    {
        for (int i = 0; i < features.Length; i++)
        {
            if (i > 0)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine();
            }

            features[i].DisplayDefinition();
        }
    }

    private static void CheckConsole()
    {
        if (Console == null)
        {
            Console = new LinqPadConsole();
        }
    }
}

[AttributeUsage(AttributeTargets.Method)]
class ThenAttribute : StepAttribute
{
    public ThenAttribute(string regex)
        : base(regex)
    {
    }
}

static class Throws
{
    public static IExceptionExpectation Exception()
    {
        return new ExceptionExpectation(typeof(Exception));
    }

    public static IExceptionExpectation Exception<TException>()
        where TException : Exception
    {
        return new ExceptionExpectation(typeof(TException));
    }

    public static IExceptionExpectation Exception(string expectedMessage)
    {
        return new ExceptionWithMessageExpectation(typeof(Exception), expectedMessage);
    }

    public static IExceptionExpectation Exception<TException>(string expectedMessage)
        where TException : Exception
    {
        return new ExceptionWithMessageExpectation(typeof(TException), expectedMessage);
    }

    public static IExceptionExpectation ExceptionOfType(Type expectedExceptionType)
    {
        return new ExceptionExpectation(expectedExceptionType);
    }

    public static IExceptionExpectation ExceptionOfType(Type expectedExceptionType, string expectedMessage)
    {
        return new ExceptionWithMessageExpectation(expectedExceptionType, expectedMessage);
    }

    public static IExceptionExpectation Nothing
    {
        get
        {
            return new NoExceptionExpectation();
        }
    }

    private class ExceptionExpectation : IExceptionExpectation
    {
        private readonly Type expectedExceptionType;

        public ExceptionExpectation(Type expectedExceptionType)
        {
            this.expectedExceptionType = expectedExceptionType;
        }

        public void Evaluate(Action expression)
        {
            bool threwException = true;

            try
            {
                expression();
                threwException = false;
            }
            catch (Exception ex)
            {
                if (!this.expectedExceptionType.IsAssignableFrom(ex.GetType()))
                {
                    throw new AssertionException(string.Format("Expected: {0} But was: {1}", Helper.GetString(this.expectedExceptionType), Helper.GetString(ex.GetType())));
                }
            }

            if (!threwException)
            {
                throw new AssertionException(string.Format("Expected: {0} But was: no exception thrown", Helper.GetString(this.expectedExceptionType)));
            }
        }
    }

    private class ExceptionWithMessageExpectation : IExceptionExpectation
    {
        private readonly Type expectedExceptionType;

        private readonly string message;

        public ExceptionWithMessageExpectation(Type expectedExceptionType, string message)
        {
            this.expectedExceptionType = expectedExceptionType;
            this.message = message;
        }

        public void Evaluate(Action expression)
        {
            bool threwException = true;

            try
            {
                expression();
                threwException = false;
            }
            catch (Exception ex)
            {
                if (!this.expectedExceptionType.IsAssignableFrom(ex.GetType()))
                {
                    throw new AssertionException(string.Format("Expected: {0} But was: {1}", Helper.GetString(this.expectedExceptionType), Helper.GetString(ex.GetType())));
                }

                if (ex.Message != this.message)
                {
                    throw new AssertionException(string.Format("Expected: exception Message equal to {0} But was: {1}", Helper.GetString(this.message), Helper.GetString(ex.Message)));
                }
            }

            if (!threwException)
            {
                throw new AssertionException(string.Format("Expected: {0} But was: no exception thrown", Helper.GetString(this.expectedExceptionType)));
            }
        }
    }

    private class NoExceptionExpectation : IExceptionExpectation
    {
        public void Evaluate(Action expression)
        {
            try
            {
                expression();
            }
            catch (Exception ex)
            {
                throw new AssertionException(string.Format("Expected: no Exception But was: {0}", Helper.GetString(ex.GetType())));
            }
        }
    }
}

[AttributeUsage(AttributeTargets.Method)]
class WhenAttribute : StepAttribute
{
    public WhenAttribute(string regex)
        : base(regex)
    {
    }
}

[Flags]
enum StepType
{
    Given = 0x01,
    When = 0x02,
    Then = 0x04,
    And = 0x08
}

enum TestResult
{
    Pass,
    Fail,
    Inconclusive,
    ParameterError,
    Pending
}

#endregion