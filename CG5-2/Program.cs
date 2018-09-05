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
            
            
            

            Console.WriteLine("Choose your operation:");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            string result = Console.ReadLine();
            

            if (result == "1")
            {
                OperationAdd(firstNumb, secondNumb);
         
                return true;
            }
            else if (result == "2")
            {
                OperationSub(firstNumb, secondNumb);
                
                

                return true;
            }
            else if (result == "3")
            {
                OperationMult(firstNumb, secondNumb);
                
                

                return true;
            }
            else if (result == "4")
            {
                OperationDiv(firstNumb, secondNumb);
                
               

                return true;

            }
            else
            {
                Console.Write("Sorry I don't understand!");
               
                return false;

            }
            



        }
        private static void OperationAdd(int firstNumb, int secondNumb)

        {
            
           int operation =  firstNumb +  secondNumb;
            Console.WriteLine("The answer is," + operation);
            Console.ReadLine();
            
            


        }
        private static void OperationSub(int firstNumb, int secondNumb)

        {
            int operation;
            operation = firstNumb - secondNumb;
            Console.WriteLine("The answer is," + operation);
            Console.ReadLine();




        }
        private static void OperationMult(int firstNumb, int secondNumb)
        {
            int operation; 
                operation = firstNumb * secondNumb;
            Console.WriteLine("The answer is," + operation);
            Console.ReadLine();



        }
        private static void OperationDiv(int firstNumb, int secondNumb)
        {
            int operation;
            operation = firstNumb / secondNumb;
            Console.WriteLine("The answer is," + operation);
            Console.ReadLine();


        }
        
       
       
    }

    

}
