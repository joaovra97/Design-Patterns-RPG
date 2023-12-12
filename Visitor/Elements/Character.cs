using Visitor.Visitors;

namespace Visitor.Elements
{
    // Elemento Concreto: Character
    public class Character : IElement
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCharacter(this);
        }
    }
}