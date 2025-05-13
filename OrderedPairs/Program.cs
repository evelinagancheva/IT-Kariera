namespace OrderedPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Наредени двойки
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int p = 1; p <= m; p++)
            {
                for (int q = 1; q <= n; q++)
                {
                    Console.WriteLine($"{p} {q}");
                }
            }
        }
    }
}
