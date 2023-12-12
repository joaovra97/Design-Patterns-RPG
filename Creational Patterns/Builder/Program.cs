using Builder.Builders;

namespace Builder
{
	public class Program
	{
		public static void Main()
		{
			// Construindo um personagem Elfo
			var director = new CharacterDirector();

			ICharacterBuilder elfBuilder = new ElfBuilder();
			director.Construct(elfBuilder);
			Character elfCharacter = elfBuilder.GetCharacter();

			Console.WriteLine("Elf character created:");
			elfCharacter.DisplayCharacterInfo();

			Console.WriteLine();

			// Construindo um personagem Orc
			ICharacterBuilder orcBuilder = new OrcBuilder();
			director.Construct(orcBuilder);
			Character orcCharacter = orcBuilder.GetCharacter();

			Console.WriteLine("Orc character created:");
			orcCharacter.DisplayCharacterInfo();
		}
	}
}