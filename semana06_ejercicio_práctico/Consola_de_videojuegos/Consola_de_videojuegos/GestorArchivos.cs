﻿using System.IO;

namespace Consola_de_videojuegos
{
    public class GestorArchivos
    {
        public static string Leer(string pArchivo){
            return File.ReadAllText(pArchivo);
        }
    
        public static void Anexar(string pArchivo, string frase){
            using (StreamWriter stream = File.AppendText(pArchivo)) {
                stream.WriteLine(frase);
            }
        }
    
        public static bool Buscar(string pArchivo, string frase){
            bool encontrado = false;
        
            using(StreamReader archivo = new StreamReader(pArchivo)) {
                string linea = "";
                while(!encontrado && !archivo.EndOfStream){
                    linea = archivo.ReadLine();
                
                    if(linea.CompareTo(frase) == 0)
                        encontrado = true;
                }
            }

            if (encontrado = false)
            {
                throw new CardNotFound("Debe introducir una Tarjeta válida");
            }
            return encontrado;
        }
    }
}