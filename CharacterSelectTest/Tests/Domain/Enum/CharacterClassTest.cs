using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class CharacterClassTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<CharacterClass>(new CharacterClass());
    }
}