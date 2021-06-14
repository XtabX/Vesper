using System;

namespace Calculator0
{
    class Program
    {
        static int num1 = 0;
        static int num2 = 0;
        static void Main(string[] args)
        {
            string restart = " ";
            string operation = null;
            Console.WriteLine("Welcome to The Basic Calculator");
            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            while (!restart.Equals("end"))
            {
                Console.Clear();
                Console.WriteLine("Type a number");
                System.Threading.Thread.Sleep(2000);
                Console.CursorVisible = true;
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Chose a operator");
                Console.WriteLine("a = Add \ns = Substract\nd = Divide\nm = Multiply");
                operation = (Console.ReadLine());
                Console.WriteLine("Type another number");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (operation.Equals("a"))
                {
                    int answer = Add(num1, num2);
                    Console.WriteLine(answer);
                }
                else if (operation.Equals("s"))
                {
                    int answer = Sub(num1, num2);
                    Console.WriteLine(answer);
                }
                else if (operation.Equals("d"))
                {
                    double answer = Div(num1, num2);
                    Console.WriteLine(answer);
                }
                else if (operation.Equals("m"))
                {
                    int answer = Mul(num1, num2);
                    Console.WriteLine(answer);
                }
                Console.WriteLine("To exit program type end and enter, or just press enter to continue");
                restart = (Console.ReadLine());
            }

        }
        static int Add(int a, int b)
        {
            int numAdd = 0;
            numAdd = a + b;
            return numAdd;
        }

        static int Sub(int a, int b)
        {
            int numSub = 0;
            numSub = a - b;
            return numSub;
        }

        static double Div(int a, int b)
        {
            double numDiv = 0;
            numDiv = a / b;
            return numDiv;
        }

        static int Mul(int a, int b)
        {
            int numMul = 0;
            numMul = a * b;
            return numMul;
        }
    }
} 
    

