namespace Tanque
{
    using System;
    using System.Collections.Generic;


    public class Tanque
    {
        private IArmas armaDefault;

        public Tanque()
        {
            armaDefault = new Cañon();
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