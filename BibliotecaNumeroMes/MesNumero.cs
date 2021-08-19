using System;

namespace BibliotecaNumeroMes
{
    public class NumMes
    {
        public static void SortedListCollection()
        {
            Console.WriteLine("Ingrese un numero del 1 al 12");
            var numMes = Convert.ToInt32(Console.ReadLine());
            switch (numMes)
            {
                case 1:
                    Console.WriteLine("Enero es el mes 1");
                    break;
                case 2:
                    Console.WriteLine("Febrero es el mes 2");
                    break;
                case 3:
                    Console.WriteLine("Marzo es el mes 3");
                    break;
                case 4:
                    Console.WriteLine("Abril es el mes 4");
                    break;
                case 5:
                    Console.WriteLine("Mayo es el mes 5");
                    break;
                case 6:
                    Console.WriteLine("Junio es el mes 6");
                    break;
                case 7:
                    Console.WriteLine("Julio es el mes 7");
                    break;
                case 8:
                    Console.WriteLine("Agosto es el mes 8");
                    break;
                case 9:
                    Console.WriteLine("Septiembre es el mes 9");
                    break;
                case 10:
                    Console.WriteLine("Octubre es el mes 10");
                    break;
                case 11:
                    Console.WriteLine("Noviembre es el mes 11");
                    break;
                case 12:
                    Console.WriteLine("Diciembre es el mes 12");
                    break;
                default:
                    Console.WriteLine("Error numero no valido");
                    break;
            }
        }
    }
}
