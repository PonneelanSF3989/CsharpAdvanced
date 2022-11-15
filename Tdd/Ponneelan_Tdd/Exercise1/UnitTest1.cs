namespace Exercise1;
[TestFixture]
public class Tests
{
    Calculator operation = null;
    [SetUp]
    public void Setup()
    {
        operation = new Calculator();
    }
    
   
    [Test]
    public void Test1()
    {
        int result = operation.Addition(10,20);
        Assert.That(result,Is.EqualTo(30));
        //Assert.Pass();
    }
    [TestCase(10,12,22)]
    [TestCase(20,35,55)]
    public void IsAdditionOk(int value1 ,int value2, int result)
    {
        int output = operation.Addition(value1,value2);
        Assert.AreEqual(result,output);
    }
    [TestCase("Ravi","Chandiran","RaviChandiran")]
    [TestCase("Baskaran","Sethuraj","BaskaranSethuraj")]
    public void IsAdditionOk(string value1, string value2,string result)
    {
        string output = operation.Addition(value1,value2);
        Assert.AreEqual(result,output);
    }

    [TestCase(1.5,2.5,4.0)]
    [TestCase(10.5,20.5,31.0)]
    public void IsAdditionOk(double value1, double value2,double result)
    {
        double output = operation.Addition(value1,value2);
        Assert.AreEqual(result,output);
    }
}