using AbstractFactory.Armors;
using AbstractFactory.Characters;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories
{
    // Fábrica Concreta: Fábrica de Elfos
    public class ElfFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter()
        {
            return new Elf();
        }

        public IWeapon CreateWeapon()
        {
            return new Bow();
        }

        public IArmor CreateArmor()
        {
            return new Robe();
        }
    }
}