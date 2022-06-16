using System;
using System.Globalization;
using _10ex01_02_03_04.Entities;
using System.Collections.Generic;
using _10ex01_02_03_04.Entities.Enums;

namespace _10ex01_02_03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Exercise template
            Console.WriteLine("Exercise 01".ToUpper());
            /*
            //ex01--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 01\n");
            {
                List<Employee> employees = new List<Employee>();
                Console.Write("Enter the number of employees: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"---------Employee #{i} data----------");
                    Console.Write($"Outsourced(y / n) :");
                    char outSourced = char.Parse(Console.ReadLine());
                    Console.Write($"Name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write($"Value per hour: ");
                    double valuePerHours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    if (outSourced == 'y') {
                        Console.Write($"Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        employees.Add(new OutSourcedEmployee(name, hours, valuePerHours,additionalCharge));
                        continue;
                    }
                    //Lembrar do Upcasting - OutsourcedEmployee como subclasse de Employee naturalmente é referenciado
                    // ou convertido por uma variavel superclasse, já o contrário é mais dificil  o Downcasting
                    employees.Add(new Employee(name, hours, valuePerHours));
                }

                Console.WriteLine("Payments".ToUpper());
                foreach (Employee register in employees)
                {
                    Console.Write(register);
                }
            }
            */
            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                List<Product> products = new List<Product>();
                Console.Write("Enter the number of products: ");
                int n = int.Parse(Console.ReadLine());
                for (int index = 1; index <= n; index++)
                {
                    Console.WriteLine($"---------Product #{index} data----------");
                    Console.Write($"Common, used or imported: ");

                    // usando ENUMS convertebdo string para enum
                    ProductType type = Enum.Parse<ProductType>(Console.ReadLine());

                    // tipo usando CHAR + TABELA ASCII
                    //Console.Write($"Common, used or imported (c/u/i): ");
                    //int type = (int)char.Parse(Console.ReadLine());

                    Console.Write($"Name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Price: ");
                    double price = double.Parse(Console.ReadLine());

                    // usando ENUMS
                    switch (type)
                    {
                        case ProductType.Common:
                            products.Add(new Product(name, price, type));
                            break;
                        case ProductType.Used:
                            Console.Write("Manufacture Date : ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            products.Add(new UsedProduct(name, price, type, manufactureDate));
                            break;
                        case ProductType.Imported:
                            Console.Write("Customs fee: ");
                            double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            products.Add(new ImportedProduct(name, price, type, customFee));
                            break;
                    }

                    // versao usando CHAR + TABELA ASCII
                    //switch (type)
                    //{
                    //    case 99: // c
                    //        products.Add(new Product(name, price));
                    //        break;
                    //    case 117: // u
                    //        Console.Write("Manufacture Date : ");
                    //        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    //        products.Add(new UsedProduct(name, price, manufactureDate));
                    //        break;
                    //    case 105: // i
                    //        Console.Write("Customs fee: ");
                    //        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //        products.Add(new ImportedProduct(name, price, customFee));
                    //        break;
                    //    default:
                    //        break;
                    //
                    //}
                }
                Console.WriteLine("\nPRICE TAGS");
                foreach (Product index in products) Console.WriteLine(index.PriceTag());
            }

            //ex03--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nExercise 03\n");
            {

            }

            //ex04--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nExercise 04\n");
            {

            }
        }
    }
}
