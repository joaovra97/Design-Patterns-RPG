namespace Decorator.Characters.Decorators
{
    // Decorador Concreto: ArmorDecorator
    public class ArmorDecorator : CharacterDecorator
    {
        private readonly string _armor;

        public ArmorDecorator(ICharacter character, string armor) : base(character)
        {
            _armor = armor;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Wearing {_armor} armor.");
        }
    }
}