using System;
using System.Globalization;
using _14ex01_02_03.src;

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
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date(dd / MM / yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int installments = int.Parse(Console.ReadLine());

                // first contructor ::: when we know the fee and the interest
                PaypalPaymentService p = new PaypalPaymentService(number, date, value, installments);
                Console.WriteLine(p.ShowInstallments());
            }

            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {

            }


            //ex03--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n\nExercise 03\n");
            {

            }
        }
    }
}
