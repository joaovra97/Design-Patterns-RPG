namespace AbstractFactory.Armors;

// Produto Concreto: Diferentes tipos de armaduras (Robe)
public class Robe : IArmor
{
	public void Defend()
	{
		Console.WriteLine("Defending with a magical robe!");
	}
}