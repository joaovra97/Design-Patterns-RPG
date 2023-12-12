using Iterator.Iterators;

namespace Iterator.Collections
{
    // Coleção Concreta: CharacterCollection
    public class CharacterCollection : ICharacterCollection
    {
        private readonly List<Character> characterList = new();

        public void AddCharacter(Character character)
        {
            characterList.Add(character);
        }

        public void RemoveCharacter(Character character)
        {
            characterList.Remove(character);
        }

        public IIterator GetIterator()
        {
            return new CharacterIterator(this);
        }

        public Character this[int index]
        {
            get { return characterList[index]; }
        }

        public int Count
        {
            get { return characterList.Count; }
        }
    }
}