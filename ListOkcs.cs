using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsName
{
    class ListOkcs
    {
        static public int Number { get; set; }

        static public string[] Names { get; set; }
        static public string[] Pairs { get; set; }



        public ListOkcs(int number, string[] names, string[] pairs)
        {
            Number = number;
            Names = names;
            Pairs = pairs;
        }


        static public void InputNames()
        {
            Console.WriteLine("Input names:");

            for (int i = 0; i < Number; i++)
            {
                Console.Write($"{i + 1}. ");
                Names[i] = Console.ReadLine();

            }
        }
        static public void ShuffleNames()
        {
            var rnd = new Random();
            for (int i = Number - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);

                var temp = Names[j];
                Names[j] = Names[i];
                Names[i] = temp;

            }
        }
        static public void CreatePairs()
        {

            for (int i = 0; i < Names.Length / 2; i++)
            {

                Pairs[i] = $"{i + 1}. {Names[i + Names.Length / 2]} & {Names[i]}";

            }
        }
        static public void PrintPairs()
        {
            for (int i = 0; i < Pairs.Length; i++)
            {
                Console.WriteLine($"{ Pairs[i]}.");
            }
        }
    }
}
