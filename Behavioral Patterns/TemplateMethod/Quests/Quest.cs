namespace TemplateMethod.Quests
{
	// Classe Abstrata: Quest
	public abstract class Quest
	{
		// Método Template
		public void ExecuteQuest()
		{
			Prepare();
			StartQuest();
			Explore();
			Battle();
			ConcludeQuest();
		}

		// Métodos abstratos a serem implementados pelas classes concretas
		protected abstract void StartQuest();
		protected abstract void Explore();
		protected abstract void Battle();

		// Common steps
		private void Prepare()
		{
			Console.WriteLine("Preparing for the quest...");
		}

		private void ConcludeQuest()
		{
			Console.WriteLine(" quest concluded. Well done!");
		}
	}
}