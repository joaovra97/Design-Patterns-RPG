namespace ChainOfResponsibility.Handlers;

// Manipulador Concreto: AttackHandler
public class AttackHandler : CharacterHandler
{
	public override void HandleRequest(CharacterAction action)
	{
		if (action.Type == ActionType.Attack)
		{
			Console.WriteLine($"Handling attack action for character: {action.CharacterName}");
		}
		else
		{
			successor?.HandleRequest(action);
		}
	}
}