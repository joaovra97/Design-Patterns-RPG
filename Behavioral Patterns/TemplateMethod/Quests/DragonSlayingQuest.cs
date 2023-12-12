namespace TemplateMethod.Quests;

// Classe Concreta: DragonSlayingQuest
public class DragonSlayingQuest : Quest
{
	protected override void StartQuest()
	{
		Console.WriteLine("You received a quest to slay the dragon in the mountains.");
	}

	protected override void Explore()
	{
		Console.WriteLine("Climbing the mountains to reach the dragon's lair.");
	}

	protected override void Battle()
	{
		Console.WriteLine("Facing the fierce dragon in an epic battle.");
	}
}