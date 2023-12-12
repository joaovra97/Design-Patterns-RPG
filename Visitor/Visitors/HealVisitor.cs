using Visitor.Elements;

namespace Visitor.Visitors
{
	// Visitor Concreto: HealVisitor
	public class HealVisitor : IVisitor
	{
		public void VisitCharacter(Character character)
		{
			Console.WriteLine($"{character.Name} is healed. Health increased.");
		}

		public void VisitMonster(Monster monster)
		{
			Console.WriteLine($"Healing does not affect {monster.Type} monsters.");
		}
	}
}