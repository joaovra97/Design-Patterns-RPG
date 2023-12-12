namespace ChainOfResponsibility.Handlers
{
	// Manipulador Concreto Customizado: CustomHandler
	public class CustomHandler : CharacterHandler
	{
		public override void HandleRequest(CharacterAction action)
		{
			if (action.Type == ActionType.Custom)
			{
				Console.WriteLine($"Handling custom action for character: {action.CharacterName}");
			}
			else
			{
				Console.WriteLine($"No handler found for action type {action.Type} for character {action.CharacterName}");
			}
		}
	}
}