namespace Home_Work_12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi(11));
        }


        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
