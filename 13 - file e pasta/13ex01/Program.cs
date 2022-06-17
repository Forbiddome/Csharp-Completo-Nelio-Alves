

// first .NET 6.0 (New .NET)
// In this exercise the txt file is created manually in the console, so it is possible to test more possibilities
// than in the proposed exercise given.
// Neste exercício o arquvo txt é criado manualmente no console, logo é possível testa mais possibilidades
// do que na proposta do exercício dado.


using System.Globalization;
using _13ex01.src.Entities;



List<Order> orders = new List<Order>();
Console.WriteLine("----------Order some Products----------");
Console.Write("How Many Products: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Order #{i + 1}: ");
    Console.Write("Enter the Product Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the unit Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Enter the Quantity: ");
    int qte = int.Parse(Console.ReadLine());
    orders.Add(new Order(name, price, qte));
}

try
{
    string sourcePath = @"C:\Users\Paulo\Desktop\Csharp-Completo-Nelio-Alves\13 - file e pasta\summaryTXT.txt";
    using (StreamWriter sw = File.AppendText(sourcePath))
    {
        foreach (Order order in orders)
        {
            sw.WriteLine(order);
        }
    }

    string[] lines = File.ReadAllLines(sourcePath);
    string targetPath = @"C:\Users\Paulo\Desktop\Csharp-Completo-Nelio-Alves\13 - file e pasta\summaryCSV.csv";


    using (StreamWriter sw = File.CreateText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format Exception: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected: " + e.Message);
}