using System;
using POO_Elevador.Classes;

namespace POO_Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = "0";
            Elevador elevador = new Elevador();

            elevador.Inicializar();

            do{
                Console.WriteLine(elevador.InfoAtual());
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("[1] - Entrar (Uma pessoa entra no elevador");
                Console.WriteLine("[2] - Sair (Uma pessoa sai do elevador)");
                Console.WriteLine("[3] - Subir (Sobe um andar)");
                Console.WriteLine("[4] - Descer (Desce um andar)");
                Console.WriteLine("[5] - Encerrar");
                escolha = Console.ReadLine();
                Console.Clear();

                switch (escolha)
                {
                    case "1":
                        if(elevador.CapAtual == elevador.MaxCapacidade)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Capacidade máxima alcançada, não é possivel adicionar mais uma pessoa");
                            Console.ResetColor();
                        }else{
                            elevador.Entrar();
                        }
                        break;
                    case "2":
                        if (elevador.CapAtual == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Não tem ninguem para sair do elevado!");
                            Console.ResetColor();
                        } else
                        {
                            elevador.Sair();
                        }
                        break;
                    case "3":
                        if (elevador.AndarAtual == elevador.TotalDeAndares)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O elevador já se encontra no ultimo andar");
                            Console.ResetColor();
                        } else
                        {
                            elevador.Subir();
                        }
                        break;
                    case "4":
                        if (elevador.AndarAtual == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O elevador já se encontra no térreo");
                            Console.ResetColor();
                        } else
                        {
                            elevador.Descer();
                        }
                        break;
                    case "5":
                        break;
                    default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Escolha inválida");
                            Console.ResetColor();
                        break;
                }
                
            }while(escolha != "5");


        }
    }
}
