namespace Command;

// Receptor: CharacterReceiver
public class CharacterReceiver
{
	private readonly string _characterName;

	public CharacterReceiver(string characterName)
	{
		_characterName = characterName;
	}

	public void Attack()
	{
		Console.WriteLine($"{_characterName} is attacking!");
	}

	public void Defend()
	{
		Console.WriteLine($"{_characterName} is defending!");
	}
}