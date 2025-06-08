using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //двоично търсене
            int[] array = new int[] { 1, 2, 3, 8, 12, 19, 22, 33, 45, 84 };
            int binary = BinarySearch(array, 8, 0, array.Length);
            Console.WriteLine(binary);
        }

        public static int BinarySearch(int[] arr, int searchedNumber, int start, int end)
        {
            while (end >= start)
            {
                int mid = (start + end) / 2;
                if (arr[mid] < searchedNumber)
                    start = mid + 1;
                else if (arr[mid] > searchedNumber)
                    end = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
