using Flyweight.Characters;

namespace Flyweight
{
    // Fábrica Flyweight: RpgCharacterFactory
    public class CharacterFactory
	{
		private readonly Dictionary<string, ICharacter> characterPool = new();

		// Obter ou criar um personagem flyweight com base no estado intrínseco
		public ICharacter GetCharacter(string intrinsicState)
		{
			if (!characterPool.TryGetValue(intrinsicState, out ICharacter character))
			{
				// Se o personagem com o estado intrínseco fornecido não existir, criar um novo
				character = new Character(intrinsicState);
				characterPool.Add(intrinsicState, character);
			}

			return character; 
		}
	}
}