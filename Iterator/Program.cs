using Iterator.Iterators;

namespace Iterator
{
	public class Program
	{
		public static void Main()
		{
			// Criando uma coleção de personagens
			var characterCollection = new CharacterCollection();
			characterCollection.AddCharacter(new Character("Warrior"));
			characterCollection.AddCharacter(new Character("Mage"));
			characterCollection.AddCharacter(new Character("Rogue"));

			// Iterando sobre os personagens
			IIterator iterator = characterCollection.GetIterator();

			// Iterating over the characters
			Console.WriteLine("Iterating over characters:");
			while (!iterator.IsDone())
			{
				Character currentCharacter = iterator.CurrentCharacter;
				Console.WriteLine($"Character: {currentCharacter.Name}");
				iterator.Next();
			}
		}
	}
}