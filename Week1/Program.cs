namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Prime(17));
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
    }
}