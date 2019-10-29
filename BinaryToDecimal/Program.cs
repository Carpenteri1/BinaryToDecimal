/*
 *Author:Niclas Timle
 *Date: 29-10-2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter binary numbers 1 and 0 to get its decimal representation: ");
            int bin = int.Parse(Console.ReadLine());
            string value = bin.ToString();
            double pow = 0;
            char[] numbers = value.ToCharArray();
            int counter = 0;
            double convert;

            //Convert char to numric value, and converts binary to decimal with pow and for loop
            for (int j = bin.ToString().Length-1; j >= 0; j--)
            {
                convert = char.GetNumericValue(numbers[counter]);
                pow += convert * (Math.Pow(2, j));
                counter++;
            }

            //FORMULA WORKS WITH Binary 1010
           // pow = 1 * Math.Pow(2,3) + 0*Math.Pow(2,2) + 1*Math.Pow(2,1) + 0 * Math.Pow(2,0);
            Console.WriteLine("Result: "+pow);
            Console.ReadKey();

        }
    }
}
