using FactoryMethod.Characters;

namespace FactoryMethod.Factories
{
	// Implementação do Factory Method para criar diferentes tipos de personagens (Archer)
	public class ArcherFactory : ICharacterFactory
	{
		public ICharacter CreateCharacter()
		{
			return new Archer();
		}
	}
}