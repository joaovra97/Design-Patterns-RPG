namespace Decorator.Characters;

// Componente Concreto: Orc
public class Orc : ICharacter
{
	private readonly string _name;

	public Orc(string name)
	{
		_name = name;
	}

	public void Display()
	{
		Console.WriteLine($"This is an Orc called {_name}");
	}
}