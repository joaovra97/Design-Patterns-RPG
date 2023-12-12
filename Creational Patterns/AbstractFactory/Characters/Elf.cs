namespace AbstractFactory.Characters
{
	// Produto Concreto: Diferentes tipos de personagens (Elf)
	public class Elf : ICharacter
	{
		public override void Display()
		{
			Console.WriteLine("Elf character created!");
		}
	}
}