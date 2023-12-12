using Strategy.Strategies;

namespace Strategy
{
	public class Program
	{
		public static void Main()
		{
			// Criando um personagem com uma estratégia inicial de ataque
			var playerCharacter = new Character("Hero", new SwordAttack());

			// Realizando ataques e observando diferentes estratégias
			Console.WriteLine("Initiating gameplay:");

			playerCharacter.PerformAttack();

			// Alterando a estratégia de ataque durante o jogo
			playerCharacter.SetAttackStrategy(new MagicAttack());
			playerCharacter.PerformAttack();

			playerCharacter.SetAttackStrategy(new BowAttack());
			playerCharacter.PerformAttack();
		}
	}
}