using FactoryMethod.Characters;

namespace FactoryMethod.Factories;

// Implementação do Factory Method para criar diferentes tipos de personagens (Warrior)
public class WarriorFactory : ICharacterFactory
{
	public ICharacter CreateCharacter()
	{
		return new Warrior();
	}
}