using System;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POR FAVOR USA UNA CALCULADORA");
            int choice;
            Console.WriteLine("Escoja una opcion:");
            Console.WriteLine("1. Adivinare cualquier numero que pienses");
            Console.WriteLine("2. Adivinare tu fecha exacta de nacimiento");
            choice = Int32.Parse(Console.ReadLine());
            //decision
            switch (choice)
            {
                case 1:
                    int num1, resultado, num2;
                    Console.WriteLine("Piensa en numero cualquiera");
                    Console.WriteLine("Ahora multiplicalo por 2");
                    Console.WriteLine("ahora sumale 8 al resultado anterior");
                    Console.WriteLine("ahora al resultado anterior mulplicalo por 5");
                    Console.WriteLine("Ingresa el resultado final");
                    num1 = Int32.Parse(Console.ReadLine());
                    string numfm = num1 + "";
                    int numcaract = numfm.Length;
                    num2 = numfm[numcaract - 1];
                    resultado = num2 - 4;
                    Console.WriteLine("el numero que pensaste es: " + num2);
                    break;
                case 2:
                    int num3, num4, indicebuscar;
                    string mes, diac;
                    Console.WriteLine("Piensa en el numero del dia que naciste");
                    Console.WriteLine("Ahora multiplicalo por 20");
                    Console.WriteLine("ahora sumale 73 al resultado anterior");
                    Console.WriteLine("ahora al resultado anterior mulplicalo por 5");
                    Console.WriteLine("ahora al resultado anterior sumale el numero del mes que naciste");
                    Console.WriteLine("Ingresa el resultado final");
                    num3 = Int32.Parse(Console.ReadLine());
                    num4 = num3 - 365;
                    string fecha = num4 + "";
                    indicebuscar = fecha.LastIndexOf("");
                    diac = fecha.Substring(0, indicebuscar-1);
                    int tamano = fecha.Length;

                    mes = fecha.Substring(indicebuscar, tamano - indicebuscar);
                    Console.WriteLine($"El día={diac} ");
                    Console.WriteLine($"El mes={mes} ");
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
            Console.ReadKey();
        }
        }
}
