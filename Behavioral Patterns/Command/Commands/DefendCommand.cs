namespace Command.Commands
{
	// Comando Concreto: DefendCommand
	public class DefendCommand : ICommand
	{
		private readonly CharacterReceiver _character;

		public DefendCommand(CharacterReceiver character)
		{
			_character = character;
		}

		public void Execute()
		{
			_character.Defend();
		}
	}
}