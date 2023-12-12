using Prototype.Characters;

namespace Prototype
{
    public class Program
	{
		public static void Main()
		{
			var characterManager = new CharacterManager();

			// Cria um personagem Elfo
			CharacterPrototype elfCharacter = characterManager.CreateElf();
			Console.WriteLine("New Elf character created:");
			elfCharacter.DisplayInfo();

			Console.WriteLine();

			// Cria um personagem Orc
			CharacterPrototype orcCharacter = characterManager.CreateOrc();
			Console.WriteLine("New Orc character created:");
			orcCharacter.DisplayInfo();
		}
	}
}