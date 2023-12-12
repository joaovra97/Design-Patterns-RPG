namespace ChainOfResponsibility.Handlers;

// Manipulador Concreto: DefenseHandler
public class DefenseHandler : CharacterHandler
{
	public override void HandleRequest(CharacterAction action)
	{
		if (action.Type == ActionType.Defense)
		{
			Console.WriteLine($"Handling defense action for character: {action.CharacterName}");
		}
		else
		{
			successor?.HandleRequest(action);
		}
	}
}