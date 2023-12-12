namespace FactoryMethod.Characters
{
	// Classe concreta que implementam a interface ICharacter
	public class Archer : ICharacter
	{
		public void Attack()
		{
			Console.WriteLine("Archer shooting a precise arrow!");
		}

		public void Defend()
		{
			Console.WriteLine("Archer dodging with agility!");
		}
	}
}