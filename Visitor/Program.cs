using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor
{
	public class Program
	{
		public static void Main()
		{
			var World = new World();
			World.AddElement(new Character("Hero", 100));
			World.AddElement(new Monster("Dragon", 50));

			IVisitor healVisitor = new HealVisitor();
			IVisitor attackVisitor = new AttackVisitor();

			Console.WriteLine("Executing actions in the world:");

			Console.WriteLine();
			Console.WriteLine("Healing Actions:");
			World.ExecuteAction(healVisitor);

			Console.WriteLine();
			Console.WriteLine("Attack Actions:");
			World.ExecuteAction(attackVisitor);
		}
	}
}