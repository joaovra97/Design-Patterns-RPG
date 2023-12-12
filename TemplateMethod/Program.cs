using TemplateMethod.Quests;

namespace TemplateMethod
{
    public class Program
	{
		public static void Main()
		{
			// Criando e executando missões de 
			Quest goblinHuntQuest = new GoblinHuntQuest();
			Quest dragonSlayingQuest = new DragonSlayingQuest();

			Console.WriteLine("Embarking on quests:");

			Console.WriteLine();
			Console.WriteLine("Goblin Hunt Quest:");
			goblinHuntQuest.ExecuteQuest();

			Console.WriteLine();
			Console.WriteLine("Dragon Slaying Quest:");
			dragonSlayingQuest.ExecuteQuest();
		}
	}
}