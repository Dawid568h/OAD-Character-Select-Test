using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

[TestClass]
public class RougeTest
{
    [TestMethod]
    public void TestBarbarianCreationAndBaseStats()
    {
        // Arrange & Act - Testowanie tworzenia nowej postaci i podstawowych statystyk
        string characterName = "rouge";
        var rouge = new Rogue(characterName);

        // Assert - Sprawdzamy, czy postać została poprawnie utworzona i ma właściwe bazowe/własne statystyki
        Assert.IsNotNull(rouge, "Instancja czarodzieja nie powinna być null.");
        Assert.AreEqual(characterName, rouge.Name, "Nazwa postaci powinna być zgodna z podaną w konstruktorze.");
        Assert.AreEqual(CharacterClass.Rogue, rouge.Class, "Klasa postaci powinna być ustawiona na Wizard.");

        // Testowanie konkretnych wartości statystyk zgodnych z założeniami klasy Wizard
        Assert.AreEqual(95, rouge.Health, "Wartość Health powinna wynosić 95.");
        Assert.AreEqual(9, rouge.Strength, "Wartość Strength powinna wynosić 9.");
        Assert.AreEqual(8, rouge.Intelligence, "Wartość Intelligence powinna wynosić 8.");
        Assert.AreEqual(15, rouge.Agility, "Wartość Agility powinna wynosić 15.");
    }
}
