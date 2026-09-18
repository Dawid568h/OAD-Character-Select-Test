using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

[TestClass]
public class BarbarianTest
{
    [TestMethod]
    public void TestBarbarianCreationAndBaseStats()
    {
        // Arrange & Act - Testowanie tworzenia nowej postaci i podstawowych statystyk
        string characterName = "barbarian";
        var barbarian = new Barbarian(characterName);

        // Assert - Sprawdzamy, czy postać została poprawnie utworzona i ma właściwe bazowe/własne statystyki
        Assert.IsNotNull(barbarian, "Instancja czarodzieja nie powinna być null.");
        Assert.AreEqual(characterName, barbarian.Name, "Nazwa postaci powinna być zgodna z podaną w konstruktorze.");
        Assert.AreEqual(CharacterClass.Barbarian, barbarian.Class, "Klasa postaci powinna być ustawiona na Wizard.");

        // Testowanie konkretnych wartości statystyk zgodnych z założeniami klasy Wizard
        Assert.AreEqual(205, barbarian.Health, "Wartość Health powinna wynosić 205.");
        Assert.AreEqual(34, barbarian.Strength, "Wartość Strength powinna wynosić 34.");
        Assert.AreEqual(16, barbarian.Intelligence, "Wartość Intelligence powinna wynosić 16.");
        Assert.AreEqual(18, barbarian.Agility, "Wartość Agility powinna wynosić 18.");
    }
}
