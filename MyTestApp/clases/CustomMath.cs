namespace MyTestApp.clases;

public class CustomMath {
    public static bool IsPrime(int number) {
        // Calculate the square root of the number
        int numberSqrt = (int)Math.Round(Math.Sqrt(number), MidpointRounding.AwayFromZero);

        // Iterate from 2 to the square root of the number
        for (int n = 2; n <= numberSqrt; n++) {
            // Check if the number is divisible by n
            if (number % n == 0) {
                // If it's divisible, return false (not prime)
                return false;
            }
        }

        // If no divisors were found, return true (prime)
        return true;
    }

    public static int Power(int baseNumber, int exponent) {
        int result = baseNumber;
        for(int i = 0; i < exponent-1; i++) {
            Console.WriteLine("i: " + i);
            //  equals to result = result * baseNumber
            result *= baseNumber;  
            Console.WriteLine("result: " + result);
        }

        return result;
    }

    public static double CircleArea(double radio) {
        double pi = 3.14159265358979323846;
        double area = pi * (radio * radio);
        return area;
    }

    public static string ToBinary(int number) {
        return Convert.ToString(number, 2);
    }

    /// <summary>
    /// Converts a int number to hexadecimal format
    /// </summary>
    /// <param name="number">Number to convert.</param>
    /// <returns>The number in hexadecimal format.</returns>
    public static string ToHexadecimal(int number) {
        return Convert.ToString(number, 16);
    }

    public static double Average(int[] numbers) {
        double average;
        int sumNumbers = 0;
        for(int i = 0; i<numbers.Length; i++) {
            sumNumbers += numbers[i];
        }

        average = (double) sumNumbers / numbers.Length;

        return average;
    }

}