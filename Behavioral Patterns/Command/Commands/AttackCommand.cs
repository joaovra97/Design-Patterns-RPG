namespace Command.Commands
{
	// Comando Concreto: AttackCommand
	public class AttackCommand : ICommand
	{
		private readonly CharacterReceiver _character;

		public AttackCommand(CharacterReceiver character)
		{
			_character = character;
		}

		public void Execute()
		{
			_character.Attack();
		}
	}
}