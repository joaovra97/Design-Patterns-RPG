using AbstractFactory.Armors;
using AbstractFactory.Characters;
using AbstractFactory.Factories;
using AbstractFactory.Weapons;

namespace AbstractFactory;

public class Program
{
	static void Main()
	{
		// Criando um personagem Elfo com equipamento de Elfo
		ICharacterFactory elfFactory = new ElfFactory();
		ICharacter elfCharacter = elfFactory.CreateCharacter();
		IWeapon elfWeapon = elfFactory.CreateWeapon();
		IArmor elfArmor = elfFactory.CreateArmor();

		Console.WriteLine("Elf character equipped:");
		elfCharacter.Display();
		elfWeapon.Attack();
		elfArmor.Defend();

		Console.WriteLine();

		// Criando um personagem Orc com equipamento de Orc
		ICharacterFactory orcFactory = new OrcFactory();
		ICharacter orcCharacter = orcFactory.CreateCharacter();
		IWeapon orcWeapon = orcFactory.CreateWeapon();
		IArmor orcArmor = orcFactory.CreateArmor();

		Console.WriteLine("Orc character equipped:");
		orcCharacter.Display();
		orcWeapon.Attack();
		orcArmor.Defend();
	}
}