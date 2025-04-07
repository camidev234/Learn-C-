namespace MyTestApp.clases;
using System;

public class InitialExcercises {
    /*
        Ejercicios propuestos:  
             (1.5.3.1) Crea un programa que calcule el producto de los números 121 y 132, usando 
            variables. 
             (1.5.3.2) Crea un programa que calcule la suma de 285 y 1396, usando variables. 
             (1.5.3.3) Crea un programa que calcule el resto de dividir 3784 entre 16, usando 
            variables. 
    
    */

    public static int CalculateProduct(int numberOne, int numberTwo) {
        int result = numberOne * numberTwo;

        return result;
    }

    public static int CalculateSum(int numberOne, int numberTwo) {
        int result = numberOne + numberTwo;

        return result;
    }

    public static double CalculateModule(int numberOne, int numberTwo) {
        int module = numberOne % numberTwo;
        return module; 
    }

    public static int Power(int baseNumber, int exponent) {
        int result = baseNumber;
        for(int i = 0; i < exponent-1; i++) {
            Console.WriteLine("i: " + i);
            //  equals to result = result * baseNumber
            result *= baseNumber;  
            Console.WriteLine("result: " + result);
        }

        /*
        e = 2
        i = 0
        r = 4;
        i = 1
        r = 8
        i = 2
        r = 16
        */ 

        return result;
    }

    public static void ShowProductTable(int number) {
        for(int mult = 1; mult <= 10; mult++) {
            int op = number * mult;
            Console.WriteLine("{0} x {1} = {2}", number, mult, op);
        }
    }


    public static double MiToMt(double miles) {
        // 1609.344
        const double meterPerMile = 1609.344;
        double meters = meterPerMile * miles;

        return meters;
    }

    public static bool MultOf(int number, int multOf) {
        if(number % multOf == 0) {
            return true;
        }

        return false;
    }

    public static int MajorOfThree(int numOne, int numTwo, int numThree) {
        if(numOne < numTwo) {
            if(numTwo > numThree) {
                return numTwo;
            }else {
                return numThree;
            }
        } else {
            if(numOne > numThree) {
                return numOne;
            }else {
                return numThree;
            }
        }
    }

    public static void PrintNumbersInRange(int finalNumber) {

        int n = 0;
        
        // Solve using while

        // while(n < finalNumber) {
        //     n += 1;
        //     Console.WriteLine(n);
        // }

        // Solve using do while

        do {
            n+=1;
            Console.WriteLine(n);
        } while(n<finalNumber);
        
    }

    public static void PrintPairNumbers() {
        int initialNumber = 26;
        // While
        // Console.WriteLine(initialNumber);

        // while(initialNumber > 10) {
        //     initialNumber -= 1;
        //     if(initialNumber % 2 == 0) {
        //         Console.WriteLine(initialNumber);
        //     }
        // }

        // Do while

        do {
            if(initialNumber % 2 == 0) {
                Console.WriteLine(initialNumber);
            }
            initialNumber -= 1;
        } while(initialNumber >= 10);

    }

    public static int CountDigits(int number) {

        /*

            Logica para calcular las cifras de un numero:

            La idea es que cuando el resultado de la division del numero entre 10 sea menor a 10, ya se
            sabe que tiene una cifra.   

            Ejemplo 456

            1. Se divide el **numero** entre 10
            2. Se aumenta el contador de cifras en 1 (++)
            3. Dado el caso el resultado de la division
            no es menor a 10, se repite el paso uno y dos (numero / 10)

            Los pasos anteriores se hacen en bucle while cuya condicion es numero >=10

            ¿que pasa si es que el numero es de una cifra?

            Simplemente se retorna el contador de cifras en uno ya que de por si nunca entro al while
            al ser menor que 10 esto ya que por logica todo numero menor a 10 tiene solo una cifra.
                
        */

        if(number < 0) {
            Console.WriteLine("The number may be a positive, please retry");
            return 0;
        }

        int countDigits = 0;

        while(number >= 10) {
            number /= 10;
            countDigits ++;
        }

        return countDigits+1;
    }


    public static void RandomGame() {
        Random random = new();
        int randomNumber = random.Next(1, 10);
        int attemps = 3;
        Console.WriteLine("Remember, you have {0} attemps", attemps);
        while(attemps > 0) {
            try {
                Console.Write("Enter the number that you think is: ");
                int numberAttemp = Convert.ToInt32(Console.ReadLine());
                attemps -= 1;
                if(numberAttemp == randomNumber) {
                    Console.WriteLine("Congratulations, the number was {0}", randomNumber);
                    break;
                }else {
                    Console.WriteLine("Retry again, you have {0} attemps", attemps);
                }
            } catch(FormatException) {
                Console.WriteLine("The number must be an positive");
            }
            
        }
    }

    public static void PrintNumbersDecrement() {
        for(int i = 15; i>=5; i--) {
            Console.WriteLine(i);
        }
    }

    public static void TestFor() {
        for(int i = 0; i<=3; i++) {
            for(int o = 1; o<=5; o++) {
                Console.WriteLine(i + " - " + o);
            }
        }
    }

    public static bool IsPrime(int number) {
        int numberSqrt = (int) Math.Round(Math.Sqrt(number), MidpointRounding.AwayFromZero);
        for(int n = 2; n <= numberSqrt; n++) {
            if(number % n == 0) {
                return false;
            }
        }
        return true;
    }

    public static void PrintSquare(int rows, int columns) {
        for(int row = 1; row<=rows; row++) {
            for(int col = 1; col<=columns; col++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void PrintInvertTriangle(int rows) {
        int columns = rows;
        for(int row = 1; row<=rows; row++) {
            for(int col = columns; col>0; col--) {
                Console.Write("*");
            }
            columns--;
            Console.WriteLine();
        }
    }

    public static void PrintPartialSquare(int rows, int columns) {
        /*
            rows = 4
            columns = 3

            **** 
            *  * 
            **** 
        */

        for(int row = 1; row<=rows; row++) {
            for(int col = 1; col <=columns; col++) {
                if(row == rows || row == 1) {
                    Console.Write("*");
                } else {
                    if(col == 1 || col == columns) {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }

    }

    public static void PrintTriangle(int rows) {
        for(int row = 1; row<=rows; row++) {
            for(int col = rows; col>0; col--) {
                if(col == row || col < row) {
                    Console.Write("*");
                } else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void ShowHexadecimalNumbers() {
        int numberToConvert = 0;
        for(int row = 1; row<=5; row++) {
            for(int column = 0; column<=15; column++) {
                string numberConverted = CustomMath.ToHexadecimal(numberToConvert);
                Console.Write(numberConverted + " ");
                numberToConvert++;
            }
            Console.WriteLine();
        }
    }

    public static string RgbToHexadecimal(int red, int green, int blue) {
        string colorInHexadecimal;

        string redHexadecimal = Convert.ToString(red, 16);
        string greenHexadecimal = Convert.ToString(green, 16);
        string blueHexadecimal = Convert.ToString(blue, 16);

        colorInHexadecimal = redHexadecimal + greenHexadecimal + blueHexadecimal;

        return colorInHexadecimal;
    }

    public static bool IsVocal(char letter) { 
        if(letter == 'a' ||  letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            return true;
        }

        return false;
    }

    public static int MaxNumber(int[] numbers) {
        int max = numbers[0];
        for(int i = 0; i<numbers.Length; i++) {
            // if in the current index the number is major than max, the major is the current number
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    public static int FindDayOfYear(int month, int day) {
        int[] daysPerMonth = {31,28,31,30,31,30,31,31,30,31,30,31};

        if(day < 1 || day > daysPerMonth[month-1] || month < 1 || month > 12) {
            return 0;
        }

        int sumDays = 0;

        for(int i = 0; i<month-1; i++) {
            sumDays += daysPerMonth[i];
        }

        sumDays += day;

        return sumDays;

    }

    public static int[] SortArray(int[] numbers) {
        // [2,4,6,8,8,23]

        for(int i = 0; i<numbers.Length -1; i++) {
            for (int j = 0; j < numbers.Length - 1; j++) {

                if (numbers[j] > numbers[j + 1])
                {
                    int auxVar = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = auxVar;
                }
            }
        }

        return numbers;
    }

    public static void ShowBidimensionalArray<T>(T[,] bidimensionalArray) {
        /*
            Important methods:
            - array.Length -> Total elements (rows * cols)
            - array.GetLength(0) -> Total rows (0 is a constant)
            - array.GetLength(1) -> Total cols (1 is a constant) 
            - array.Rank -> Dimentions
        */
        for(int r = 0; r < bidimensionalArray.GetLength(0); r++) {
            // This for iterates each row 
            Console.WriteLine($"Showing row {r+1}");
            for(int c = 0; c < bidimensionalArray.GetLength(1); c++) {
                // This for iterates each column in this current row
                Console.WriteLine($"Column {c+1} (Coord [{r}, {c}]): {bidimensionalArray[r,c]}");
            }
            Console.WriteLine();
        }
    }

    public static int[] MajorPerRow(int[,] bidimensionalArray) {
        // init 1D array, when the lenght will be the number of rows in the bidimensional array
        int[] majorPerRow = new int[bidimensionalArray.GetLength(0)];
        for(int r = 0; r < bidimensionalArray.GetLength(0); r++) {
            // In each row, init the major in  0;
            int majorInRow = 0;
            for(int c = 0; c < bidimensionalArray.GetLength(1); c++) {
                // if the bidimensional in current row and column, is major than major in the current row
                if(bidimensionalArray[r,c] > majorInRow) {
                    // The new major for this row, will be the actual index using [row, column]
                    majorInRow = bidimensionalArray[r,c];
                }
            }
            // Add the major of this row to array that contains the major per row
            majorPerRow[r] = majorInRow;
        }

        return majorPerRow;
    }   

}