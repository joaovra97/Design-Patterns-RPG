namespace Composite.PartyMembers
{
	// Folha: Orc
	public class Orc : IPartyMember
	{
		private readonly string _name;

		public Orc(string name)
		{
			_name = name;
		}

		public void Display()
		{
			Console.WriteLine($"Orc named {_name}");
		}
	}
}