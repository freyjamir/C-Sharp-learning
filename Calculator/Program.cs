using System;

namespace Calculator
{
    class Program
    {
        static int Calc (int a, int b, string op)
        {
             switch (op)
            {
                case "+":
                    int result = a + b;
                    return result;
                case "-":
                    int result_neg = a - b;
                    return result_neg;
                case "/":
                    int result_div = a / b;
                    return result_div;
                case "*":
                    int result_mult = a * b;
                    return result_mult;
                default :
                    Console.Write("Please enter correct operator \n");
                    Console.Write("Enter operator : ");
                    string ope = Console.ReadLine();
                    int return_ko = Calc(a, b, ope);
                    return return_ko;
            }
        }
        static bool check_continue ()
        {
                Console.Write("Continue Yes or No :");
                string again = Console.ReadLine();
                if (again == "No" || again == "N")
                    return false; 
                else if (again == "Yes" || again == "Y")
                    return true;
                else 
                    Console.Write("Only Yes/Y or No/N \n");
                    check_continue ();
                    return false;
        }
        static void Main(string[] args)
        {
            bool running = true;
            while(running == true)
            {
                //prompt user for numbers
                Console.Write("Enter 1st Number : ");
                int num_a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2st Number : ");
                int num_b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter operator : ");
                string op = Console.ReadLine();

                if (op != "+" || op != "-" || op != "*" ||op != "/" )
                {
                    Console.Write("Please enter correct operator \n");
                    Console.Write("Enter operator : ");
                    string ope = Console.ReadLine();
                    int result = Program.Calc(num_a, num_b, ope);
                    Console.WriteLine(num_a + ope + num_b + " = " + result);
                }
                else
                {
                    //Calculation
                    int result = Program.Calc(num_a, num_b, op);
                    Console.WriteLine(num_a + op + num_b + " = " + result);
                }
                running = check_continue ();
            }   

        }

        
    }
}
