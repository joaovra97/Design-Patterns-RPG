using Mediator.Mediators;

namespace Mediator
{
	// Colleague: Character
	public class Character
	{
		private readonly string _name;
		private readonly ICombatMediator _mediator;

		public Character(string name, ICombatMediator mediator)
		{
			_name = name;
			_mediator = mediator;
			mediator.RegisterParticipant(this);
		}

		public void PerformAction(string action)
		{
			Console.WriteLine($"{_name} performs action: {action}");
			_mediator.SendAction(this, action);
		}

		public void ReceiveAction(string action)
		{
			Console.WriteLine($"{_name} receives action: {action}");
		}
	}
}