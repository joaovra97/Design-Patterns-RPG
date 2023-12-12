namespace Facade.ExternalSystems;

// Subsistema 1: CharacterCreationSystem
public class CharacterCreationSystem
{
	public void CreateCharacter(string characterName, string characterClass)
	{
		Console.WriteLine($"Creating {characterClass} character named {characterName}.");
	}
}