using System;

namespace Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];
            bool cadastro = false;
            bool passagemNova = false;
            string resposta;
            int g = 0;

            Console.WriteLine("Olá! Para entrar em nosso sistema. Insira sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            if (senha == 123456)
            {
                Console.WriteLine("\n Login concluído." + "\n");
                do
                {
                    Console.WriteLine($@"
                    |------------------------------------------|
                    |              Acesso ao menu              |
                    |------------------------------------------|
                    |------------------------------------------|
                    |   Selecione 1 para Cadastrar Passagem.   |
                    |   Selecione 2 para Listar Passagem.      |
                    |   Selecione 0 para Sair.                 |
                    |------------------------------------------|
                    ");
                    int menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("Nome do passageiro: ");
                                nome[g] = Console.ReadLine();
                                Console.WriteLine("Origem: ");
                                origem[g] = Console.ReadLine();
                                Console.WriteLine("Destino: ");
                                destino[g] = Console.ReadLine();
                                Console.WriteLine("Data de voo: ");
                                data[g] = Console.ReadLine();
                                g++;

                                Console.WriteLine("Deseja cadastrar uma nova passagem? S/N (máximo de 5 passagens)");
                                resposta = Console.ReadLine().ToUpper().Substring(0, 1);

                                if (g == nome.Length)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n Você atingiu o número máximo de passagens" + "\n");
                                    Console.ResetColor();
                                    passagemNova = true;
                                    cadastro = true;
                                }
                                else
                                {
                                     if (resposta == "S")
                                     {
                                         cadastro = false;
                                     }
                                     else
                                     {
                                         cadastro = true;
                                         passagemNova = true;
                                     }
                                }


                            } while (passagemNova == false);

                            break;
                        case 2:
                            for (var i = 0; i < g; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\n Dados da passagem:");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($@"
Nome do passageiro: {nome[i]}
Origem: {origem[i]}
Destino: {destino[i]}
Data de viagem: {data[i]}"
                + "\n");
                                Console.ResetColor();
                            }
                            break;
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Obrigado e volte sempre!");
                            Console.ResetColor();
                            cadastro = false;
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!!!");
                            cadastro = true;
                            break;
                    }
                } while (cadastro == true);
            }
            else
            {
                Console.WriteLine("Senha inválida!!!");
            }

        }
    }
}
