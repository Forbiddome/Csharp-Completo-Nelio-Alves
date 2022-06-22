using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace _14ex01_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Exercise template
            Console.WriteLine("Exercise 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 01\n");
            {

            }

            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                string path = @"C:\Users\Paulo\Desktop\Csharp-Completo-Nelio-Alves\14 - Interfaces\Arquive.txt";
                List<string> lista = new List<string>();
                try
                {
                    string[] arquive = File.ReadAllLines(path);
                    foreach (string line in arquive) lista.Add(line);
                    lista.Sort(); // Usa o Metodo Default da Interface IComparer para dar o Sort()
                    foreach (string name in lista) Console.WriteLine(name);
                }
                catch (Exception e)
                {
                    throw new Exception("Unexpected Exception: " + e.Message);
                }

            }

            //ex03--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n\nExercise 03\n");
            {
                string path = @"C:\Users\Paulo\Desktop\Csharp-Completo-Nelio-Alves\14 - Interfaces\Arquive.csv";
                try
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        List<EmployeeData> lista = new List<EmployeeData>();
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] data = line.Split(",");
                            string name = data[0];
                            double salary = double.Parse(data[1], CultureInfo.InvariantCulture);
                            lista.Add(new EmployeeData { Name = name, Salary = salary });
                        }
                        lista.Sort(); ;
                        foreach (EmployeeData employeeData in lista) Console.WriteLine(employeeData);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Unexpected Exception: " + e.Message);
                }
            }
        }
    }
}
