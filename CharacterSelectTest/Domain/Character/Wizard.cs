using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Wizard : Entity.Character
{
    public Wizard(string name) : base(name, CharacterClass.Wizard)
    {
        Health = 230;
        Strength = 230;
        Intelligence = 30;
        Agility = 16;
    }
}