using Command.Commands;

namespace Command
{
	public class Program
	{
		public static void Main()
		{
			// Criando objetos receptores
			var warrior = new CharacterReceiver("Warrior");
			var mage = new CharacterReceiver("Mage");

			// Criando objetos de comando com receptores associados
			ICommand attackCommandWarrior = new AttackCommand(warrior);
			ICommand defendCommandMage = new DefendCommand(mage);

			// Criando invocador e associando comandos
			var invoker = new CommandInvoker();
			invoker.AddCommand(attackCommandWarrior);
			invoker.AddCommand(defendCommandMage);

			// Executando comandos
			Console.WriteLine("Executing commands:");
			invoker.ExecuteCommands();
		}
	}
}