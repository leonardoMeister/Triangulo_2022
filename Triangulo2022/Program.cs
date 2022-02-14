using System;

namespace Triangulo2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem Vindo ao Sistema TRI!\nPress Enter to continue...\n");
            Console.ReadKey();
            while (true)
            {
                double ladoX = 0, ladoY = 0, ladoZ = 0;

                Console.WriteLine("Informe o Primeiro Lado:");
                ladoX = Convert.ToDouble(Console.ReadLine());
                if (!Validar(ladoX)) continue;
                Console.WriteLine("Informe o Primeiro Lado:");
                ladoY = Convert.ToDouble(Console.ReadLine());
                if (!Validar(ladoY)) continue;
                Console.WriteLine("Informe o Primeiro Lado:");
                ladoZ = Convert.ToDouble(Console.ReadLine());
                if (!Validar(ladoZ)) continue;

                string msgValidacao = "";
                string tipoTriangulo = "";


                if (!((ladoX - ladoZ) < ladoY && ladoY < (ladoX + ladoZ))) msgValidacao = "Regra Existencia Invalida";
                else if (!((ladoY - ladoZ) < ladoX && ladoX < (ladoY + ladoZ))) msgValidacao = "Regra Existencia Invalida";
                else if (!((ladoY - ladoX) < ladoZ && ladoZ < (ladoY + ladoX))) msgValidacao = "Regra Existencia Invalida";

                if (msgValidacao =="")
                {
                    if (ladoZ != ladoY && ladoZ != ladoX && ladoX != ladoY)
                    {
                        tipoTriangulo = "Triângulo Escaleno";
                    }
                    else if (ladoZ == ladoY && ladoZ == ladoX && ladoY == ladoX)
                    {
                        tipoTriangulo = "Triângulo Equilátero";
                    }
                    else if ((ladoX == ladoY) || (ladoX == ladoZ) || (ladoZ == ladoY))
                    {
                        tipoTriangulo = "Triângulo Isósceles";
                    }
                    else
                    {
                        tipoTriangulo = "Triangulo Indefinido ou Inválido";
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{msgValidacao}, favor tentar novamente...\nPress enter to continue...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\nX: {ladoX}, Y: {ladoY}, Z: {ladoZ}, é um {tipoTriangulo}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPara executar a operação novamente informe a letra (s) de Sim.");

                if (Console.ReadLine().ToLower() != "s") break;
            }
        }
        public static bool Validar(double x)
        {
            if (x <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor Inválido tente novamente!\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                return false;
            }
            return true;
        }
    }
}
