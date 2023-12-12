namespace Memento
{
	public class Program
	{
		public static void Main()
		{
			// Creating an character
			var playerCharacter = new Character("Hero", 100);

			// Creating a caretaker to manage mementos
			var caretaker = new MementoCaretaker();

			// Saving initial state
			caretaker.AddMemento(playerCharacter.SaveState());

			// Performing actions and saving states
			playerCharacter.TakeDamage(30);
			caretaker.AddMemento(playerCharacter.SaveState());

			playerCharacter.Heal(20);
			caretaker.AddMemento(playerCharacter.SaveState());

			// Restoring to a previous state
			Console.WriteLine("Restoring to a previous state:");
			playerCharacter.RestoreState(caretaker.GetMemento(1)); // Restoring to the state after taking damage
		}
	}
}