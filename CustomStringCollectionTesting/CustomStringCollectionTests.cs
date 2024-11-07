using CustomStringCollectionLib;

namespace CustomStringCollectionTesting;

public class ACustomStringCollection
{
    [Test]
    public void CanAddNewString()
    {
        var sut = new CustomStringCollection(1);
        sut.Add("Check");
        Assert.That(sut.NumberOfStrings, Is.EqualTo(1));
    }
    [Test]
    public void CanGetAString()
    {
        var sut = new CustomStringCollection(1);
        sut.Add("Check");
        Assert.That(sut.Get(0), Is.EqualTo("Check"));
    }

    [Test]
    public void ShouldThrowExceptionWhenGettingAStringWithBadIndex()
    {
        var sut = new CustomStringCollection(1);
        sut.Add("Check");
        Assert.Throws<IndexOutOfRangeException>(() => {
            sut.Get(-1);
        });
    }

    [Test]
    public void CanReportTheStrings()
    {
        var sut = new CustomStringCollection(10);
        sut.Add("Z");
        sut.Add("A");
        sut.Add("B");
        sut.Add("D");
        sut.Add("E");
        Assert.That(sut.ToString(), Is.EqualTo("{Z,A,B,D,E}"));
    }

    [Test]
    [Category("100% Statement Coverage")]
    [Category("100% Path Coverage")]
    public void Provide100PStatementCoverage()
    {
        var sut = new CustomStringCollection(10);

        sut.Add("A");
        sut.Add("B");

        Assert.That(sut.ToString(), Is.EqualTo("{A,B}"));
    }

    [Test]
    public void CanSortTheStrings()
    {
        var sut = new CustomStringCollection(10);

        sut.Add("Z");
        sut.Add("A");
        sut.Add("B");
        sut.Add("D");
        sut.Add("E");
        sut.Sort();

        Assert.That(sut.ToString(), Is.EqualTo("{A,B,D,E,Z}"));
    }

    [Test]
    public void ShouildBeAbleToReportThePositionofAString()
    {

        var sut = new CustomStringCollection(10);

        sut.Add("Z");
        sut.Add("A");
        sut.Add("J");
        sut.Add("D");
        sut.Sort();

        //Assert.That(sut.Search("Z"), Is.EqualTo(2));
        Assert.That(sut.Search("Z"), Is.EqualTo(3));

    }

    [Test]
    [Category("All-defs on variable 'left' (c-use)")]
    public void AllDefLeftC()
    {
        var sut = new CustomStringCollection(10);

        sut.Add("A");

        Assert.That(sut.Search("A"), Is.EqualTo(0));
    }

    [Test]
    [Category("All-defs on variable 'left' (p-use)")]
    public void AllDefLeftP()
    {
        var sut = new CustomStringCollection(10);

        Assert.That(sut.Search("B"), Is.EqualTo(-1));
    }
}