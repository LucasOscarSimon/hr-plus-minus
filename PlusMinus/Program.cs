using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        //6
        //-4 3 -9 0 4 1     
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);

            double positives = arr.Count(value => value > 0);
            double negatives = arr.Count(value => value < 0);
            double zeroValues = arr.Count(value => value == 0);

            double resultPositiveNumbers = positives / n;
            double resultNegativeNumbers = negatives / n;
            double resultZeroValuesNumbers = zeroValues / n;

            Console.WriteLine(resultPositiveNumbers);
            Console.WriteLine(resultNegativeNumbers);
            Console.WriteLine(resultZeroValuesNumbers);
        }
    }
}
