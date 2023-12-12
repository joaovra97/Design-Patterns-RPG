namespace Proxy.Characters;

// Proxy: CharacterProxy
public class CharacterProxy : ICharacter
{
	private Character realCharacter;
	private readonly string characterName;

	public CharacterProxy(string name)
	{
		characterName = name;
	}

	// Lazy load e controle de acesso ao objeto real
	public void Display()
	{
		realCharacter ??= new Character(characterName);

		Console.WriteLine($"Displaying character (proxy): {characterName}");
		realCharacter.Display();
	}
}