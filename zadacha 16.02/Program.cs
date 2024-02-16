
using System.Threading.Channels;

namespace zadacha_16._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
             if (numbers.Length == 1) 
            {
                Console.WriteLine(numbers[0]);
            }

            else if (numbers.Length % 2 == 0 ) 
            {
                Console.WriteLine(numbers.Length / 2);
                Console.WriteLine(numbers.Length / 2 + 1);
            }
            else if (numbers.Length % 2 == 1 )
            {
                Console.WriteLine(numbers.Length/2);
                Console.WriteLine(numbers.Length/2 + 1);
                Console.WriteLine(numbers.Length / 2 + 2);
            }
            
        }
    }
}
