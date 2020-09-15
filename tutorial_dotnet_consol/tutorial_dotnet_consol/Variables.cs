using System;

namespace tutorial_dotnet_consol
{
    public class Variables
    {
        public const int anyBisiesto = 1948;

        static void Main01(string[] args)
        {
            //Fase 1
            string nom = "Barbara";
            string cognom1 = "Herrera";
            string cognom2 = "Flores";

            int dia = 01;
            int mes = 04;
            int any = 2000;
            Console.WriteLine(cognom1 + " " + cognom2 + " " + nom);
            Console.WriteLine(dia + "/" + mes + "/" + any);

            //FASE 2  & 3
            int contador = 0;
            bool isBisiesto = false;
            for (int i = anyBisiesto; i <= any; i += 4)
            {
                Console.WriteLine(i);
                contador++;
                if (i == any)
                {
                    isBisiesto = true;
                }
            }

            Console.WriteLine($"Entre {anyBisiesto} y {any} hay {contador} años");
            string output = $"Mi nombre es {nom + " " + cognom1 + " " + cognom2}\n" +
                            $"Nací el {dia + "/" + mes + "/" + any}\n{(isBisiesto ? "Mi año de nacimiento es bisiesto" : "")}";
            Console.Write(output);
        }
    }
}