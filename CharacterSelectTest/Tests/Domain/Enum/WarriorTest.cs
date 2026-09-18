using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

[TestClass]
public class WarriorTest
{
    [TestMethod]
    public void TestWarriorCreationAndBaseStats()
    {
        // Arrange & Act - Testowanie tworzenia nowej postaci i podstawowych statystyk
        string characterName = "warrior";
        var warrior = new Warrior(characterName);

        // Assert - Sprawdzamy, czy postać została poprawnie utworzona i ma właściwe bazowe/własne statystyki
        Assert.IsNotNull(warrior, "Instancja czarodzieja nie powinna być null.");
        Assert.AreEqual(characterName, warrior.Name, "Nazwa postaci powinna być zgodna z podaną w konstruktorze.");
        Assert.AreEqual(CharacterClass.Wizard, warrior.Class, "Klasa postaci powinna być ustawiona na Wizard.");

        // Testowanie konkretnych wartości statystyk zgodnych z założeniami klasy Wizard
        Assert.AreEqual(120, warrior.Health, "Wartość Health powinna wynosić 230.");
        Assert.AreEqual(14, warrior.Strength, "Wartość Strength powinna wynosić 230.");
        Assert.AreEqual(6, warrior.Intelligence, "Wartość Intelligence powinna wynosić 30.");
        Assert.AreEqual(8, warrior.Agility, "Wartość Agility powinna wynosić 16.");
    }
}
