using Visitor.Elements;

namespace Visitor.Visitors
{
	// Visitor Concreto: AttackVisitor
	public class AttackVisitor : IVisitor
	{
		public void VisitCharacter(Character character)
		{
			Console.WriteLine($"{character.Name} is attacked. Health decreased.");
		}

		public void VisitMonster(Monster monster)
		{
			Console.WriteLine($"{monster.Type} monster is attacked. Health decreased.");
		}
	}
}