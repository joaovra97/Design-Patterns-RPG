namespace Observer.Observers;

// Observador Concreto: AllyObserver
public class AllyObserver : IPlayerObserver
{
	private readonly string _allyName;

	public AllyObserver(string allyName)
	{
		_allyName = allyName;
	}

	public void Update(string message)
	{
		Console.WriteLine($"{_allyName} received update: {message}");
	}
}