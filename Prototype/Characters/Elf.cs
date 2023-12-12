namespace Prototype.Characters
{
	// Protótipo Concreto: Elf
	public class Elf : CharacterPrototype
	{
		public Elf(string race)
		{
			Race = race;
		}

		public override CharacterPrototype Clone()
		{
			return MemberwiseClone() as CharacterPrototype;
		}
	}
}