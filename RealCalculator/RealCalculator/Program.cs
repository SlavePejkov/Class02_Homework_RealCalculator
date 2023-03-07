namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");   
            string inputOne = Console.ReadLine();


            Console.WriteLine("Enter one more number");
            string inputTwo = Console.ReadLine();

            int numberParsedOne;
            int numberParsedTwo;

            bool parsedAnswerOne = int.TryParse(inputOne, out numberParsedOne);
            bool parsedAnswerTwo = int.TryParse(inputTwo, out numberParsedTwo);

            if (!parsedAnswerOne || !parsedAnswerTwo)
            {
                Console.WriteLine("You need to put a valid number");
                return;
            }
            

            Console.WriteLine("What operation would you like to do: +, - , * , /,");
            string operation = Console.ReadLine();

            if(operation == "/")
            {
                Console.WriteLine($"The result is: {numberParsedOne / numberParsedTwo}");
            }
            else if(operation == "+")
            {
                Console.WriteLine($"The result is: {numberParsedOne + numberParsedTwo}");
            } 
            else if(operation == "-")
            {
                Console.WriteLine($"The result is: {numberParsedOne - numberParsedTwo}");
            } 
            else if(operation == "*")
            {
                Console.WriteLine($"The result is: {numberParsedOne * numberParsedTwo}");
            }
            else
            {
                Console.WriteLine("You need to put a valid operation");
            }
        }
    }
}