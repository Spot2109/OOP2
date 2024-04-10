namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(Prime(17));
            Console.WriteLine(Sum());
        }
        public static bool Prime(int n)
        {
            int sqrt = (int)Math.Sqrt(n);

            for(int i = 2; i <= sqrt;i++)
            {
                if(n % i == 0)
                    return false;
            }
            return true;
        }
        public static decimal Sum()
        {
            string[] input = Console.ReadLine().Split(",");
            decimal result = 0;

            for (int i = 0; i < input.Length; i++) 
            {
                result += decimal.Parse(input[i]);
            }
            return result;
        }

    }
}