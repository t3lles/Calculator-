
using System;
using System.Numerics;

namespace Calculator
{

    class Program
    {
        static void Main(string [] args)
        {
            Menu();
        }

        static void Menu(){

            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtracao");
            Console.WriteLine("3- Divisao");
            Console.WriteLine("4- Multiplicacao");
            Console.WriteLine("5- Raiz Quadrada");
            Console.WriteLine("6- Seno");
            Console.WriteLine("7- Cosseno");
            Console.WriteLine("8- Tangente");
            Console.WriteLine("9- Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch(res){
               case 1: Soma(); break;
               case 2: Subtracao(); break;
               case 3: Divisao(); break;
               case 4: Multiplicacao(); break;
               case 5: RaizQuadrada(); break;
               case 6: Seno(); break;
               case 7: Cosseno(); break;
               case 8: Tangente(); break;
               case 9: System.Environment.Exit(0); break;
               default: Menu(); break;
            }

        }


        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = int.Parse(Console.ReadLine());
            
            float soma = v1+v2;
            Console.WriteLine("O resultado da soma é igual a " + soma);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float subtracao = v1-v2;
            Console.WriteLine("O resultado da subtração é igual a " + subtracao);
            Console.ReadKey();
            Menu();

        }
    
        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());



            float divisao = v1 / v2;
            Console.WriteLine("O resultado da divisao é igual a " + divisao);
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());


            float multiplicacao = v1*v2;
            Console.WriteLine("O resultado da multiplicação é igual a " + multiplicacao);
            Console.ReadKey();
            Menu();
            }
        

        static void RaizQuadrada(){
            Console.Clear();
            Console.WriteLine("Digite o número que deseja saber a raiz:");
            double v1 = double.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(v1);

            Console.WriteLine("A raiz quadrada de " + v1 + " é igual a " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Seno(){
            Console.Clear();
            Console.WriteLine("Digite o número que deseja descorir o seno:");
            double v1 = double.Parse(Console.ReadLine());

            double radianos = v1 * (Math.PI/180);
            double resultado = Math.Sin(radianos);

            Console.WriteLine("O seno de " + v1 + " é igual a " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Cosseno(){
            Console.Clear();
            Console.WriteLine("Digite o número que você deseja descobrir o cosseno:");
            double v1 = double.Parse(Console.ReadLine());

            double radianos = v1 * (Math.PI / 180);
            double resultado = Math.Cos(radianos);

            Console.WriteLine("O cosseno de " + v1 + " é igual a " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Tangente(){
            Console.Clear();

            Console.WriteLine("Digite o número que deseja saber a tangente:");
            double v1 = double.Parse(Console.ReadLine());

            double radianos = v1* (Math.PI/180);
            double resultado = Math.Tan(radianos);
            Console.WriteLine("A tangente de " + v1+ " é igual a " + resultado);
            Console.ReadKey();
            Menu();
        }
    }

}

