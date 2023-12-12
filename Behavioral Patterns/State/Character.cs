using State.States;

namespace State;

// Contexto: Character
public class Character
{
	private ICharacterState currentState;
	public string Name { get; private set; }
	public int HP { get; private set; }

	public Character(string name)
	{
		Name = name;
		HP = 50;
		currentState = new NormalState(); // O estado inicial é normal
	}

	public void ChangeState(ICharacterState newState)
	{
		currentState = newState;
		currentState.HandleState(this);
	}

	// Exemplo de ações que podem acionar mudanças de estado
	public void TakeDamage(int damage)
	{
		HP -= damage;

		// Se a saúde estiver abaixo de um limite, mudar para o estado ferido
		if (HP > 0 && HP < 50)
		{
			ChangeState(new InjuredState());
		}
	}

	public void TakePoison()
	{
		HP -= 10;

		// Se envenenado, mudar para o estado envenenado
		if (HP > 0 && HP < 50)
		{
			ChangeState(new PoisonedState());
		}
	}

	public void FullHeal()
	{
		// Quando curado, retornar ao estado normal
		HP = 50;
		ChangeState(new NormalState());
	}
}