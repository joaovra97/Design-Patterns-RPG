namespace Singleton;

// Singleton: GameManager
public class GameManager
{
	// Variável de instância estática privada
	private static GameManager instance;

	// Construtor privado para evitar instância externa
	private GameManager() { }

	// Método público para obter a instância do singleton
	public static GameManager Instance
	{
		get
		{
			// Inicialização tardia: cria a instância se ela não existir
			instance ??= new GameManager();
			return instance;
		}
	}

	// Métodos relacionados ao jogo
	public void StartGame()
	{
		Console.WriteLine("Game started!");
	}

	public void EndGame()
	{
		Console.WriteLine("Game ended!");
	}

	public void SaveGame()
	{
		Console.WriteLine("Game saved!");
	}
}