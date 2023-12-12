namespace Builder
{
    // Produto: Character
    public class Character
    {
        public string Race { get; set; }
        public string Weapon { get; set; }
        public string Armor { get; set; }

        public void DisplayCharacterInfo()
        {
            Console.WriteLine($"Race: {Race}");
            Console.WriteLine($"Weapon: {Weapon}");
            Console.WriteLine($"Armor: {Armor}");
        }
    }
}