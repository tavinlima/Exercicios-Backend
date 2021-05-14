using System;

namespace SistemaProdutos
{
    class Program
    {
        static int tamanhoArray = 2;
        static bool Menu = true;
        static string[] Nome = new string[tamanhoArray];
        static float[] Preco = new float[tamanhoArray];
        static bool[] Promocao = new bool[tamanhoArray];
        static string TemPromocao;
        static string NovoProduto = Console.ReadLine();
        static int c = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Olá! Bem vindo ao 'Mercadinho da Rua'" + "\n");
            Console.ResetColor();

            do
            {
            MostrarMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    NovoProduto = "S";
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "3":
                Console.ForegroundColor = ConsoleColor.Green;;
                Console.WriteLine("Já vai? :( Até a próxima! Obrigado por usar nosso sistema.");
                Console.ResetColor();
                Menu = false;
                    break;
                case "4":
                AumentarLista();
                    break;
                default:
                Console.WriteLine("Por favor, insira uma alternativa válida.");
                    break;
            }
            } while (Menu);


        }

        static void MostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            |==============================================|
            |---------------------MENU---------------------|
            |==============================================|
            |           1 - Cadastrar Produtos             |
            |                                              |
            |           2 - Listar Produtos                |
            |                                              |
            |           3 - Sair                           |
            |                                              |
            |           4 - Aumentar Tamanho da Lista      |
            |==============================================|
            ");
            Console.ResetColor();
        }

        static void CadastrarProduto()
        {
            do
            {
                if (c < tamanhoArray)
                {
                Console.WriteLine("Insira o nome do produto: ");
                Nome[c] = Console.ReadLine();

                Console.WriteLine("Insira o preço do produto: ");
                Preco[c] = float.Parse(Console.ReadLine());

                Console.WriteLine("O produto está em promoção? S/N");
                TemPromocao = Console.ReadLine().ToUpper().Substring(0, 1);

                if (TemPromocao == "S")
                {
                    Promocao[c] = true;
                }
                else{
                    Promocao[c] = false;
                }
                c++;

                Console.WriteLine("Deseja cadastrar outro produto? S/N (Máximo de 10 produtos)");
                NovoProduto = Console.ReadLine().ToUpper().Substring(0, 1);
                }
                
                if (c == tamanhoArray)
                {
                Console.WriteLine("Você atingiu o máximo de cadastro de produtos.");
                NovoProduto = "N";
                }

            } while (NovoProduto == "S");
        }
        static void ListarProdutos(){
            for (var i = 0; i < c; i++)
            {
            Console.WriteLine($@"
            ---------------------------------------------
                           Lista de Produtos
            ---------------------------------------------
            Nome do produto:                {Nome[i]}

            Preço do produto:               R$: {Preco[i] .ToString("N2")}

            O produto está em promoção?     {(Promocao[i] ? "Sim" : "Não")}
            ---------------------------------------------
            ");
            }
        }
        static void AumentarLista(){
                    Console.WriteLine("Deseja aumentar o limite para quanto? ");
                    int AumentoLimite = int.Parse(Console.ReadLine());
                    tamanhoArray = tamanhoArray + AumentoLimite;

                    Array.Resize(ref Nome, Nome.Length + AumentoLimite);
                    Array.Resize(ref Preco, Preco.Length + AumentoLimite);
                    Array.Resize(ref Promocao, Promocao.Length + AumentoLimite);

        }
    }
}
