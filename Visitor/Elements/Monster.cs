using Visitor.Visitors;

namespace Visitor.Elements
{
    // Elemento Concreto: Monster
    public class Monster : IElement
    {
        public string Type { get; private set; }
        public int Health { get; private set; }

        public Monster(string type, int strength)
        {
            Type = type;
            Health = strength;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitMonster(this);
        }
    }
}