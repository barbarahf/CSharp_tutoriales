using System;

namespace Tanque
{
    public class Cañon : IArmas

    {
        public void Disparar(string objetivo)
        {
            Console.WriteLine("Disparo de {0}, cañon ", objetivo);
        }
    }
}