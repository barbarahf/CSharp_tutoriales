using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_dotnet_consol
{
    public class Ciutats
    {
        public static string[] ciutats =
            {"Santander", "Barcelona", "Zaragoza", "Valencia", "Malaga", "Cadis", "Barcelona"};

        public static Dictionary<char, int> alphabet = new Dictionary<char, int>();

        static void CreateTable()
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < abc.Length; i++)
            {
                alphabet.Add(abc[i], i);
            }
        }

        static void orderArr()
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

        static void changeChar(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                ciutats[i] = ciutats[i].Replace('a', '4');
                ciutats[i] = ciutats[i].Replace('A', '4');
            }
        }

        static void Main(string[] args)
        {
            //Fase 1
            //Metodos fasse 2
            CreateTable();
            orderArr();
            //Fase 3
            string[] ArrayCiutatsModificades = new string[ciutats.Length];
            foreach (var i in ciutats)
            {
                Console.Write(i + " ");
            }

            changeChar(ArrayCiutatsModificades);
            Console.WriteLine();
            foreach (var i in ciutats)
            {
                Console.Write(i + " ");
            }
        }
    }
}