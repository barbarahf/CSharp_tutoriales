using System;

namespace Tanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanque tanque01 = new Tanque();
            IArmas arma01 = new Cañon();
            IArmas arma02 = new Ametralladora();
            tanque01.ArmaDefault = arma02;
            tanque01.ArmaDefault = arma01;
            tanque01.Disparar("Objetivo");
        }
    }
}