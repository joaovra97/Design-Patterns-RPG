using Visitor.Elements;

namespace Visitor.Visitors
{
	// Interface do Visitor: IVisitor
	public interface IVisitor
	{
		void VisitCharacter(Character character);
		void VisitMonster(Monster monster);
	}
}