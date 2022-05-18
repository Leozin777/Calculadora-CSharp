using System;

namespace Calculator
{
    class Program
    {
        private static int op;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            do
            {
                Console.WriteLine("ESCOLHA UMA OPERAÇÃO");
                Console.WriteLine("1 - SOMA");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - DIVISÃO");
                Console.WriteLine("4 - MULTIPLICAÇÃO");
                Console.WriteLine("99 - ENCERRAR O PROGRAMA");
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Soma();
                        break;

                    case 2:
                        Subtracao();
                        break;

                    case 3:
                        Divisao();
                        break;

                    case 4:
                        Multiplicar();
                        break;

                    case 99:
                        Console.WriteLine("ENCERRANDO PROGRAMA."); 
                        break;

                    default:
                        Console.WriteLine("OPERAÇÃO INVÁLIDA, TENTE NOVAMENTE.");
                        break;    
                }
            } while (op != 99); 
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float res = v1 + v2;
            Console.WriteLine($"O resultado da soma dos valores é {res}");  
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float res = v1 - v2;
            Console.WriteLine($"O resultado da subtração dos valores é {res}");  
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float res = v1/v2;
            Console.WriteLine($"O resultado da divisão dos valores é {res}");
        }

        static void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");  
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float res = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação dos valores é {res}");  
        }
    }
}
