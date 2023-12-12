namespace AbstractFactory.Armors;

// Produto Concreto: Diferentes tipos de armaduras (Plate Armor)
public class PlateArmor : IArmor
{
	public void Defend()
	{
		Console.WriteLine("Defending with plate armor!");
	}
}