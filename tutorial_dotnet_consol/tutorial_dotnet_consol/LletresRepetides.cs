using System;
using System.Collections.Generic;
using System.Linq;

namespace tutorial_dotnet_consol
{
    public class LletresRepetides
    {
        public static bool Vocal(char c)
        {
            string vocals = "AEIOU";
            if (vocals.Contains(char.ToUpper(c)))
                return true;
            return false;
        }

        //Metodo para almacenar desde una lista en un diccionario
        public static void Vegades(List<char> l, Dictionary<char, int> savLletres)
        {
            int count = 0;

            foreach (char s in l)
            {
                if (!savLletres.ContainsKey(s))
                {
                    foreach (var numChar in l)
                    {
                        if (s == numChar) count++;
                    }

                    savLletres.Add(s, count);
                    count = 0;
                }
            }
        }

        static void Main02(string[] args)
        {
            //Fase 1
            char[] nombre = {'B', 'A', 'R', 'B', 'A', 'R', 'A'};
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }

            //Fase 2
            List<char> nomList = Enumerable.OfType<char>(nombre).ToList();
            foreach (var i in nomList)
            {
                if (char.IsDigit(i))
                {
                    Console.WriteLine(i + " Los nombres de personas no contienen numeros.");
                }
                else if (!Vocal(i))
                {
                    Console.WriteLine(i + " Es una consonante");
                }
                else if (Vocal(i))
                {
                    Console.WriteLine(i + " Es una vocal");
                }
            }


            //Fase 3
            Dictionary<char, int> lletresRep =
                new Dictionary<char, int>();
            Vegades(nomList, lletresRep);
            //Print 
            foreach (KeyValuePair<char, int> i in lletresRep)
            {
                Console.WriteLine("Letra = {0}, Aparece = {1} veces", i.Key, i.Value);
            }

            //Fase 4
            List<char> cognom = new List<char>()
            {
                'H',
                'E',
                'R',
                'R',
                'E',
                'R',
                'A'
            };
            nomList.AddRange(" ");
            nomList.AddRange(cognom);
            foreach (var VARIABLE in nomList)
            {
                Console.Write(VARIABLE);
            }
        }
    }
}