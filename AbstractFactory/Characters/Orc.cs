namespace AbstractFactory.Characters
{
	// Produto Concreto: Diferentes tipos de personagens (Orc)
	public class Orc : ICharacter
    {
        public override void Display()
        {
			Console.WriteLine("Orc character created!");
		}
	}
}