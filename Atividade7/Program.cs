using System.Threading.Channels;
using static Atividade7.TesteException;

namespace Atividade7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 7 POO");
            List<double> list = new List<double>();
            double aux;
            while (list.Sum() <= 100)
            {
                try
                {
                    Console.WriteLine("\nDigite um valor:");
                    aux = double.Parse(Console.ReadLine());
                    if ((aux + list.Sum()) <= 100)
                    {
                        list.Add(aux);
                    }
                    else
                    {
                        throw new ExcecaoAcimaDeCem("Exceção gerada: Valor ultrapassou 100");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);

                    if(e.Message == "Exceção gerada: Valor ultrapassou 100")
                    {
                        break;
                    }
                }

            }

            Console.WriteLine($"\nValor da média dos números somados: {list.Average()}");
            Console.WriteLine($"Valor somado: {list.Sum()}");
            Console.WriteLine($"Quantidade de número somados: {list.Count}");
            Console.ReadKey();
        }
    }
}