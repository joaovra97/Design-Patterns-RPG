namespace Facade.ExternalSystems
{
	// Subsistema 2: InventorySystem
	public class InventorySystem
	{
		public void AddItem(string itemName)
		{
			Console.WriteLine($"Adding {itemName} to the inventory.");
		}

		public void RemoveItem(string itemName)
		{
			Console.WriteLine($"Removing {itemName} from the inventory.");
		}
	}
}