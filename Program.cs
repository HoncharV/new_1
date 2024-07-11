namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {

                char again = 'y';
                while (again == 'y')
                {
                    double total;
                    double a;
                    double b;
                    char oper;

                    Console.WriteLine("enter the first number and press enter");
                    a = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("enter a math operation + - / * and press enter");
                    oper = Convert.ToChar(Console.ReadLine());


                    Console.WriteLine("enter the second number and press enter");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (oper == '+')
                    {
                        total = a + b;
                        Console.WriteLine("Result: " + total);
                    }
                    else if (oper == '-')
                    {

                        total = a - b;
                        Console.WriteLine("Result: " + total);

                    }
                    else if (oper == '*')
                    {
                        total = a * b;
                        Console.WriteLine("Result: " + total);
                    }

                    else if (oper == '/')
                    {
                        if (b != 0)
                        {
                            total = a / b;
                            Console.WriteLine(total);
                            Console.WriteLine("Result: " + total);
                        }
                        else
                        {
                            Console.WriteLine("You cannot divide by 0!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("unknown operator");
                    }


                    {
                        Console.WriteLine("click to continue (y/n)");
                        again = Convert.ToChar(Console.ReadLine());
                    }
                }



            }



        }
    }
}
    

