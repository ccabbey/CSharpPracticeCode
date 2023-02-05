using Ch11CardLib;

namespace CardLibTest;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestDeckIsNotNull()
    {
        Deck newDeck = new Deck();
        Assert.IsNull(newDeck);

    }
}