namespace FactoryMethod.Characters
{
	// Classe concreta que implementam a interface ICharacter (Mage)
	public class Mage : ICharacter
	{
		public void Attack()
		{
			Console.WriteLine("Mage casting a fireball!");
		}

		public void Defend()
		{
			Console.WriteLine("Mage conjuring a magic shield!");
		}
	}
}