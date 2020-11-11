using System;

namespace Tanque
{
    public class Cañon2 : IArmas

    {
        public void Disparar(string objetivo)
        {
            Console.WriteLine("Disparo de {0}, cañon2 ", objetivo);
        }
    }
}