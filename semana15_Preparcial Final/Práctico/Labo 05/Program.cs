using System;

namespace Labo_05
{
    internal class Program
    {
        public static void Main()
        {
            bool continuar = true;
            CProxy.ISujeto miejercicio = new CProxy.ProxySencillo();

            do{
                Console.Write(menu());
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca cuantos términos de fibonacci quiere que salgan: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        miejercicio.Pejercicio01(n);
                        break;
                    case 2:
                        Console.Write("Introduzca una palabra: ");
                        String palabrita = Console.ReadLine();
                        palabrita=palabrita.ToLower();
                        miejercicio.Pejercicio02(palabrita);
                        break;
                    case 3:
                        Console.WriteLine("Digite hasta que número se repetirá: ");
                        int q = Convert.ToInt32(Console.ReadLine());
                        bool f=true;
                        miejercicio.Pejercicio03(1,q,f);
                        break;
                    case 4:
                        Console.Write("Introduzca una palabra: ");
                        String palabra = Console.ReadLine();
                        miejercicio.Pejercicio04(palabra);
                        break;
                    case 5:
                        Console.WriteLine("Digite cuantas letras va a introducir");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        miejercicio.Pejercicio05(n1);
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion errónea!");
                        break;
                }
            } while (continuar);
        }
        
        static string menu(){
            return "\nBienvenido:\n" +
                   "1) Ejercicio 1.\n" +
                   "2) Ejercicio 2.\n" +
                   "3) Ejercicio 3.\n" +
                   "4) Ejercicio 4.\n" +
                   "5) Ejercicio 5.\n" +
                   "0) Salir.\n" +
                   "Opción elegida: ";
        }
    
    }
}