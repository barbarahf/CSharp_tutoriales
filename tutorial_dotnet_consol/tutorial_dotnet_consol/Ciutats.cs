using System;
using System.Collections.Generic;


namespace tutorial_dotnet_consol
{
    public class Ciutats
    {
        public static string[] ciutats =
            {"Santander", "Barcelona", "Zaragoza", "Valencia", "Malaga", "Cadis", "Barcelona", "Alicante"};

        public static Dictionary<char, int> alphabet = new Dictionary<char, int>();

        static void CreateTable()
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < abc.Length; i++)
            {
                alphabet.Add(abc[i], i);
            }
        }

        static void OrderArr(string[] ciutats)
        {
            string sav;
            for (int i = 0; i < ciutats.Length; i++)
            {
                for (int j = i + 1; j < ciutats.Length; j++)
                {
                    if (!CharValues(ciutats[i].ToLower(), ciutats[j].ToLower()))
                    {
                        sav = ciutats[i];
                        ciutats[i] = ciutats[j];
                        ciutats[j] = sav;
                    }
                }
            }
        }

        static bool CharValues(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; i < s2.Length; j++)
                {
                    if (alphabet[s1[i]] == alphabet[s2[j]])
                    {
                        i++;
                        j++;
                    }

                    if (alphabet[s1[i]] < alphabet[s2[j]])
                    {
                        return true;
                    }

                    if (alphabet[s1[i]] > alphabet[s2[j]])
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        static void ChangeChar(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ciutats[i];
                arr[i] = arr[i].Replace('a', '4');
                arr[i] = arr[i].Replace('A', '4');
            }
        }

        static void Main(string[] args)
        {
            //Fase 1
            //Fase 2 (Metodos)
            CreateTable();
            OrderArr(ciutats);
            //Fase 3
            string[] ArrayCiutatsModificades = new string[ciutats.Length];
            ChangeChar(ArrayCiutatsModificades);
            foreach (var i in ArrayCiutatsModificades)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //Fase 4
            List<List<char[]>> ciudadesChar = new List<List<char[]>>();
            for (int i = 0; i < ciutats.Length; i++)
            {
                ciudadesChar.Add(new List<char[]>()
                {
                    ciutats[i].ToCharArray()
                });
            }

            foreach (var i in ciudadesChar)
            {
                foreach (var colectionInterna in i)
                {
                    for (int j = colectionInterna.Length - 1; j >= 0; j--)
                    {
                        Console.Write(colectionInterna[j]);
                    }

                    Console.Write("  ");
                }
            }
        }
    }
}