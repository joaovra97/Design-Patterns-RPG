namespace ChainOfResponsibility
{
	// Requisição: CharacterAction
	public class CharacterAction
	{
		public string CharacterName { get; set; }
		public ActionType Type { get; set; }

		public CharacterAction(string characterName, ActionType type)
		{
			CharacterName = characterName;
			Type = type;
		}
	}
}