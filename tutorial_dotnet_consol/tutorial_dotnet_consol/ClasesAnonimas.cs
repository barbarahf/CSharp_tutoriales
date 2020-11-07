using System;
using static System.Math;

namespace tutorial_dotnet_consol
{
    public class ClasesAnonimas
    {
        static void Main(string[] args)
        {
            double raiz = Sqrt(9);
            double potencia = Pow(3, 4);
            Console.WriteLine(raiz + " " + potencia);
            //Clases anonimas
            var variableGenerica = new {Nombre = "Barbara", Edad = 19};
            Console.WriteLine(variableGenerica.Edad);
        }
    }
}