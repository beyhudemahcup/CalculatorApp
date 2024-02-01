namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //low level coding first example
            Console.WriteLine("Welcome to the calculator app!\n");
            Console.WriteLine("Please enter a operation you want to do:\n +, -, *, /, %, C for combination, P for permutation");

            //Console.WriteLine("You can enter: A letter 'A' for Addition (+)," +
            //   "'S' for subtraction (-), 'M' for multiplication (*), 'D' for division (/), 'O' for modulus (%)," +
            //   " 'C' for combination, 'P' for permutation}");

            //string input = Console.ReadLine();
            //char letter = input.ToUpper()[0];

            //Console.WriteLine("Please enter a first number!");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter a second number!");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            //if (letter == 'A')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Addition(number1, number2)}");
            //}
            //else if (letter == 'S')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Subtraction(number1, number2)}");
            //}
            //else if (letter == 'M')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Multiplication(number1, number2)}");
            //}
            //else if (letter == 'D')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Divide(number1, number2)}");
            //}
            //else if (letter == 'O')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Modulus(number1, number2)}");
            //}
            //else if (letter == 'C')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Combination(number1, number2)}");
            //}
            //else if (letter == 'P')
            //{
            //    Console.WriteLine($"Your operation is done. Result is {MathOperations.Permutation(number1, number2)}");
            //}
            //else
            //{
            //    Console.WriteLine("Your input value is not correct! Try again ");
            //}

            //better version of the calculator
            string input = Console.ReadLine();
            input = input.ToUpper();
           
            if (MathOperationsAdvance.operations.TryGetValue(input, out var operation))
            {
                float value = 0;

                Console.WriteLine("Please enter a first number!");
                string numberInput = Console.ReadLine();

                float num1 = MathOperationsAdvance.TryParseFloat(numberInput, value);

                Console.WriteLine("Please enter a second number!");
                numberInput = Console.ReadLine();

                float num2 = MathOperationsAdvance.TryParseFloat(numberInput, value);
                Console.WriteLine($"Your operation ({input}) is done. Result is {operation.Invoke(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Your value is incorrect!");
            }
        }
    }
}



