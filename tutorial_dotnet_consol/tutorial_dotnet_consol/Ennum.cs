using System;

namespace tutorial_dotnet_consol
//Enum__> namespace __> SOn creados para ser utilizados por multiples clases
{
    public class Ennum
    {
        //Enum
        //Sirven para representar y manejar valores fijos
        static void Main01(string[] args)
        {
            //Valores negativos
            // Estaciones? alergia = null;
            /*Estaciones alergia = Estaciones.Primavera;
            string La_Alergia = alergia.ToString();
            Console.Write(La_Alergia);*/

            Bonus Antonio = Bonus.bueno;
            Console.WriteLine(Antonio);
            //Casting
            double bonusAntonio = (double) Antonio;
            Console.WriteLine(bonusAntonio);

            Empleado Juan = new Empleado(Bonus.extra, 1900.50);
            Console.WriteLine("El salario es: " + Juan.getSalario());
        }
    }

    /*enum Estaciones //Todas las constantes estan enumeradas
    {
        Primavera,
        Verano,
        Otoño,
        Invierno
    };*/

    enum Bonus
    {
        bajo = 500,
        normal = 1000, //501 Por default
        bueno = 1500, //502
        extra = 300 //503
    };

    class Empleado
    {
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double) bonusEmpleado;
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario + bonus;
        }

        private double salario, bonus;
    }
}