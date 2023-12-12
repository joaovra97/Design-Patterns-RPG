namespace Strategy.Strategies;

// Estratégia Concreta: SwordAttack
public class SwordAttack : IAttackStrategy
{
	public void ExecuteAttack(string playerName)
	{
		Console.WriteLine($"{playerName} swings a sword for a slashing attack!");
	}
}