
namespace Calculator
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("Please enter a operation you want to do.");
            Console.WriteLine("You can enter: A letter 'A' for Addition (+)," +
                "'S' for subtraction (-), 'M' for multiplication (*), 'D' for division (/), 'O' for modulus (%)," +
                " 'C' for combination, 'P' for permutation}");
            Console.WriteLine("Don't forget the your input will be like First Number (the operator will be used you entered) Second Number");

            string input = Console.ReadLine();

            input = input.ToUpper();
            char letter = input[0];

            Console.WriteLine("Please enter a first number!");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a second number!");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (letter == 'A')
            {
                Console.WriteLine($"Your operation is done. Result is {Addition(number1, number2)}");
            }
            else if (letter == 'S')
            {
                Console.WriteLine($"Your operation is done. Result is {Subtraction(number1, number2)}");
            }
            else if (letter == 'M')
            {
                Console.WriteLine($"Your operation is done. Result is {Multiplication(number1, number2)}");
            }
            else if(letter == 'D')
            {
                Console.WriteLine($"Your operation is done. Result is {Divide(number1, number2)}");
            }
            else if (letter == 'O')
            {
                Console.WriteLine($"Your operation is done. Result is {Modulus(number1, number2)}");
            }
            else if (letter == 'C')
            {
                Console.WriteLine($"Your operation is done. Result is {Combination(number1, number2)}");
            }
            else if (letter == 'P')
            {
                Console.WriteLine($"Your operation is done. Result is {Permutation(number1, number2)}");
            }
            else
            {
                Console.WriteLine("Your input value is not correct! Try again ");
            }
        }

        static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
        static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
        static double Modulus(double number1, double number2)
        {
            return number1 % number2;
        }
        static double Combination(double number1, double number2)
        {
            double number1Fac = Factoriel(number1);
            double number2Fac = Factoriel(number2);
            double number1Minus2Fac = Factoriel(Subtraction(number1, number2));

            return number1Fac / (number1Minus2Fac * number2Fac);

        }

        static double Permutation(double number1, double number2)
        {
            double number1Fac = Factoriel(number1);
            double number1Minus2Fac = Factoriel(Subtraction(number1, number2));
            
            return number1Fac / number1Minus2Fac ;

        }

        static double Factoriel(double number)
        {
            double result = 1;

            for (double i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}