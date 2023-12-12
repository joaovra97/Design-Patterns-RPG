namespace Bridge.Weapons
{
	// Implementador Concreto: Bow
	public class Bow : IWeapon
	{
		public void Attack()
		{
			Console.WriteLine("Attacking with a bow!");
		}
	}
}