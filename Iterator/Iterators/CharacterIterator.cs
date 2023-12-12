using Iterator.Collections;

namespace Iterator.Iterators
{
    // Iterador Concreto: CharacterIterator
    public class CharacterIterator : IIterator
    {
        private readonly CharacterCollection _characters;
        private int _currentIndex = 0;

        public CharacterIterator(CharacterCollection characters)
        {
            _characters = characters;
        }

        public Character First()
        {
            _currentIndex = 0;
            return _characters[_currentIndex];
        }

        public Character Next()
        {
            _currentIndex++;
            return IsDone() ? null : _characters[_currentIndex];
        }

        public bool IsDone()
        {
            return _currentIndex >= _characters.Count - 1;
        }

        public Character CurrentCharacter
        {
            get { return _characters[_currentIndex]; }
        }
    }
}