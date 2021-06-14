using System;


namespace Calculator0
    {
        class Program
        {
            static double num1 = 0;
            static double num2 = 0;
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
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Chose a operator");
                    Console.WriteLine("a = Add \ns = Substract\nd = Divide\nm = Multiply");
                    operation = (Console.ReadLine());
                    Console.WriteLine("Type another number");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (operation.Equals("a"))
                    {
                        double answer = Add(num1, num2);
                        Console.WriteLine(answer);
                    }
                    else if (operation.Equals("s"))
                    {
                        double answer = Sub(num1, num2);
                        Console.WriteLine(answer);
                    }
                    else if (operation.Equals("d"))
                    {
                        double answer = Div(num1, num2);
                        Console.WriteLine(answer);
                    }
                    else if (operation.Equals("m"))
                    {
                        double answer = Mul(num1, num2);
                        Console.WriteLine(answer);
                    }
                    Console.WriteLine("To exit program type end and enter, or just press enter to continue");
                    restart = (Console.ReadLine());
                }

            }
            static double Add(double a, double b)
            {
                double numAdd = 0;
                numAdd = a + b;
                return numAdd;
            }

            static double Sub(double a, double b)
            {
                double numSub = 0;
                numSub = a - b;
                return numSub;
            }

            static double Div(double a, double b)
            {
                while (a == 0)
                {
                    Console.WriteLine("You cannot divide with zero. chose another number");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                while (b == 0)
                {
                    Console.WriteLine("You cannot divide with zero. chose another number");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                double numDiv = 0;
                numDiv = a / b;
                return numDiv;
            }

            static double Mul(double a, double b)
            {
                double numMul = 0;
                numMul = a * b;
                return numMul;
            }
        }
    }


