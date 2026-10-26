namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExibirMenu();
                int opcao = entrarOpcao();

                Action<string> mensagem;

                switch (opcao)
                {
                    case 1:
                        mensagem = mensagemPortugues;
                        break;

                    case 2:
                        mensagem = englishMessage;
                        break;

                    case 3:
                        mensagem = espanolMensaje;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        return;
                }

                mensagem("Bem-vindo aos nossos serviços!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public static void ExibirMenu()
        {
            Console.WriteLine("Idiomas disponíveis:");
            Console.WriteLine("(1) - Português");
            Console.WriteLine("(2) - Inglês");
            Console.WriteLine("(3) - Espanhol");
        }

        public static int entrarOpcao()
        {
            Console.WriteLine("Selecione a opção de idioma desejada:");
            return int.Parse(Console.ReadLine());
        }

        public static void englishMessage(string mensagem)
        {
            Console.WriteLine("Welcome to our services!");
        }

        public static void espanolMensaje(string mensagem)
        {
            Console.WriteLine("¡Bienvenido a nuestros servicios!");
        }

        public static void mensagemPortugues(string mensagem)
        {
            Console.WriteLine("Bem-vindo aos nossos serviços!");
        }
    }
}
