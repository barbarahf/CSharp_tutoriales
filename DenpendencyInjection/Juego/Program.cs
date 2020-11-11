using System;

namespace GunInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado personaje01 = new Soldado();
            IArmas arma01 = new Fusil();
            IArmas arma02 = new Ganada();
            personaje01.ArmaDefault = arma02;
            personaje01.ArmaDefault = arma01;
            personaje01.Disparar("Objetivo");
        }
    }
}