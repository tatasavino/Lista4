using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string cpf="", nome="", sobrenome="";
            double salario=0.0;

            List <Funcionario> funcionario = new List<Funcionario>();
            Program program = new Program();

            
            do 
            {
                program.GerarMenu();
                opcao = Convert.ToInt32(Console.ReadLine());
                switch  (opcao)
                {
                    case 1: 
                        program.AdicionarFuncionario(ref cpf, ref nome, ref sobrenome, ref salario);
                        Funcionario f1 = new Funcionario(cpf, nome, sobrenome, salario);
                        funcionario.Add(f1);
                        break;
                    case 2:
                        Console.WriteLine("Programa Encerrado.\n\n");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

            } while (opcao !=4);


            


        }

        public void GerarMenu() 
        {
            Console.Write($"\n\nOlá! Seja bem vindo(a). Escolha uma opção: \n\n\t1 - Adicionar funcionário;\t2 - Encerrar Programa;\n\nEscolha: ");
        }

        public void AdicionarFuncionario (ref string cpf, ref string nome, ref string sobrenome, ref double salario) 
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------\n\n");
            Console.Write("Cpf: ");
            cpf = Console.ReadLine();
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.Write("Salário: ");
            salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------------------------------------------------");
        }


    }
}