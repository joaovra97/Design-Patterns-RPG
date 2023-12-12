namespace Mediator.Mediators;

// Mediador Concreto: CombatMediator
public class CombatMediator : ICombatMediator
{
	private readonly List<Character> characters = new();

	public void RegisterParticipant(Character character)
	{
		characters.Add(character);
	}

	public void SendAction(Character sender, string action)
	{
		foreach (var character in characters)
		{
			if (character != sender)
			{
				character.ReceiveAction(action);
			}
		}
	}
}