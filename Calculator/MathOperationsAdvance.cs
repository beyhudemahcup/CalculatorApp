
namespace Calculator
{
    public class MathOperationsAdvance
    {
        //better version of calculator
      

        public static Func<float,float,float> Addition = (a,b) => a + b;
        public static Func<float, float, float> Subtraction = (a, b) => a - b;
        public static Func<float, float, float> Multiplication = (a, b) => a * b;
        public static Func<float, float, float> Divide = (a, b) => a / b;
        public static Func<float, float, float> Modulus = (a, b) => a % b;
        public static Func<float, float, float> Combination = (a, b) =>
        {
            return Factoriel(a)/ (Factoriel(b) * Factoriel(a - b));
        };

        public static Func<float, float, float> Permutation= (a, b) =>
        {
            return Factoriel(a) / Factoriel(a - b);
        };

        public static float Factoriel(float number)
        {
            float result = 1;

            for (float i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }

        public static float TryParseFloat(string input, float value)
        {
            if (float.TryParse(input, out value))
            {
                Console.WriteLine($"Your number is: {value}");

                return value;
            }
            Console.WriteLine("Your value is incorrect, the value is set as 0");
            return 0.0f;
        }

        public static Dictionary<string, Func<float, float, float>> operations = new Dictionary<string, Func<float, float, float>>
            {
                { "+",Addition},
                { "-",Subtraction},
                { "*",Multiplication},
                { "/",Divide},
                { "%",Modulus},
                { "C",Combination},
                { "P",Permutation}
            };

    }
}
