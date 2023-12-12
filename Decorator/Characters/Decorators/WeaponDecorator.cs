namespace Decorator.Characters.Decorators
{
    // Decorador Concreto: WeaponDecorator
    public class WeaponDecorator : CharacterDecorator
    {
        private readonly string _weapon;

        public WeaponDecorator(ICharacter character, string weapon) : base(character)
        {
            _weapon = weapon;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Equipped with a {_weapon}.");
        }
    }
}