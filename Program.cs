using projeto_final_bloco_01.Model;

namespace projeto_final_bloco_01
{
    internal class Program
    {
        public static void Menu()
        {
            int opcao = 1, tipo, id;
            string n, nome, tamanho;
            decimal preco;

            ProdutoController produto = new();

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
                

                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException)
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Digite o Id do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o nome do produto: ");
                        nome = Console.ReadLine()!;

                        do
                        {
                            Console.WriteLine("Digite o tipo do produto: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1);

                        Console.WriteLine("Digite o preço do produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Insira o tamanho da sua pelucia: ");
                                tamanho = Console.ReadLine()!;
                                produto!.CriarProduto(new Brinquedo(produto.ContadorProduto(), nome, tipo, preco, tamanho));
                                break;
                        }

                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Listar todos os produtos: ");
                        produto!.ListarTodosProdutos();

                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Digite o Id do produto para consultá-lo: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto!.ConsultarPorId(id);

                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Digite o número do ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto!.BuscarNaCollection(id);

                        if (produto is not null)
                        {
                            Console.WriteLine("Digite o nome do produto: ");
                            nome = Console.ReadLine()!;

                            Console.WriteLine("Digite o preço do produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            do
                            {
                                Console.WriteLine("Digite o tipo do produto: ");
                                tipo = Convert.ToInt32(Console.ReadLine());
                            } while (tipo != 1);


                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Insira o tamanho da sua pelucia: ");
                                    tamanho = Console.ReadLine()!;

                                    produto.AtualizarProduto(new Brinquedo (id, nome, tipo, preco, tamanho));
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado");
                        }

                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("Digite o Id do produto que deseja deletar: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto!.DeletarProduto(id);

                        Console.ResetColor();
                        Console.ReadKey();
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