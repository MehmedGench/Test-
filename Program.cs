using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            // this projenct is for train vagoon and persons in vagoon  , than calculate persons in vagoon  !

            int countOfVagoon = int.Parse(Console.ReadLine());

            int[] peopleInVagoon = new int[countOfVagoon];
            int sum = 0;

            for (int i = 0; i < countOfVagoon; i++)
               // for (int i = 0; i < length; i++)
                //{

               // }
            {
                peopleInVagoon[i] = int.Parse(Console.ReadLine());
                sum += peopleInVagoon[i];
            }
            Console.WriteLine(String.Join(" ", peopleInVagoon));
            Console.WriteLine($"{sum}");



        }

    }
}
