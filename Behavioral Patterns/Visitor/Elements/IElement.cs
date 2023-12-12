using Visitor.Visitors;

namespace Visitor.Elements
{
	// Interface do Elemento: IElement
	public interface IElement
	{
		void Accept(IVisitor visitor);
	}
}