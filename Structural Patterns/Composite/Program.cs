using Composite.PartyMembers;

namespace Composite;

public class Program
{
	public static void Main()
	{
		// Criando personagens individuais
		IPartyMember elf1 = new Elf("Laeroth");
		IPartyMember orc1 = new Orc("Garothmuk");

		// Criando um grupo e adicionando personagens
		var party1 = new Party();
		party1.AddMember(elf1);
		party1.AddMember(orc1);

		// Criando outro personagem individual
		IPartyMember elf2 = new Elf("Zylgella");
		IPartyMember orc2 = new Orc("Zodagh");

		// Criando outro grupo e adicionando personagens
		var party2 = new Party();
		party2.AddMember(elf2);
		party2.AddMember(orc2);
		party2.AddMember(party1); // Adicionando um grupo como membro

		// Exibindo membros do grupo (que podem ser personagens individuais ou outros grupos)
		Console.WriteLine("Displaying Party Members:");
		party2.Display();
	}
}