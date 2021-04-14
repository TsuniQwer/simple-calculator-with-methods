using System;



namespace С_
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Enter num one: ");
                double numOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter num two: ");
                double numTwo = Convert.ToDouble(Console.ReadLine()); 
                System.Console.WriteLine("+,-,*./");
                string cr = Console.ReadLine();

                switch (cr){
                    case "+":
                        System.Console.WriteLine("Answer: " + addition(numOne, numTwo));
                        break;
                    case "-":
                        System.Console.WriteLine("Answer: "+ subtraction(numOne, numTwo));
                        break;
                    case "*":
                        System.Console.WriteLine("Answer: "+ multiplication(numOne, numTwo));
                        break;
                    case "/":
                        if (numTwo == 0)  {
                            System.Console.WriteLine("Error, division on zero");
                            break;
                        }
                        System.Console.WriteLine("Answer: "+ division(numOne, numTwo));
                        break;
                    default:
                        System.Console.WriteLine("Error");
                        break;
                }
            }
            catch (Exception)
            {
              System.Console.WriteLine("Error, try again");
            }

            
           

        }
        static double addition(double numOne, double numTwo){
            return numOne + numTwo;
        }

        static double subtraction(double numOne, double numTwo){
            return numOne - numTwo;
        }

        static double multiplication(double numOne, double numTwo){
            return numOne * numTwo;
        }

        static double division(double numOne, double numTwo){    
            return numOne / numTwo;
        }

      
    }
}
