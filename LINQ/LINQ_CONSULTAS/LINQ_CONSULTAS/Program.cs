using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


// ReSharper disable All

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            //Ejercicio 01
            int[] arrIntegers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var lst = from i in arrIntegers
                where i == 2 || i == 10
                orderby i
                select i;
            foreach (var i in lst)
            {
                Console.WriteLine(i);
            }

            Complex[] grupOfComplex =
            {
                new Complex(1, "a1"),
                new Complex(2, "a2"),
                new Complex(3, "Rojo"),
            };
            var getRejos = (from i in grupOfComplex
                where i.str == "Rojo"
                select i).FirstOrDefault();
            Console.WriteLine(getRejos.ToString());

            //Documentacion Oficial de microsoft 
            int[] numbers = new int[7] {0, 1, 2, 3, 4, 5, 6};

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                // IEnumerable<T> Implicito
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery) //Cuando se ejecuta, la consulta se realiza
            {
                Console.Write("{0,1} ", num);
            }

            //Consulta externa a documento xml
            XElement contacts = XElement.Load(@"c:\myContactList.xml");

            //Consulta a una base de datos

            //Northwnd db = new Northwnd(@"c:\northwnd.mdf");

            // Query for customers in London.  
            //   IQueryable<Customer> custQuery =
            // from cust in db.Customers
            // where cust.City == "London"
            // select cust;
        }

        public class Complex //Ejemplo con array de objetos
        {
            public int num { get; set; }
            public string str { get; set; }

            public Complex(int num, string str)
            {
                this.num = num;
                this.str = str;
            }


            public override string ToString()
            {
                return num.ToString() + " " + str;
            }
        }
    }
}