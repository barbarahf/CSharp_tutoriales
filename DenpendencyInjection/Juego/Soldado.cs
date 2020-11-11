using System;
using System.Collections.Generic;

namespace GunInjection
{
    public class Soldado
    {
        private IArmas armaDefault;

        public Soldado() 
        {
            armaDefault = new Ametralladora();
        }

        public IArmas ArmaDefault
        {
            get => armaDefault;
            set => armaDefault = value;
        }

        public void Disparar(string objetivo)
        {
            ArmaDefault.Disparar(objetivo);
        }
    }
}