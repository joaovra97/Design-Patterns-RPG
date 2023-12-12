namespace Composite.PartyMembers;

// Folha: Elf
public class Elf : IPartyMember
{
	private readonly string _name;

	public Elf(string name)
	{
		_name = name;
	}

	public void Display()
	{
		Console.WriteLine($"Elf named {_name}");
	}
}