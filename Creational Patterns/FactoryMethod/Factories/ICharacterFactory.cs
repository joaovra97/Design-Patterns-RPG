using FactoryMethod.Characters;

namespace FactoryMethod.Factories
{
	// Interface do Factory Method
	public interface ICharacterFactory
	{
		public ICharacter CreateCharacter();
	}
}