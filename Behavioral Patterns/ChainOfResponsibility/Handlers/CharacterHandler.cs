namespace ChainOfResponsibility.Handlers;

// Manipulador: CharacterHandler
public abstract class CharacterHandler
{
	protected CharacterHandler successor;

	public void SetSuccessor(CharacterHandler successor)
	{
		this.successor = successor;
	}

	public abstract void HandleRequest(CharacterAction action);
}