using Observer.Observers;

namespace Observer
{
	// Subject: PlayerSubject
	public class PlayerSubject
	{
		private readonly List<IPlayerObserver> _observers = new();
		private readonly string _playerName;
		private int _playerHealth;

		public PlayerSubject(string playerName, int initialHealth)
		{
			_playerName = playerName;
			_playerHealth = initialHealth;
		}

		public void Attach(IPlayerObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IPlayerObserver observer)
		{
			_observers.Remove(observer);
		}

		public void NotifyObservers(string message)
		{
			foreach (var observer in _observers)
			{
				observer.Update(message);
			}
		}

		public void TakeDamage(int damage)
		{
			_playerHealth -= damage;
			NotifyObservers($"{_playerName} took {damage} damage. Current health: {_playerHealth}");
		}

		public void Heal(int healing)
		{
			_playerHealth += healing;
			NotifyObservers($"{_playerName} healed {healing} points. Current health: {_playerHealth}");
		}
	}
}