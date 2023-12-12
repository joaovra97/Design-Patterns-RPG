namespace Singleton
{	
	public class Program
	{
		public static void Main()
		{
			// Acessando a instância do singleton
			GameManager gameManager = GameManager.Instance;

			// Usando os métodos relacionados ao jogo
			gameManager.StartGame();
			gameManager.SaveGame();
			gameManager.EndGame();
		}
	}
}