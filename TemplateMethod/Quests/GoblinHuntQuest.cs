namespace TemplateMethod.Quests
{
	// Classe Concreta: GoblinHuntQuest
	public class GoblinHuntQuest : Quest
	{
		protected override void StartQuest()
		{
			Console.WriteLine("You received a quest to hunt goblins in the forest.");
		}

		protected override void Explore()
		{
			Console.WriteLine("Exploring the forest to find goblin locations.");
		}

		protected override void Battle()
		{
			Console.WriteLine("Engaging in battles with goblins.");
		}
	}
}