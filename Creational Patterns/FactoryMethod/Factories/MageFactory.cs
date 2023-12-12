using FactoryMethod.Characters;

namespace FactoryMethod.Factories;

// Implementação do Factory Method para criar diferentes tipos de personagens (Mage)
public class MageFactory : ICharacterFactory
{
	public ICharacter CreateCharacter()
	{
		return new Mage();
	}
}