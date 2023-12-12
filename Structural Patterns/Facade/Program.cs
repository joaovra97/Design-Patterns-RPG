namespace Facade;

public class Program
{
	public static void Main()
	{
		// Utilizando a fachada do jogo RPG para simplificar as interações
		var rpgGame = new RpgGameFacade();

		Console.WriteLine("Starting RPG Game:");

		// Criação simplificada de personagem usando a fachada
		rpgGame.CreateAndEquipCharacter("Gilnelis", "Warrior", "Sword");

		// Início do combate simplificado usando a fachada
		rpgGame.StartCombat();

		Console.WriteLine("RPG Game Ended.");
	}
}