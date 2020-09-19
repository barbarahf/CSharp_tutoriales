using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_dotnet_consol
{
    public class Ciutats
    {
        public static string[] ciutats = {"Barcelona", "Bercelone", "Valencia", "Malaga", "Cadis", "Santander"};
        public static string abc = "abcdefghijklmnopqrstuvwxyz";
        public static Dictionary<char, int> alphabet = new Dictionary<char, int>();

        static void CreateTable()
        {
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
            /*s1 = "Barcelona";
            s2 = "Madrid";*/
            next:
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; i < s2.Length; j++)
                {
                    if (alphabet[s1[i]] < alphabet[s2[j]])
                    {
                        return true; //Esto quiere decir que el orden alfabetico s1 va primero
                    }

                    if (alphabet[s1[i]] == alphabet[s2[j]])
                    {
                        goto next;
                    }

                    if (alphabet[s1[i]] > alphabet[s2[j]])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            /*DateTime tiempo1 = DateTime.Now;
            /*abdOrder();#1#
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("TIEMPO: " + total.ToString());*/
            foreach (var i in ciutats)
            {
                Console.WriteLine(i);
            }

            CreateTable();
            orderArr();
            foreach (var i in ciutats)
            {
                Console.WriteLine(i);
            }
        }
    }
}