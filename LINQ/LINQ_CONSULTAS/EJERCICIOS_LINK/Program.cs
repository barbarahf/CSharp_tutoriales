using System;
using System.Linq;


namespace EJERCICIOS_LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = {2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4};
            //Ejercicio 01, consultar los números pares
            var numerosPares =
                from i in numberArr
                where (i % 2 == 0)
                select i;
            foreach (int num in numerosPares)
            {
                Console.WriteLine("{0,1} ", num);
            }

            //Ejercicio 02, calcular la nota media, maxima y minima, a partir del array
            var notaMedia =
                (from i in numberArr
                    select i).Average();
            var maxNota =
                (from i in numberArr
                    select i).Max();
            var minNota =
                (from i in numberArr
                    select i).Min();


            Console.WriteLine(notaMedia + " " + maxNota + " " + minNota);
            //Ejercicio 03, obtener los valores más pequeños que 5/ más grandes que 5 y añadirlos a un array
            var greaterThanFive =
                from i in numberArr
                where i >= 5
                select i;
            var smallerThanFive =
                from j in numberArr
                where j < 5
                select j;

            int[] menorCinco = smallerThanFive.ToArray();
            int[] mayorCinco = greaterThanFive.ToArray();
            foreach (var i in menorCinco)
            {
                Console.WriteLine(i);
            }

            foreach (var i in mayorCinco)
            {
                Console.WriteLine(i);
            }

            //Ejercicio 04
            string[] noms = {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol", "Ana"};

            //Consultar los nombres que comienzan por "o"
            var nomFirstisO =
                from nom in noms
                where nom[0].Equals('O')
                select nom;
      
            foreach (var i in nomFirstisO)
            {
                Console.Write(i+" ");
            }

            //Consultar nombres con más de 6 letras
            var moreThanSixChars =
                from i in noms
                where i.Length >= 6
                select i;
            foreach (var i in moreThanSixChars)
            {
                Console.WriteLine  (i+" ");
               
            }
            noms.ToList();
            var arr = noms.OrderBy(x => x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {    Console.Write((i==arr.Length-1) ? arr[i]+" " :arr[i]+", ");
                
            }
        }
    }
}