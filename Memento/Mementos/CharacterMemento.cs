namespace Memento.Mementos
{
    // Memento Concreto: CharacterMemento
    public class CharacterMemento : ICharacterMemento
    {
        private readonly string _state;

        public CharacterMemento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }
}