using System;
using System.Text;
using System.Linq;
namespace Carac
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int con = 0; con < 2; con++)
            //{
            string value;

            Console.WriteLine("Introduce una letra");
            value = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);

            // int i = BitConverter.ToInt32(asciiBytes, 0);

            // string str = Encoding.UTF8.GetString(asciiBytes, 0, asciiBytes.Length);
            //str = Convert.ToInt32();
            if (asciiBytes[0] < 58 && asciiBytes[0] > 47)
            {
                Console.WriteLine("Es un numero");
            }
            else if ((asciiBytes[0] < 91 && asciiBytes[0] > 64) || (asciiBytes[0] < 123 && asciiBytes[0] > 96))
            {
                Console.WriteLine("Es una letra");
            }
            else if ((asciiBytes[0] < 48 && asciiBytes[0] > 31) || (asciiBytes[0] < 64 && asciiBytes[0] > 57) || (asciiBytes[0] < 97 && asciiBytes[0] > 90) || (asciiBytes[0] < 127 && asciiBytes[0] > 122))
            {
                Console.WriteLine("Es un signo de puntuacion.");
            }

            Console.WriteLine("////////////////");
            string palabra;
            string letra;
            Console.WriteLine("Introduce una palabra");
            palabra = Console.ReadLine();
            byte[] vs = Encoding.ASCII.GetBytes(palabra);

            Console.WriteLine("Introduce una letra");
            letra = Console.ReadLine();
            byte[] vs1 = Encoding.ASCII.GetBytes(letra);

            if (vs.Contains(vs1[0])) 
            {
                Console.WriteLine("La letra se encuentra en la palabra");
            }
            else { Console.WriteLine("No se encuentra la letra"); }  
                        
        }
    }
}
