using System;

namespace Consola_de_videojuegos
{
    public class CardNotFound : Exception
    {
        public CardNotFound(String message) : base(message)
        {
            
        }
    }
}