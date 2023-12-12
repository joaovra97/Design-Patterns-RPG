namespace Bridge.Weapons
{
    // Implementador Concreto: Sword
    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with a sword!");
        }
    }
}