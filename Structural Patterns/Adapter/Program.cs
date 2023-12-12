using Adapter.Characters;

namespace Adapter;

public class Program
{
	public static void Main()
	{
		// Usando a classe Wizard que não implementa ICharacter
		var wizard = new Wizard();
		Console.WriteLine("Not Adapted Wizard:");
		wizard.CastSpell();

		Console.WriteLine();

		// Usando o WizardAdapter para tornar o Wizard compatível com a interface ICharacter
		ICharacter adaptedWizard = new WizardAdapter(wizard);
		Console.WriteLine("Adapted Wizard (via WizardAdapter):");
		adaptedWizard.Attack();
	}
}