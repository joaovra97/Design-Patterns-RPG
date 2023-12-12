namespace Strategy.Strategies
{
	// Estratégia Concreta: MagicAttack
	public class MagicAttack : IAttackStrategy
	{
		public void ExecuteAttack(string playerName)
		{
			Console.WriteLine($"{playerName} casts a magical spell for a powerful attack!");
		}
	}
}