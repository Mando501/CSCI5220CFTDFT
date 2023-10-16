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



}