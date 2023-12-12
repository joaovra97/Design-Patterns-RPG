using FactoryMethod.Characters;
using FactoryMethod.Factories;

namespace FactoryMethod
{

	public class Program
	{
		public static void Main()
		{
			// Usando o Factory Method para criar diferentes tipos de personagens
			ICharacterFactory factory = new WarriorFactory();
			ICharacter warrior = factory.CreateCharacter();

			factory = new MageFactory();
			ICharacter mage = factory.CreateCharacter();

			factory = new ArcherFactory();
			ICharacter archer = factory.CreateCharacter();

			// Testando os personagens
			warrior.Attack();
			warrior.Defend();

			mage.Attack();
			mage.Defend();

			archer.Attack();
			archer.Defend();
		}
	}
}