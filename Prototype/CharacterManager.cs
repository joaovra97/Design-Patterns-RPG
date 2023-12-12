using Prototype.Characters;

namespace Prototype
{
    // Cliente: CharacterManager
    public class CharacterManager
	{
		private readonly CharacterPrototype elfPrototype;
		private readonly CharacterPrototype orcPrototype;

		public CharacterManager()
		{
			// Inicializa os protótipos com propriedades padrão
			elfPrototype = new Elf("Elf Prototype");
			orcPrototype = new Orc("Orc Prototype");
		}

		public CharacterPrototype CreateElf()
		{
			// Cria um novo personagem Elfo clonando o protótipo de Elfo
			return elfPrototype.Clone();
		}

		public CharacterPrototype CreateOrc()
		{
			// Cria um novo personagem Orc clonando o protótipo de Orc
			return orcPrototype.Clone();
		}
	}
}