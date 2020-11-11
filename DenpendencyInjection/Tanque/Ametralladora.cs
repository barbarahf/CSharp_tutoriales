using System;

namespace Tanque
{
    public class Ametralladora : IArmas
    {
        public void Disparar(string objetivo)
        {
            Console.WriteLine("Disparo a {0}, ametralladora", objetivo);
        }
    }
}