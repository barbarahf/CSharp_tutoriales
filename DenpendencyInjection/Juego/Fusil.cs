using System;

namespace GunInjection
{
    public class Fusil : IArmas
    {
        public void Disparar(string objetivo)
        {
            Console.WriteLine("Disparo a {0}, fusil", objetivo);
        }
    }
}