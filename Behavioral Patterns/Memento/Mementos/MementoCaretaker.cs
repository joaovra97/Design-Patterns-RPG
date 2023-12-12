namespace Memento.Mementos;

// Caretaker: MementoCaretaker
public class MementoCaretaker
{
	private readonly List<ICharacterMemento> mementos = new();

	public void AddMemento(ICharacterMemento memento)
	{
		mementos.Add(memento);
	}

	public ICharacterMemento GetMemento(int index)
	{
		return mementos[index];
	}
}