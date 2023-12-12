namespace FactoryMethod.Characters;

// Classe concreta que implementam a interface ICharacter (Warrior)
public class Warrior : ICharacter
{
	public void Attack()
	{
		Console.WriteLine("Warrior attacking with a sword!");
	}

	public void Defend()
	{
		Console.WriteLine("Warrior defending with a shield!");
	}
}