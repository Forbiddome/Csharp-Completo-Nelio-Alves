using _15ex01_02_03.src;

namespace _15ex01_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercises Template

            Console.WriteLine("Activity 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            /*
            Console.WriteLine("\n\nExercise 01\n");
            {
                //C:\Users\chris\Desktop\Courses\C# Course\15 - D,g,s\Arquive.txt
                try
                {
                    Console.Write("Enter the file path with the arquive extension: ");
                    string path = Console.ReadLine();
                    int sum = 0;
                    HashSet<Log> logs = new HashSet<Log>();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!(sr.EndOfStream))
                        {
                            string[] data = sr.ReadLine().Split(" ");
                            string name = data[0];
                            DateTime date = DateTime.Parse(data[1]);
                            logs.Add(new Log(name, date));
                            Console.WriteLine("Login :" + name + ", " + date);
                            sum++;
                        }
                    }
                    Console.WriteLine("Total Logins: "+ sum +"\n\n");
                    foreach (Log logins in logs)
                    {
                        Console.WriteLine(logins.Name);
                    }

                    Console.Write("\nTotal users: " + logs.Count);
                }
                catch (Exception e)
                {
                    throw new Exception("Unexpected error: " + e.Message);
                }
            }
            */
            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {

            }

            //ex03--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 03\n");
            {

            }
        }
    }
}