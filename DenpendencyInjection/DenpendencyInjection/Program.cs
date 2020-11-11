﻿using System;

namespace DenpendencyInjection
{//Inyector de dependencias
    class Program
    {
        static void Main(string[] args)
        {
            IAlimento alimento =new Hamburguesa("Lechuga");
            var persona = new Persona(alimento);
            persona.Comer();
        }
    }
}