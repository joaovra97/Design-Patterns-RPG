namespace Observer.Observers;

// Observador Concreto: EnemyObserver
public class EnemyObserver : IPlayerObserver
{
	private readonly string _enemyName;

	public EnemyObserver(string enemyName)
	{
		_enemyName = enemyName;
	}

	public void Update(string message)
	{
		Console.WriteLine($"{_enemyName} received update: {message}");
	}
}