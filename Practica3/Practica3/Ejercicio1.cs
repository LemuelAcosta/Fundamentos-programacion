using System;
using System.Runtime.InteropServices.ComTypes;

namespace Practica3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            /*
             * Lemuel Acosta 
             * 2019-8920
            */

            Console.WriteLine("Ejercicio 1");
            int num = 0;
            Console.WriteLine("Digite un numero: ");
            num =Convert.ToInt32(Console.ReadLine());

            if ((num % 2) == 0)
            {
                Console.WriteLine("Es par.");
            }
            else
            {
                Console.WriteLine("No es par.");
            }  

                //Ejercicio 2
                Console.WriteLine("******************EJERCICIO 2********************");
                int num1;
                int num2;

                Console.WriteLine("Digite un primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite un segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }
            if (num1 == num2)
            {
                Console.WriteLine("{0} es igual a {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }

            //EJERCICIO 3
            Console.WriteLine("******************EJERCICIO 3********************");
            
            int num3;
            int num4;

            Console.WriteLine("Digite un primer numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite un segundo numero");
            num4 = Convert.ToInt32(Console.ReadLine());
            
            if (num3 % num4 == 0)
            {
                Console.WriteLine("{0} es multiplo de {1}", num3, num4);
            }
            else 
            {
                Console.WriteLine("{0} no es multiplo de {1}", num3, num4);
            }

            //EJERCICIO 4
            Console.WriteLine("******************EJERCICIO 4********************");

            int x;
            Console.WriteLine("Digite un numero para saber si es multiplo de 10");
            x = Convert.ToInt32(Console.ReadLine());

            while (x % 10 == 0) 
            {
                Console.WriteLine("Digite un numero para saber si es multiplo de 10");
                x = Convert.ToInt32(Console.ReadLine());

            }
            if (x % 10 != 0)
            {
                Console.WriteLine("{0} no es multiplo de 10", x);
            }

                //EJERCICIO 5
                Console.WriteLine("******************EJERCICIO 5********************");

                int a;
                int b;
                Console.WriteLine("Digite un numero. ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("El producto de 0 es 0");
                }
                else
                {
                    Console.WriteLine("Digite un segundo numero: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El producto de estos numeros es: {0}", a * b);
                }

                //EJERCICIO 6
                Console.WriteLine("******************EJERCICIO 6********************");

                double y;
                double z;

                Console.WriteLine("Digite un numero");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite un segundo numero");
                z = Convert.ToDouble(Console.ReadLine());

                if (z != 0)
                {
                    Console.WriteLine("El resultado de dividirlo es " + y / z);
                }
                else
                {
                    Console.WriteLine("ERROR! No se puede dividir entre 0 ");
                }


                //EJERCICIO 7
                Console.WriteLine("******************EJERCICIO 7********************");

                int o;
                Console.WriteLine("Digite un numero para saber si es multiplo de 4 o de 5");
                o = Convert.ToInt32(Console.ReadLine());

                if (0 % 4 == 0 && o % 5 == 0)
                {
                    Console.WriteLine("{0} es multiplo de 5 y 4", o);
                }
                else
                {
                    if (o % 4 == 0)
                    {
                        Console.WriteLine("{0} es multiplo de 4", o);
                    }
                    else
                    {
                        if (o % 5 == 0)
                        {
                            Console.WriteLine("{0} es multiplo de 5", o);
                        }
                    }
                }

                //EJERCICIO 8
                Console.WriteLine("******************EJERCICIO 8********************");

            int a1;
            int a2;

            Console.WriteLine("Digite un primer numero");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un primer numero");
            a2 = Convert.ToInt32(Console.ReadLine());

            if (a1>0 && a2 > 0) 
            {
                Console.WriteLine("Los dos numeros son positivos");
            }
            else 
            {
                if (a1 > 0 || a2 > 0) 
                {
                    Console.WriteLine("Uno de los nuemros es positivo");
                }
                else 
                {
                    Console.WriteLine("Ninguno de los dos es positivo");
                }
            }



            //EJERCICIO 9
            Console.WriteLine("******************EJERCICIO 9********************");
                int n1;
                int n2;
                int n3;

                Console.WriteLine("Digite un numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite un numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite un numero: ");
                n3 = Convert.ToInt32(Console.ReadLine());

              if (n1 > n3 && n1 > n2) 
            {
                Console.WriteLine("El mayor es: " + n1);
            }
            else 
            {
                if (n2 > n3)
                {
                    Console.WriteLine("El mayor es: " + n2);
                }
                else 
                {
                    Console.WriteLine("El mayor es: " + n3);

                }

            }
        }
    } 
}
