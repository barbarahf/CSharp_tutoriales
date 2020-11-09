using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYFRAMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {

            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Departments> listDepartments = DBEntities.Departments.ToList();
                Console.WriteLine();
                foreach (Departments dept in listDepartments)
                {
                    Console.WriteLine("  Department = {0}, Location = {1}", dept.Name, dept.Location);
                    foreach (Employees emp in dept.Employees)
                    {
                        Console.WriteLine("\t Name = {0}, Email = {1}, Gender = {2}, salary = {3}",
                            emp.Name, emp.Email, emp.Gender, emp.Salary);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}

