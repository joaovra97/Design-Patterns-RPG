using Bridge.Weapons;

namespace Bridge.Characters
{
	// Abstração: Character
	public abstract class Character
	{
		protected IWeapon _weapon;

		// Construtor que recebe uma instância de IWeapon
		protected Character(IWeapon weapon)
		{
			_weapon = weapon;
		}

		// Método abstrato para ações específicas do personagem
		public abstract void Display();

		// Ação comum usando a arma
		public void PerformAttack()
		{
			_weapon.Attack();
		}
	}
}