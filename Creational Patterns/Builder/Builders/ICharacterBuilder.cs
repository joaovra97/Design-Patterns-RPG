namespace Builder.Builders
{
	// Builder Abstrato: CharacterBuilder
	public interface ICharacterBuilder
	{
		void BuildRace();
		void BuildWeapon();
		void BuildArmor();
		Character GetCharacter();
	}
}