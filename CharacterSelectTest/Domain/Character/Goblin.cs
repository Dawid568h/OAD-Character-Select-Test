using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Goblin : Entity.Character
{
    public Goblin(string name) : base(name, CharacterClass.Goblin)
    {
        Health = 105;
        Strength = 52;
        Intelligence = 5;
        Agility = 32;
    }
}