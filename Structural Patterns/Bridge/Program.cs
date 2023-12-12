using Bridge.Characters;
using Bridge.Weapons;

namespace Bridge;

public class Program
{
	public static void Main()
	{
		// Criando personagens com diferentes armas
		IWeapon sword = new Sword();
		IWeapon bow = new Bow();

		Character elfCharacter = new Elf(bow);
		Character orcCharacter = new Orc(sword);

		// Exibindo informações do personagem e realizando ataques
		Console.WriteLine("Elf character:");
		elfCharacter.Display();
		elfCharacter.PerformAttack();

		Console.WriteLine();

		Console.WriteLine("Orc character:");
		orcCharacter.Display();
		orcCharacter.PerformAttack();
	}
}