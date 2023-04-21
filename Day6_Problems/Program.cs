namespace Day6_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the followin options 1.FibonacciNumber\n 2.ReverseNumber\n 3.PerfectNum");

            switch(option)
            {
                case 1:
                    FibonacciNumber fibonacciNumber = new FibonacciNumber();
                    fibonacciNumber.Number();
                    break;

                case 2:
                    Reverse reverse = new Reverse();
                    reverse.reverseNum();
                    break;

                case 3:
                    PerfectNum perfectNum = new PerfectNum();
                    perfectNum.perfectNum();
                    break;
                
                case 4:
                    PrimeNumber number = new PrimeNumber();
                    number.primeCheck();
                    break;

                case 5:
                    StopWatch watch = new StopWatch();
                    watch.time();
                    break;

            }
        }
    }
}