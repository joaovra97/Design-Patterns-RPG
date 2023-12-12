namespace Composite.PartyMembers;

// Composto: Party
public class Party : IPartyMember
{
	private readonly List<IPartyMember> members;

	public Party()
	{
		members = new List<IPartyMember>();
	}

	// Adiciona um membro ao grupo (seja um indivíduo ou outro grupo)
	public void AddMember(IPartyMember member)
	{
		members.Add(member);
	}

	// Remove um membro do grupo
	public void RemoveMember(IPartyMember member)
	{
		members.Remove(member);
	}

	// Retorna os membros do grupo
	public List<IPartyMember> GetMembers()
	{
		return members;
	}

	public void Display()
	{
		Console.WriteLine("Party Members:");

		foreach (var member in members)
		{
			if (member is not Party)
				member.Display();
			else
			{
				var innerParty = member as Party;
				innerParty.GetMembers().ForEach(x => x.Display());
			}
		}

		Console.WriteLine("End of Party Members");
	}
}