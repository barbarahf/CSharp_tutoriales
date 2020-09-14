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

        public static int vegades(List<char> l, char c)
        {
            int count = 0;
            foreach (var item in l)
            {
                if (item == c)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            //Fase 1
            char[] nombre = {'B', 'A', 'R', 'B', 'A', 'R', 'A'};
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }

            //Fase 2
            List<char> nomList = nombre.OfType<char>().ToList();
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
            Dictionary<string, string> lletresRep =
                new Dictionary<string, string>();

            /*foreach (var i in lletresRep)
            {
                    lletresRep.Add(vegades(nomList)); 
            }*/

            /*Dictionary<string, object> letraVegades = new Dictionary<string, object>();
            if (!letraVegades.ContainsKey(key))
            {
                letraVegades.Add(key, 54);
            }*/

            /*lletresRep.Add("15","hola");*/
            /*foreach(KeyValuePair<string, string> kvp in myDict) 
            { 
                Console.WriteLine("Key = {0}, Value = {1}", 
                    kvp.Key, kvp.Value); 
            } **/
            /*public static void fi()
            {
               
            }*/
            /*public static int vegades(string s, char c)
     {
         return s.Split(c).Length - 1;
     }*/
        }
    }
}