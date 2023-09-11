namespace projeto_final_bloco_01
{
    internal class Program
    {
        public static void Menu()
        {
            int opcao = 1;
            string n;

            while (opcao != 6)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Clear();
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                Console.WriteLine();
                Console.WriteLine("¨                   Bem Vindos à Toy&Joy                      ¨");
                Console.WriteLine();
                Console.WriteLine("¨                 1     Cadastrar Produto                     ¨");
                Console.WriteLine("¨                 2       Listar Produtos                     ¨");
                Console.WriteLine("¨                 3     Buscar Por Número                     ¨");
                Console.WriteLine("¨                 4     Atualizar Produto                     ¨");
                Console.WriteLine("¨                 5        Apagar Produto                     ¨");
                Console.WriteLine("¨                 6                  Sair                     ¨");
                Console.WriteLine();
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.ResetColor();

                switch (opcao)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Você deseja realmente sair ?");
                        Console.WriteLine("  [S]                [N]    ");
                        n = Console.ReadLine()!.ToUpper();

                        if (n == "N")
                            Menu();
                        else
                        {
                            Console.WriteLine("Obrigado por Visitar a Toy&Joy !!");
                        }

                        Console.ResetColor();
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Essa opcão Não Existe !");
                        Console.ResetColor();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}