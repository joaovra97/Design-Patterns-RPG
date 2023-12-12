namespace Prototype.Characters;

// Protótipo Concreto: Orc
public class Orc : CharacterPrototype
{
	public Orc(string race)
	{
		Race = race;
	}

	public override CharacterPrototype Clone()
	{
		return MemberwiseClone() as CharacterPrototype;
	}
}