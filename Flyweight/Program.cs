using Flyweight.Characters;

namespace Flyweight
{
    public class Program
	{
		public static void Main()
		{
			// Fábrica flyweight para gerenciar personagens compartilhados
			var characterFactory = new CharacterFactory();

			// Criar e exibir personagens com estado extrínseco exclusivo
			ICharacter elf1 = characterFactory.GetCharacter("Elf");
			elf1.Display("Level 5");

			ICharacter orc1 = characterFactory.GetCharacter("Orc");
			orc1.Display("Level 3");

			// Reutilizar o personagem flyweight existente com estado intrínseco "Elfo"
			ICharacter elf2 = characterFactory.GetCharacter("Elf");
			elf2.Display("Level 7");
		}
	}
}