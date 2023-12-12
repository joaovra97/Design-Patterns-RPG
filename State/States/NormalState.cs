namespace State.States
{
    // Estado Concreto: NormalState
    public class NormalState : ICharacterState
    {
        public void HandleState(Character context)
        {
            Console.WriteLine($"{context.Name} is in normal state. Ready for action!");
        }
    }
}