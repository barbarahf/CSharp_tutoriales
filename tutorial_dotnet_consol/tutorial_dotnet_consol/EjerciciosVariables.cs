using System;

namespace tutorial_dotnet_consol
{
    class Ejercicios
    {
        static void main(string[] args)
        {
            //Basics
            Console.WriteLine("Hello World!");
            /*Console.ReadLine();*/

            string name = "Mike";
            char testGrade = 'A';

            //Variables
            float gpa = 2.5F;
            double pda1 = 3.5;
            decimal gpa2 = 4.5M; //Precise decimal 128 bits
            Console.WriteLine(gpa2);
            bool isTall;
            isTall = true;
            name = "Tomas";
            Console.WriteLine($"Your name is {name}");
            int conversion = Convert.ToChar("a");
            Console.WriteLine(conversion);
            //Ejemplos
            string cadena = "¿Qué es lo que dice?\rÉl dice \"hola\"";
            /*cadena = @"¿Qué es lo que \r //dice?";*/
            cadena = @"¿Qué es lo que \r //dice?";
            //EL @ no se lee como codigo, es como <pre> de html, texto plano.

            Console.WriteLine(cadena);
            //Object type
            object obj;
            obj = 100; // this is boxing
            Console.WriteLine(obj);

            int i = 123;
            // The following line boxes i.
            object o = i;
            //Unboxing
            i = (int) o; // unboxing

            int? CodigoPostal;
            float? SueldoBase;
            /*CodigoPostal = 46022;*/
            CodigoPostal = null;
            if (CodigoPostal.HasValue)
            {
                Console.WriteLine(CodigoPostal.Value);
            }
            else
            {
                Console.WriteLine("Código Postal vacío");
            }

//podemos volver a asignar el valor nulo
            CodigoPostal = null;
            const int numberConst = 100;

            const int ValorMax = 100;
            const string Mensaje = "Muy grande";

            if (101 > ValorMax)
                Console.WriteLine(Mensaje);
            Console.Write(Semi);
        }

        public const int Total = 100;
        public const int Semi = Total / 2;

        public static dynamic operacion(dynamic op1, dynamic op2)


        {
            return op1 + op2;
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        //Definir directamente la constante
        enum ErrorCode : ushort
        {
            None = 0,
            Unknown = 1,
            ConnectionLost = 100,
            OutlierReading = 200
        }
    }
}