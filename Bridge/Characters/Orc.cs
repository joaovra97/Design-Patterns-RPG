using Bridge.Weapons;

namespace Bridge.Characters
{
    // Abstração Refinada: Orc
    public class Orc : Character
    {
        // Construtor chama o construtor base com uma arma específica
        public Orc(IWeapon weapon) : base(weapon) { }

        // Substitui o método Display com comportamento específico de orc
        public override void Display()
        {
            Console.WriteLine("This is an Orc character.");
        }
    }
}