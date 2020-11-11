using System;

namespace GunInjection
{
    public class Ganada : IArmas
    {
        public void Disparar(string objetivo)
        {
            Console.WriteLine("Laza granada a {0}", objetivo);
        }
    }
}