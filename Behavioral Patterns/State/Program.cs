namespace State
{
	public class Program
	{
		public static void Main()
		{
			// Criando um personagem
			var playerCharacter = new Character("Hero");

			// Realizando ações e observando mudanças de estado
			Console.WriteLine("Initiating gameplay:");

			playerCharacter.TakeDamage(30);
			playerCharacter.FullHeal();
			playerCharacter.TakePoison();
			playerCharacter.FullHeal();
		}
	}
}