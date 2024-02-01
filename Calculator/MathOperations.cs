namespace Calculator
{
    public class MathOperations
    {
        public static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
        public static double Modulus(double number1, double number2)
        {
            return number1 % number2;
        }
        public static double Combination(double number1, double number2)
        {
            double number1Fac = Factoriel(number1);
            double number2Fac = Factoriel(number2);
            double number1Minus2Fac = Factoriel(Subtraction(number1, number2));

            return number1Fac / (number1Minus2Fac * number2Fac);

        }

        public static double Permutation(double number1, double number2)
        {
            double number1Fac = Factoriel(number1);
            double number1Minus2Fac = Factoriel(Subtraction(number1, number2));

            return number1Fac / number1Minus2Fac;

        }

        public static double Factoriel(double number)
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
