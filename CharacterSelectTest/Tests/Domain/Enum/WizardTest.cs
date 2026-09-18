using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

[TestClass]
public class WizardTest
{
    [TestMethod]
    public void TestWizardCreationAndBaseStats()
    {
        // Arrange & Act - Testowanie tworzenia nowej postaci i podstawowych statystyk
        string characterName = "wizard";
        var wizard = new Wizard(characterName);

        // Assert - Sprawdzamy, czy postać została poprawnie utworzona i ma właściwe bazowe/własne statystyki
        Assert.IsNotNull(wizard, "Instancja czarodzieja nie powinna być null.");
        Assert.AreEqual(characterName, wizard.Name, "Nazwa postaci powinna być zgodna z podaną w konstruktorze.");
        Assert.AreEqual(CharacterClass.Wizard, wizard.Class, "Klasa postaci powinna być ustawiona na Wizard.");

        // Testowanie konkretnych wartości statystyk zgodnych z założeniami klasy Wizard
        Assert.AreEqual(230, wizard.Health, "Wartość Health powinna wynosić 230.");
        Assert.AreEqual(230, wizard.Strength, "Wartość Strength powinna wynosić 230.");
        Assert.AreEqual(30, wizard.Intelligence, "Wartość Intelligence powinna wynosić 30.");
        Assert.AreEqual(16, wizard.Agility, "Wartość Agility powinna wynosić 16.");
    }
}
