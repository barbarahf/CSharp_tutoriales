using System;

namespace poo
{
    class Circulo
    {
        private const double pi = 3.1416;

        public double CalcularArea(int radio) //Metodos de clase--> Comportamiento de los objetos
        {
            return pi * radio * radio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circulo cir1 = new Circulo(); //Instancia de una clase
            Circulo cir2 = new Circulo();
            Console.WriteLine(cir2.CalcularArea(9));
            Console.WriteLine(cir1.CalcularArea(5));
            //
            ConversorEuroDolar obj = new ConversorEuroDolar();
            Console.WriteLine(obj.convierte(50));
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.45;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
    }
}