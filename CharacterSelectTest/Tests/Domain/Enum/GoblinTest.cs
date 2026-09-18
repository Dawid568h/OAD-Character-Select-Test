using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

[TestClass]
public class GoblinTest
{
    [TestMethod]
    public void TestGoblinCreationAndBaseStats()
    {
        // Arrange & Act - Testowanie tworzenia nowej postaci i podstawowych statystyk
        string characterName = "goblin";
        var goblin = new Goblin(characterName);

        // Assert - Sprawdzamy, czy postać została poprawnie utworzona i ma właściwe bazowe/własne statystyki
        Assert.IsNotNull(goblin, "Instancja czarodzieja nie powinna być null.");
        Assert.AreEqual(characterName, goblin.Name, "Nazwa postaci powinna być zgodna z podaną w konstruktorze.");
        Assert.AreEqual(CharacterClass.Goblin, goblin.Class, "Klasa postaci powinna być ustawiona na Wizard.");

        // Testowanie konkretnych wartości statystyk zgodnych z założeniami klasy Wizard
        Assert.AreEqual(105, goblin.Health, "Wartość Health powinna wynosić 105.");
        Assert.AreEqual(52, goblin.Strength, "Wartość Strength powinna wynosić 52.");
        Assert.AreEqual(5, goblin.Intelligence, "Wartość Intelligence powinna wynosić 5.");
        Assert.AreEqual(32, goblin.Agility, "Wartość Agility powinna wynosić 32.");
    }
}

