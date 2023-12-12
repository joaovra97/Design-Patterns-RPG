namespace Strategy.Strategies
{
	// Estratégia Concreta: BowAttack
	public class BowAttack : IAttackStrategy
	{
		public void ExecuteAttack(string playerName)
		{
			Console.WriteLine($"{playerName} shoots arrows from a bow for a ranged attack!");
		}
	}
}