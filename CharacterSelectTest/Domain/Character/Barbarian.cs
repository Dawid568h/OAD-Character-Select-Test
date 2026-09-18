using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Barbarian : Entity.Character
{
    public Barbarian(string name) : base(name, CharacterClass.Barbarian)
    {
        Health = 205;
        Strength = 34;
        Intelligence = 16;
        Agility = 18;
    }
}