using System.Linq;
using _17ex01_02_03_04_05_06.src;


namespace _17ex01_02_03_04_05_06
{
    internal class Program
    {
        delegate Product Selector(Product x); //um delegate próprio criado deve ter os mesmos parametros dã função recebida!!!
        static void Main(string[] args)
        {
            {
                //03

                //Fazer um programa que, a partir de uma lista de produtos, gere uma
                //nova lista contendo os nomes dos produtos em caixa alta.
                List<Product> list = new List<Product>();
                list.Add(new Product("Tv", 900.00));
                list.Add(new Product("Mouse", 50.00));
                list.Add(new Product("Tablet", 350.50));
                list.Add(new Product("HD Case", 80.90));

                // Usando Delegate próprio + Coleção IEnumerable ou um UpCasting + metodo static e Select gerando objeto a objeto
                //Selector selector = Product.ReturnToUpper;
                //list = list.Select(selector.Invoke).ToList(); //To.List<T>() Converte do Return IEnumerable para List

                //Selector selector = Product.ReturnToUpper;
                // Func está usando tipos <in T(product), out TResult(product)> e um parametro Product 
                //Func<Product,Product> func = selector.Invoke; // que é preenchido PELO USO da Função Product.ReturnUpper EM list.Select pelo delegate
                //list = list.Select(func).ToList();

                // uso de um Func <In T, out T> (T arg) + expressao Lambda
                //Func<Product, Product> func = p => new Product(p.Name.ToUpper(),p.Price);
                //list = list.Select(func).ToList();

                foreach (Product product in list)
                    Console.WriteLine(product);
            }
        }
    }
}