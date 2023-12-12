namespace State.States
{
    // Estado Concreto: PoisonedState
    public class PoisonedState : ICharacterState
    {
        public void HandleState(Character context)
        {
            Console.WriteLine($"{context.Name} is in poisoned state. Health is decreasing over time.");
        }
    }
}