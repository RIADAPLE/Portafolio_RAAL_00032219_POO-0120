using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Labo_05
{
    public class CProxy
    {

        public interface ISujeto
        {
            void Pejercicio01(int n);
            void Pejercicio02(string palabrita);
            void Pejercicio03(int x, int n, bool f);
            void Pejercicio04(string b);
            void Pejercicio05(int n1);
        }

        public class ProxySencillo : ISujeto
        {
            private Labo05 CLabo;

            public void Pejercicio01(int n)
            {
                if (CLabo == null)
                {
                    CLabo = new Labo05();
                }

                CLabo.ejercicio01(n);
            }

            public void Pejercicio02(string palabrita)
            {
                CLabo.ejercicio02(palabrita);
            }

            public void Pejercicio03(int x, int n, bool f)
            {
                CLabo.ejercicio03(x, n, f);
            }

            public void Pejercicio04(string b)
            {
                CLabo.ejercicio04(b);
            }

            public void Pejercicio05(int n1)
            {
                CLabo.ejercicio05(n1);
            }

            private class Labo05
            {
                public void ejercicio01(int n)
                {
                    int x = 1;
                    int y = 0;
                    int total = 0;

                    for (int i = 0; i < n; i++)
                    {
                        if (i == 2)
                        {
                            Console.WriteLine("1");
                        }
                        else
                        {
                            Console.WriteLine(total);
                            total = x + y;
                            y = x;
                            x = total;
                        }
                    }
                }

                public void ejercicio02(string palabrita)
                {
                    bool palindrome = true;
                    int n = palabrita.Length;

                    for (int i = 0; i < n; i++)
                    {
                        if (palabrita[i] == palabrita[n - i - 1])
                        {
                        }
                        else
                        {
                            palindrome = false;
                            break;
                        }
                        Console.WriteLine(palindrome);
                    }

                    if (palindrome)
                        Console.WriteLine("Es palíndrome!");
                    else
                        Console.WriteLine("No es palíndrome!");
                }

                public void ejercicio03(int x, int n, bool f)
                {
                    if (f == true && x == n)
                    {
                        Console.WriteLine(n);
                        f = false;
                        ejercicio03(x,n,f);
                    }
                    else if (f == true)
                    {
                        Console.WriteLine(x);
                        x++;
                        ejercicio03(x,n,f);
                    }
                    else if (f == false)
                    {
                        if (x == 1)
                        {
                            return;
                        }
                        else
                        {
                            x--;
                            Console.WriteLine(x);
                            ejercicio03(x, n, f);
                        }
                    }
                    else
                        return;
                }
                
                public void ejercicio04(string b)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i].Equals('a'))
                        {
                            Console.Write("b");
                        }
                        else
                        {
                            Console.Write(b[i]);
                        }
                    }
                }

                public void ejercicio05(int n1)
                {
                    List<char> lista = new List<char>();
                    char c;
                    for (int i = 0; i < n1; i++)
                    {Console.WriteLine("Letra "+(i+1)+": ");
                        c = Convert.ToChar(Console.ReadLine());
                        if(c=='a' || c=='e' || c=='i' || c=='o' || c=='u' || c=='A' || c=='E' || c=='I' || c=='O' || c=='U'){
                            lista.Add(c);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Las vocales que se ingresaron fueron las siguientes:");
                    foreach (char caracter in lista)
                    {
                        Console.WriteLine(caracter);
                    }
                }
            }
        }
    }
}