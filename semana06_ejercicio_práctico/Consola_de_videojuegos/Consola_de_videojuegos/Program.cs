using System;

namespace Consola_de_videojuegos
{
    internal class Program
    {
        public static void Main(string[] args)
        {bool continuar = true;
            try
            {
                do
                {
                    Console.Write(menu());
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Banco.registrarTarjeta();
                            break;
                        case 2:
                            Banco.consultarTarjetas();
                            break;
                        case 3:
                            ConsolaJuegos.comprarJuego();
                            break;
                        case 4:
                            ConsolaJuegos.jugar();
                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opcion errónea!");
                            break;
                    }
                } while (continuar);

                Console.WriteLine("\nTenga un buen día!");
            }
            catch (SystemException)
            {
                Console.WriteLine("Debe introducir números en esa sección o formato incorrecto");
            }
            catch (CardNotFound e)
            {
                Console.WriteLine(e.Message);
            }
        }
    
        static string menu(){
            return "\nBienvenido:\n" +
                   "1) Registrar tarjeta (banco).\n" +
                   "2) Consultar tarjetas (banco).\n" +
                   "3) Comprar videojuego (consola).\n" +
                   "4) Jugar videojuego (consola).\n" +
                   "5) Salir.\n" +
                   "Opción elegida: ";
        }
        }
    }
