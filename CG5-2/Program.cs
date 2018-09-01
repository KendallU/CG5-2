using System;

namespace CG5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayNumbers = true;
            while (displayNumbers)
            {
                displayNumbers = NumberSet();
            }
        }


        private static bool NumberSet()
        {
            Console.WriteLine("What is your first number?");
            Console.Write("Type number here:");
            string firstNumber;
            firstNumber = Console.ReadLine();

            Console.WriteLine("What is your second number?");
            Console.Write("Type number here:");
            string secondNumber;
            secondNumber = Console.ReadLine();

            int firstNumb = int.Parse(firstNumber);
            int secondNumb = int.Parse(secondNumber);
            int operation = int.Parse(operations);

            Console.WriteLine("Choose your operation:");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            string result = Console.ReadLine();
            result = Console.ReadLine();

            if (result == "1")
            {
                string OperationAdd();
              
                return true;
            }
            else if (result == "2")
            {
                string OperationSub();
               
                return true;
            }
            else if (result == "3")
            {
                string OperationMult();
               
                return true;
            }
            else if (result == "4")
            {
                string OperationDiv();
               
                return true;

            }
            else
            {
                Console.Write("Sorry I don't understand!");
                Console.ReadLine();
            }



        }
        private static string OperationAdd(int firstNumb, int secondNumb)

        {
           int operation = firstNumb + secondNumb;
            Console.WriteLine(firstNumb + "+" + secondNumb + "=" + operation);
            Console.ReadLine();



        }
        private static string OperationSub(int firstNumb, int secondNumb)

        {
           int operation = firstNumb - secondNumb;
            Console.WriteLine(firstNumb + "-" + secondNumb + "=" + operation);
            Console.ReadLine();


        }
        private static string OperationMult(int firstNumb, int secondNumb)
        {
           int operation = firstNumb * secondNumb;
            Console.WriteLine(firstNumb + "*" + secondNumb + "=" + operation);
            Console.ReadLine();

        }
        private static string OperationDiv(int firstNumb, int secondNumb)
        {
           int operation = firstNumb / secondNumb;
            Console.WriteLine(firstNumb + "/" + secondNumb + "=" + operation);
            Console.ReadLine();

        }
        
       
       
    }

    

}
