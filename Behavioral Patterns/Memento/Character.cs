using Memento.Mementos;

namespace Memento
{
	// Originator: Character
	public class Character
	{
		private string _name;
		private int _healthPoints;

		public Character(string name, int healthPoints)
		{
			_name = name;
			_healthPoints = healthPoints;
		}

		public void TakeDamage(int damage)
		{
			_healthPoints -= damage;
			Console.WriteLine($"{_name} took {damage} damage. Current HP: {_healthPoints}");
		}

		public void Heal(int healing)
		{
			_healthPoints += healing;
			Console.WriteLine($"{_name} healed {healing} points. Current HP: {_healthPoints}");
		}

		public ICharacterMemento SaveState()
		{
			return new CharacterMemento($"Name: {_name}, HP: {_healthPoints}");
		}

		public void RestoreState(ICharacterMemento memento)
		{
			if (memento is CharacterMemento characterMemento)
			{
				string[] stateParts = characterMemento.GetState().Split(", ");

				// Extraindo o nome após "Nome: "
				_name = stateParts[0][6..];

				// Extraindo HP após "HP: "
				_healthPoints = int.Parse(stateParts[1][4..]);

				Console.WriteLine($"{_name}'s state has been restored. Current HP: {_healthPoints}");
			}
		}
	}
}