using Observer.Observers;

namespace Observer
{
	public class Program
	{
		public static void Main()
		{
			// Criando um subject jogador
			var player = new PlayerSubject("Hero", 100);

			// Criando observadores de inimigos e aliados
			IPlayerObserver enemyObserver = new EnemyObserver("Evil Goblin");
			IPlayerObserver allyObserver = new AllyObserver("Friendly Elf");

			// Anexando observadores ao subject jogador
			player.Attach(enemyObserver);
			player.Attach(allyObserver);

			// Realizando ações e notificando observadores
			Console.WriteLine("Initiating RPG gameplay:");

			player.TakeDamage(30);
			player.Heal(20);
		}
	}
}