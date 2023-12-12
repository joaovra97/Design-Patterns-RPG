using Facade.ExternalSystems;

namespace Facade
{
    // Fachada: RpgGameFacade
    public class RpgGameFacade
	{
		private readonly CharacterCreationSystem characterCreation;
		private readonly InventorySystem inventory;
		private readonly CombatSystem combat;

		public RpgGameFacade()
		{
			characterCreation = new CharacterCreationSystem();
			inventory = new InventorySystem();
			combat = new CombatSystem();
		}

		// Método da fachada para simplificar a criação de personagens
		public void CreateAndEquipCharacter(string characterName, string characterClass, string initialItem)
		{
			characterCreation.CreateCharacter(characterName, characterClass);
			inventory.AddItem(initialItem);
		}

		// Método da fachada para simplificar o início do combate
		public void StartCombat()
		{
			combat.StartCombat();
		}
	}
}