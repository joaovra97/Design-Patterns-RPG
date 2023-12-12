using Iterator.Iterators;

namespace Iterator.Collections
{
    // Interface da Coleção: ICharacterCollection
    public interface ICharacterCollection
    {
        IIterator GetIterator();
    }
}