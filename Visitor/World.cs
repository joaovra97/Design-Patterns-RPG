using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor
{
    // Estrutura de Objetos: World
    public class World
	{
		private readonly List<IElement> elements = new();

		public void AddElement(IElement element)
		{
			elements.Add(element);
		}

		public void ExecuteAction(IVisitor visitor)
		{
			foreach (var element in elements)
			{
				element.Accept(visitor);
			}
		}
	}
}