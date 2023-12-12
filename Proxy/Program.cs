using Proxy.Characters;

namespace Proxy
{
    public class Program
	{
		public static void Main()
		{
			// Utilizando o proxy para controlar o acesso ao personagem real
			ICharacter proxyCharacter = new CharacterProxy("Aragorn");

			// Exibindo o personagem (carregando dados apenas quando necessário)
			Console.WriteLine("Calling Display() for the first time:");
			proxyCharacter.Display();

			// Exibindo o personagem novamente (os dados já foram carregados)
			Console.WriteLine("Calling Display() for the second time:");
			proxyCharacter.Display();
		}
	}
}