namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
    [Test]
    public void Test1()
    {
        string date = "35/15/1900";
        date.Substring(0, 2)>31;
        Assert.IsFalse(fecha);
    }

    [Test]
    public void Test2()
    {
        string date = "05/16/1900";
        date.Substring(3, 2)>12;
        Assert.IsFalse(fecha);
    }

    [Test]
    public void Test3()
    {
        string date = "05/10/1900";
        string fecha = DateFormatter.ChangeFormat(fecha);
        Assert.IsTrue(fecha);
    }

}