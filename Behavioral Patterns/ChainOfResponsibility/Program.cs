using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
	public class Program
	{
		public static void Main()
		{
			// Criando a cadeia de responsabilidade
			CharacterHandler attackHandler = new AttackHandler();
			CharacterHandler defenseHandler = new DefenseHandler();

			attackHandler.SetSuccessor(defenseHandler);

			// Manipulando diferentes ações de personagens
			Console.WriteLine("Handling character actions:");

			var attackAction = new CharacterAction("Warrior", ActionType.Attack);
			attackHandler.HandleRequest(attackAction);

			var defenseAction = new CharacterAction("Mage", ActionType.Defense);
			attackHandler.HandleRequest(defenseAction);

			// Adicionando um novo manipulador à cadeia
			CharacterHandler customHandler = new CustomHandler();
			defenseHandler.SetSuccessor(customHandler);

			// Manipulando uma ação customizada
			var customAction = new CharacterAction("Rogue", ActionType.Custom);
			attackHandler.HandleRequest(customAction);
		}
	}
}