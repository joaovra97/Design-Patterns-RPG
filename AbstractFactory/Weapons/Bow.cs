namespace AbstractFactory.Weapons
{
    // Produto Concreto: Diferentes tipos de armas (Bow)
    public class Bow : IWeapon
    {
        public void Attack()
        {
			Console.WriteLine("Attacking with a bow!");
		}
	}
}