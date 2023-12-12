namespace Decorator.Characters
{
    // Componente Concreto: Elf
    public class Elf : ICharacter
    {
        private readonly string _name;

        public Elf(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine($"This is an Elf called {_name}");
        }
    }
}