using Decorator.Characters;
using Decorator.Characters.Decorators;

namespace Decorator
{
	public class Program
	{
		public static void Main()
		{
			// Criando um personagem Elfo básico
			ICharacter elf = new Elf("Laeroth");
			Console.WriteLine("Basic Elf:");
			elf.Display();

			Console.WriteLine();

			// Decorando o Elfo com uma arma e uma armadura
			ICharacter elfWithArmorAndWeapon = new ArmorDecorator(new WeaponDecorator(elf, "Bow"), "Leather");
			Console.WriteLine("Elf with Weapon and Armor:");
			elfWithArmorAndWeapon.Display();

			Console.WriteLine();

			// Criando um personagem Orc básico
			ICharacter orc = new Orc("Garothmuk");
			Console.WriteLine("Basic Orc:");
			orc.Display();

			Console.WriteLine();

			// Decorando o Orc com uma arma
			ICharacter orcWithWeapon = new WeaponDecorator(orc, "Axe");
			Console.WriteLine("Orc with Weapon:");
			orcWithWeapon.Display();
		}
	}
}