using Bridge.Weapons;

namespace Bridge.Characters
{
    // Abstração Refinada: Elf
    public class Elf : Character
    {
        // Construtor chama o construtor base com uma arma específica
        public Elf(IWeapon weapon) : base(weapon) { }

        // Substitui o método Display com comportamento específico de elfo
        public override void Display()
        {
            Console.WriteLine("This is an Elf character.");
        }
    }
}