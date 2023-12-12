namespace Prototype.Characters
{
    // Protótipo: CharacterPrototype
    public abstract class CharacterPrototype
    {
        public string Race { get; set; }
        public abstract CharacterPrototype Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Race: {Race}");
        }
    }
}