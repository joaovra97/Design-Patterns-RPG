namespace Builder.Builders;

// Builder Concreto: ElfBuilder
public class ElfBuilder : ICharacterBuilder
{
	private readonly Character elfCharacter = new();

	public void BuildRace()
	{
		elfCharacter.Race = "Elf";
	}

	public void BuildWeapon()
	{
		elfCharacter.Weapon = "Bow";
	}

	public void BuildArmor()
	{
		elfCharacter.Armor = "Elven Robe";
	}

	public Character GetCharacter()
	{
		return elfCharacter;
	}
}