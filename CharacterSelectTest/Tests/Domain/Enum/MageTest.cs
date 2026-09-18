using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

[TestClass]
public class MageTest
{
    [TestMethod]
    public void TestMageCreationAndBaseStats()
    {
        // Arrange & Act - Testowanie tworzenia nowej postaci i podstawowych statystyk
        string characterName = "mage";
        var mage = new Mage(characterName);

        // Assert - Sprawdzamy, czy postać została poprawnie utworzona i ma właściwe bazowe/własne statystyki
        Assert.IsNotNull(mage, "Instancja czarodzieja nie powinna być null.");
        Assert.AreEqual(characterName, mage.Name, "Nazwa postaci powinna być zgodna z podaną w konstruktorze.");
        Assert.AreEqual(CharacterClass.Mage, mage.Class, "Klasa postaci powinna być ustawiona na Wizard.");

        // Testowanie konkretnych wartości statystyk zgodnych z założeniami klasy Wizard
        Assert.AreEqual(80, mage.Health, "Wartość Health powinna wynosić 80.");
        Assert.AreEqual(4, mage.Strength, "Wartość Strength powinna wynosić 4.");
        Assert.AreEqual(16, mage.Intelligence, "Wartość Intelligence powinna wynosić 16.");
        Assert.AreEqual(10, mage.Agility, "Wartość Agility powinna wynosić 10.");
    }
}
