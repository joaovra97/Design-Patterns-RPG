using Builder.Builders;

namespace Builder
{
	// Diretor: CharacterDirector
	public class CharacterDirector
	{
		public void Construct(ICharacterBuilder builder)
		{
			builder.BuildRace();
			builder.BuildWeapon();
			builder.BuildArmor();
		}
	}
}