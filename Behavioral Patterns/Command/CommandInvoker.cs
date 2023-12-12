using Command.Commands;

namespace Command
{
	// Invocador: CommandInvoker
	public class CommandInvoker
	{
		private readonly List<ICommand> commands = new();

		public void AddCommand(ICommand command)
		{
			commands.Add(command);
		}

		public void ExecuteCommands()
		{
			foreach (var command in commands)
			{
				command.Execute();
			}

			commands.Clear();
		}
	}
}