namespace Decorator.Characters.Decorators
{
    // Decorador: CharacterDecorator
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter character;

        public CharacterDecorator(ICharacter character)
        {
            this.character = character;
        }

        public virtual void Display()
        {
            character.Display();
        }
    }
}