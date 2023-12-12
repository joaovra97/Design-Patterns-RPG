namespace Builder.Builders
{
    // Builder Concreto: OrcBuilder
    public class OrcBuilder : ICharacterBuilder
    {
        private readonly Character orcCharacter = new();

        public void BuildRace()
        {
            orcCharacter.Race = "Orc";
        }

        public void BuildWeapon()
        {
            orcCharacter.Weapon = "Axe";
        }

        public void BuildArmor()
        {
            orcCharacter.Armor = "Heavy Plate Armor";
        }

        public Character GetCharacter()
        {
            return orcCharacter;
        }
    }
}