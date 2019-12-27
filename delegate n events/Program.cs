using System;

namespace delegate_n_events
{
    class Program
    {
        public delegate void Mess(string str);
        static public event Mess My;
        delegate void MessageHandler(string message);
        static void Main(string[] args)
        {

            My += mes => Console.WriteLine(mes);
            Sum(255);
            
           
        }

        private static void Program_My(string str)
        {
            Console.WriteLine(str);
        }

        private static int Plus(int x,int y)
        {
            return x + y;
        }
        static int Minus(int x,int y)
        {
            return x - y;
        }
        static int xuy(int x,int y)
        {
            Console.WriteLine("xuy");
            return x;
        }
       static public void Sum(int sum)
        {
            My?.Invoke($"Na s4ete {sum}");
        }
    }
}
