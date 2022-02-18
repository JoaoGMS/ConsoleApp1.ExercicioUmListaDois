using System;

namespace ConsoleApp1.ExercicioUmListaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício um // Lista dois  ");
            
            
                // Console.WriteLine("");

                double X, Y, Z;

                Console.WriteLine("Digite o valor de X: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y: ");
                Y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de Z: ");
                Z = Convert.ToDouble(Console.ReadLine());

                if (X + Y < Z) 
            
                Console.WriteLine("A soma de X e Y é menor que Z");


            
                else
                    Console.WriteLine("A soma de X e Y é maior que Z");

             

        }
    }
}
