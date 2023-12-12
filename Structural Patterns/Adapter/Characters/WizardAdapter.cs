namespace Adapter.Characters;

// Adaptador: WizardAdapter
public class WizardAdapter : ICharacter
{
	private readonly Wizard _wizard;

	// Construtor que recebe uma instância de Wizard para adaptar
	public WizardAdapter(Wizard wizard)
	{
		_wizard = wizard;
	}

	// Implementação da interface ICharacter usando a classe Wizard existente
	public void Attack()
	{
		_wizard.CastSpell();
	}
}