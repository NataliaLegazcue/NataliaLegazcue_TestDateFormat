Using System;

namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
       [Test]
    public void Test1()
    {
        expected.date = null;
        result = DateFormatter.ChangeFormat ("");
        Assert.AreEqual(expected,result);
    }
 
    [Test]
    public void Test2()
    {
        string date = "05/16/1900";
        date.Substring(3, 2)>12;
        Assert.IsFalse(expected,1900-16-05);
    }

    [Test]
    public void Test3()
    {
        string date = "05/10/1900";
        string fecha = DateFormatter.ChangeFormat(fecha);
        Assert.AreEqual(expected,1900-10-05);;
    }

}