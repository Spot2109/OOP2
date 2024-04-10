namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Prime(17));
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
        public static bool Course()
        {
            string[] euroArr = Console.ReadLine().Split(",");
            string[] usdArr = Console.ReadLine().Split(",");

            if(euroArr.Length != usdArr.Length)
            {
                Console.WriteLine("invalid input");
            }
            decimal[] euroToLv = new decimal[euroArr.Length];
            decimal[] usdToLv = new decimal[usdArr.Length];

            for (int i = 0; i < euroArr.Length; i++)
            {
                euroToLv[i] = Decimal.Parse(euroArr[i]) * 1.95m;
                usdToLv[i] = Decimal.Parse(usdArr[i]) * 1.8m;
            }

            for(int i = 0;i < usdArr.Length;i++)
            {
                if (euroToLv[i] != usdToLv[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}