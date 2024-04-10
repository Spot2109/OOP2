namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Prime(17));
            // Console.WriteLine(Sum());
            // Console.WriteLine(Course());
            God();
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
        public static void God()
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)  
            {
                Console.WriteLine("Visokosna");
            }
            else
            {
                Console.WriteLine("Ne e visokosna");
            }
        }
        public static void Mesec() 
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool v = (n % 4 == 0 && n % 100 != 0 || n % 400 == 0) ? true : false;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine(v ? "29" : "28");
                    break;
            }
        }
    }
}