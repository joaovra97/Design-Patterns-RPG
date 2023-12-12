using Mediator.Mediators;

namespace Mediator;

public class Program
{
	public static void Main()
	{
		// Criando um mediator de combate
		ICombatMediator mediator = new CombatMediator();

		// Criando personagens para combate
		var warrior = new Character("Warrior", mediator);
		var mage = new Character("Mage", mediator);
		var rogue = new Character("Rogue", mediator);

		// Executando ações e observando a comunicação
		Console.WriteLine("Initiating combat:");

		warrior.PerformAction("Attack");
		mage.PerformAction("Cast Fireball");
		rogue.PerformAction("Sneak Attack");
	}
}