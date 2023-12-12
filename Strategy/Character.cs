using Strategy.Strategies;

namespace Strategy
{
    // Contexto: Character
    public class Character
	{
		private IAttackStrategy attackStrategy;
		public string Name { get; private set; }

		public Character(string name, IAttackStrategy initialAttackStrategy)
		{
			Name = name;
			attackStrategy = initialAttackStrategy;
		}

		public void SetAttackStrategy(IAttackStrategy newAttackStrategy)
		{
			attackStrategy = newAttackStrategy;
		}

		public void PerformAttack()
		{
			attackStrategy.ExecuteAttack(Name);
		}
	}
}