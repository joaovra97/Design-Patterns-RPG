namespace Flyweight.Characters
{
	// Flyweight Concreto: Character
	public class Character : ICharacter
	{
		private readonly string _intrinsicState; // Estado intrínseco compartilhado

		public Character(string intrinsicState)
		{
			_intrinsicState = intrinsicState;
		}

		// Método Display com estado extrínseco como parâmetro
		public void Display(string uniqueState)
		{
			Console.WriteLine($"Character with Intrinsic State: {_intrinsicState}, Extrinsic State: {uniqueState}");
		}
	}
}