namespace Iterator.Iterators
{
	// Interface do Iterador: IIterator
	public interface IIterator
	{
		Character First();
		Character Next();
		bool IsDone();
		Character CurrentCharacter { get; }
	}
}