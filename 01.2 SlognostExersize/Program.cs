﻿namespace _01._2_SlognostExersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Намиране на най-малко число 
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var minimum = list.First();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < minimum)
                {
                    minimum = list[i];
                }
            }

            Console.WriteLine(minimum);
        }
    }
}
