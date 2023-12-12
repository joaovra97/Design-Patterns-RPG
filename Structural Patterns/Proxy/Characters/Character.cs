namespace Proxy.Characters;

// Subject real: Character
public class Character : ICharacter
{
	private readonly string characterName;

	public Character(string name)
	{
		characterName = name;
		LoadCharacterData();
	}

	// Simular o carregamento de dados do personagem (operação cara)
	private void LoadCharacterData()
	{
		Console.WriteLine($"Loading data for character: {characterName}");
		// Processo de simulação de carregamento...
	}

	public void Display()
	{
		Console.WriteLine($"Displaying character: {characterName}");
	}
}