using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //линейно търсене
            List<int> list = new List<int>() { 5, 12, 1, 120, 84, 45, 57, 15, 18 };
            int linear = LinearSearch(list, 120);
            Console.WriteLine(linear);
        }

        public static int LinearSearch(List<int> nums, int searchedNumber)
        {
            for (int index = 0; index < nums.Count; index++)
            {
                if(searchedNumber== nums[index])
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
