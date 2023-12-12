namespace AbstractFactory.Weapons
{
	// Produto Concreto: Diferentes tipos de armas (Sword)
	public class Sword : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Attacking with a sword!");
		}
	}
}