using AbstractFactory.Armors;
using AbstractFactory.Characters;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories
{
	// Fábrica Concreta: Fábrica de Orcs
	public class OrcFactory : ICharacterFactory
	{
		public ICharacter CreateCharacter()
		{
			return new Orc();
		}

		public IWeapon CreateWeapon()
		{
			return new Sword();
		}

		public IArmor CreateArmor()
		{
			return new PlateArmor();
		}
	}
}