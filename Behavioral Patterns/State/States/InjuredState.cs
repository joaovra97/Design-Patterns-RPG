namespace State.States;

// Estado Concreto: InjuredState
public class InjuredState : ICharacterState
{
	public void HandleState(Character context)
	{
		Console.WriteLine($"{context.Name} is in injured state. Movement is slower.");
	}
}