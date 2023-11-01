namespace CloudCustomers.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("a")]
    public void Test1()
    {
        Assert.Pass();
    }
}