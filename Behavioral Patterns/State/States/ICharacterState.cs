namespace State.States;

// Interface do Estado: ICharacterState
public interface ICharacterState
{
	void HandleState(Character context);
}