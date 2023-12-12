using AbstractFactory.Armors;
using AbstractFactory.Characters;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories
{
	// Fábrica Abstrata: Fábrica de personagens
	public interface ICharacterFactory
	{
		ICharacter CreateCharacter();
		IWeapon CreateWeapon();
		IArmor CreateArmor();
	}
}