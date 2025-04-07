namespace MyTestApp.clases;

public class Menu {
    public static void ExectuteMenu() {
        try {
            bool showMenu = true;
            while(showMenu) {
                Console.WriteLine("1. Product of two numbers");
                Console.WriteLine("2. Sum of two numbers");
                Console.WriteLine("3. Module of two numbers");
                Console.WriteLine("4. Excercise 1.9.3");
                Console.WriteLine("5. Excercise 1.9.5");
                Console.WriteLine("6. Excercise 1.9.6");
                Console.WriteLine("7. Excercise 1.9.7");
                Console.WriteLine("8. Excercise 2.1.1.3");
                Console.WriteLine("9. Excercise 2.1.1.3");
                Console.WriteLine("10. Excercise 2.2.1.2");
                Console.WriteLine("11. Excercise 2.2.1.3");
                Console.WriteLine("12. Excercise 2.2.1.4");
                Console.WriteLine("13. Excercise 2.2.1.5");
                Console.WriteLine("14. Excercise 2.2.3.1");
                Console.WriteLine("16. Number is prime");
                Console.WriteLine("17. Print square");
                Console.WriteLine("18. Print invert Triangle");
                Console.WriteLine("19. Print partial square");
                Console.WriteLine("20. Print triangle");
                Console.WriteLine("21. Find circle area: ");
                Console.WriteLine("22. Decimal to Binarymand hexadecimal");
                Console.WriteLine("23. Show hexadecimal numbers");
                Console.WriteLine("24. Show rgb to hexadecimal");
                Console.WriteLine("25. Is vocal");
                Console.WriteLine("26. Average of numbers");
                Console.WriteLine("27. Show max number in int array (int[])");
                Console.WriteLine("28. What is the day in year");
                Console.WriteLine("29. Sort random array");
                Console.WriteLine("30. Show bidimensional array");
                Console.WriteLine("31. Major of bidimensional array");
                Console.WriteLine("32. Determinant of 2x2 matrix");
                Console.WriteLine("40. Exit");
                Console.WriteLine("Enter the option you want to use: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if(option == 40) {
                    showMenu = false;
                    Console.WriteLine("exiting of menu..."); 
                    break;
                }
                
                int numberOne = 0;
                int numberTwo = 0;
                if(option == 1 || option == 2 || option == 3) {
                    System.Console.WriteLine("Enter the number one: ");
                    numberOne = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter the number two: ");
                    numberTwo = Convert.ToInt32(Console.ReadLine());
                }

                int result;
                switch(option) {
                    case 1: 
                        result = InitialExcercises.CalculateProduct(numberOne, numberTwo);
                        Console.WriteLine("el producto de los dos numeros es: " + result);
                        break;
                    case 2:
                        result = InitialExcercises.CalculateSum(numberOne, numberTwo);
                        Console.WriteLine("La suma de los dos numeros es: " + result);
                        break;
                    case 3:
                        result = (int)InitialExcercises.CalculateModule(numberOne, numberTwo);
                        Console.WriteLine("El Modulo de los dos numeros es: " + result);
                        break;
                    case 4:
                        /*
                             El usuario tecleará dos números (a y b), y el programa mostrará el resultado 
                            de la operación (a+b)*(a-b) y el resultado de la operación a2-b2. 
                        */
                        System.Console.Write("Enter the (a) number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        System.Console.Write("Enter the (b) number: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int opOne = (a+b)*(a-b);
                        int powerOne = InitialExcercises.Power(a, 2); 
                        int powerTwo = InitialExcercises.Power(b, 2);

                        int opTwo = powerOne - powerTwo; 

                         Console.WriteLine("The result of first operation: " + opOne);
                        Console.WriteLine("The result of second operation: " + opTwo);

                        break;
                    case 5:
                        /*
                            Pedir al usuario un número y mostrar su tabla de multiplicar. Por ejemplo, si el 
                            número es el 3, debería escribirse algo como
                        */

                        Console.Write("Number of the product table: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------------------");
                        InitialExcercises.ShowProductTable(number);
                        Console.WriteLine("----------------------------------");

                        break;
                    case 6:

                        /*
                            Crea un programa que convierta de grados Celsius (centígrados) a Kelvin y a 
                            Fahrenheit: pedirá al usuario la cantidad de grados centígrados y usará las siguiente 
                            tablas de conversión: kelvin = celsius + 273   ;  fahrenheit = celsius x 18 / 10 + 32 
                        */

                        double kelvin, fahrenheit;

                        Console.Write("Enter celcius: ");
                        double celcius = Convert.ToDouble(Console.ReadLine());

                        kelvin = Temperature.CleciusToKelvin(celcius);
                        fahrenheit = Temperature.CelciusToFahrenheit(celcius);

                        Console.WriteLine("Kelvin: " + kelvin);
                        Console.WriteLine("Fahrenheit: " + fahrenheit);
                        break;

                    case 7:
                        /*
                            Pide al usuario una cantidad de "millas" y muestra la equivalencia en metros, 
                            usando: 1 milla = 1609.344 metros
                        */

                        Console.Write("Enter Miles: ");
                        double miles = Convert.ToDouble(Console.ReadLine());
                        double meters = InitialExcercises.MiToMt(miles);

                        Console.WriteLine(miles +  "miles to meters are " + Convert.ToInt32(meters) + "m");

                        break;

                    case 8:
                        Console.Write("Enter Number: ");
                        int numberToMultOf = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Number is mult of: ");
                        int multOf = Convert.ToInt32(Console.ReadLine());

                        bool resultMultOf = InitialExcercises.MultOf(numberToMultOf, multOf);

                        Console.WriteLine(
                            resultMultOf ? "The number " + numberToMultOf + " is mult of " + multOf : 
                            "The number " + numberToMultOf + " is not mult of " + multOf
                        );

                        break;

                    case 9:
                        /*
                            Crear un programa que pida al usuario tres números reales y muestre cuál es 
                            el mayor de los tres. 
                        */
                        Console.Write("Number One: ");
                        int numOne = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Number Two: ");
                        int numTwo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Number Three: ");
                        int numThree = Convert.ToInt32(Console.ReadLine());

                        int major = InitialExcercises.MajorOfThree(numOne, numTwo, numThree);

                        Console.WriteLine("The major is: {0}", major);

                        break;

                    case 10:

                        Console.Write("Enter the final number in loop: ");
                        int finalNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------");
                        InitialExcercises.PrintNumbersInRange(finalNumber);
                        Console.WriteLine("------------------");

                        break;
                    case 11:
                        Console.WriteLine("------------------");
                        InitialExcercises.PrintPairNumbers();
                        Console.WriteLine("------------------");
                        break;

                    case 12:
                        Console.Write("Enter the number to calculate digits: ");
                        int numberDigit = Convert.ToInt32(Console.ReadLine());
                        int resultDigits = InitialExcercises.CountDigits(numberDigit);
                        if(resultDigits > 0) {
                            Console.WriteLine("The number {0} has {1} digits", numberDigit, resultDigits);
                        }

                        break;
                    case 13:
                        InitialExcercises.RandomGame();
                        break;
                    case 14:
                        InitialExcercises.PrintNumbersDecrement();
                        break;
                    case 15:
                        InitialExcercises.TestFor();
                        break;
                    case 16:
                        Console.Write("Enter the number to find if is prime or not: ");
                        int numberToFind = Convert.ToInt32(Console.ReadLine());
                        bool resultIsPrime = CustomMath.IsPrime(numberToFind);
                        if(resultIsPrime) {
                            Console.WriteLine("Number {0} is prime", numberToFind);
                        }else {
                            Console.WriteLine("Number {0} is not prime", numberToFind);
                        }
                        break;
                    case 17:
                        Console.Write("Enter the number of rows: ");
                        int rows = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the number fo columns: ");
                        int columns = Convert.ToInt32(Console.ReadLine());
                        InitialExcercises.PrintSquare(rows, columns);
                        break;
                    case 18:
                        Console.Write("Enter the number of rows: ");
                        int rowsTriangle = Convert.ToInt32(Console.ReadLine());
                        InitialExcercises.PrintInvertTriangle(rowsTriangle);
                        break;
                    case 19:
                        Console.Write("Enter the number of rows: ");
                        int rowsSquare = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the number fo columns: ");
                        int columnsSquare = Convert.ToInt32(Console.ReadLine());
                        InitialExcercises.PrintPartialSquare(rowsSquare, columnsSquare);
                        break;
                    case 20:
                        Console.Write("Enter the number of rows: ");
                        int rowsTri = Convert.ToInt32(Console.ReadLine());
                        InitialExcercises.PrintTriangle(rowsTri);
                        break;
                    case 21:
                        Console.Write("Enter radio in m2: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        double area = CustomMath.CircleArea(radio);
                        Console.WriteLine("The area of the cirlce is " + area + "m2");
                        break;
                    case 22:
                        int numberToConvert = 1;
                        do  {
                            Console.Write("Enter the number to converto from decimal to binary and hexadecimal: ");
                            numberToConvert = Convert.ToInt32(Console.ReadLine());
                            string toBinary = CustomMath.ToBinary(numberToConvert);
                            string toHexadecimal = CustomMath.ToHexadecimal(numberToConvert);
                            Console.WriteLine("The number {0} in binary is: {1}", numberToConvert, toBinary);
                            Console.WriteLine("The number {0} in hexadecimal is: {1}", numberToConvert, toHexadecimal);
                        } while(numberToConvert != 0);
                        break;
                    case 23:
                        InitialExcercises.ShowHexadecimalNumbers();
                        break;
                    case 24:
                        Console.Write("Enter the red value: ");
                        int red = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the green value: ");
                        int green = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the blue value: ");
                        int blue = Convert.ToInt32(Console.ReadLine());
                        string colorInHexadecimal = InitialExcercises.RgbToHexadecimal(red, green, blue);
                        Console.WriteLine("The color in hx is: {0}", colorInHexadecimal); 
                        break;
                    case 25:
                        char letter;
                        letter = Convert.ToChar(Console.ReadLine());
                        bool isVocal = InitialExcercises.IsVocal(letter);
                        if(isVocal)
                        {
                            Console.WriteLine("The letter {0} is vocal", letter);
                        } else
                        {
                            Console.WriteLine("The letter {0} isn't vocal", letter);
                        }
                        break;
                    case 26:
                        int[] arrayResult = EnterArrayOfNumbers();

                        // Calculate the average

                        double averageUsingArray = CustomMath.Average(arrayResult);

                        Console.WriteLine("The average of the numbers is {0}: ", averageUsingArray);
                        break;
                    case 27:
                        int[] arrayOfInts = EnterArrayOfNumbers();

                        int maxNumber = InitialExcercises.MaxNumber(arrayOfInts);

                        Console.WriteLine("The max number is: {0}", maxNumber);


                        break;
                    case 28:
                        Console.Write("Enter the month: ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the day: ");
                        int dayOfMonth = Convert.ToInt32(Console.ReadLine());

                        int dayOfYear = InitialExcercises.FindDayOfYear(month, dayOfMonth);

                        if(dayOfYear == 0)
                        {
                            Console.WriteLine("An error ocurred, please check the values that you have entered.");
                        } else
                        {
                            Console.WriteLine("The day {0} is the day {1} in the year", dayOfMonth, dayOfYear);
                        }



                        break;
                     case 29:
                        Random randomInstance = new Random();
                        int randomLength = randomInstance.Next(1, 19);
                        
                        // 

                        int[] arrayGenerated = new int[randomLength];
                        for(int idx = 0; idx < randomLength; idx++)
                        {
                            int randomNumber = randomInstance.Next(0, 999);
                            arrayGenerated[idx] = randomNumber;
                        }


                        Console.WriteLine("Start array: ");
                        ShowArrayToString(arrayGenerated);
                        Console.WriteLine();

                        int[] sortedArray = InitialExcercises.SortArray(arrayGenerated);

                        
                        Console.WriteLine("Sorted Array:");
                        ShowArrayToString(sortedArray);
                        Console.WriteLine();

                        break;
                    case 30:
                        int[,] bidimensionalArrayGenerated = FillBidimensionalArray();
                        InitialExcercises.ShowBidimensionalArray(bidimensionalArrayGenerated);
                        break;
                    case 31:
                        int[,] bidimensionalArrayGen;
                        while(true) {
                            try {
                                Console.Write("Enter the number of rows: ");
                                int rowsIn2d = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the number of columns: ");
                                int colsIn2d = Convert.ToInt32(Console.ReadLine());
                                bidimensionalArrayGen = FillManualBidimensional(rowsIn2d, colsIn2d);
                                int[] majorPerRow = InitialExcercises.MajorPerRow(bidimensionalArrayGen);
                                int row = 1;
                                foreach(int majorNumber in majorPerRow) {
                                    Console.WriteLine($"The major in row {row} is {majorNumber}");
                                    row++;
                                }
                                break;
                            } catch(FormatException) {
                                Console.WriteLine("The value is not a number, please retry");
                            }
                        }
                        break;
                    case 32:
                        int[,] matrix2x2;
                        while(true) {
                            try {
                                matrix2x2 = FillManualBidimensional(2, 2);
                                int determinant = InitialExcercises.Determinant2x2(matrix2x2);
                                Console.WriteLine("The determinant is {0}", determinant);
                                break;
                            } catch(FormatException) {
                                Console.WriteLine("The value is not a number, please retry");
                            } catch(ArgumentException exc) {
                                Console.WriteLine("Error:" + exc.Message);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        } catch(FormatException) {
            Console.WriteLine("The option must be a invalid int number");
        }
    }

    public static int[,] FillManualBidimensional(int rows, int cols) {

        int[,] bidimensionalArray = new int[rows,cols];

        for(int r = 0; r < bidimensionalArray.GetLength(0); r++) {
            for(int c = 0; c < bidimensionalArray.GetLength(1); c++) {
                Console.Write($"Enter the number {c+1} to row {r+1}: ");
                bidimensionalArray[r,c] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return bidimensionalArray;
    }

    public static int[] EnterArrayOfNumbers() {
        Console.Write("Enter the number of elements: ");
        int arrayLen = Convert.ToInt32(Console.ReadLine());
        int[] numbersInArray = new int[arrayLen];
        int indexToAdd = 0;
        // 3
        while (indexToAdd < arrayLen)
        {
            Console.Write("Enter the number {0}: ", indexToAdd + 1);
            int numberToAdd = Convert.ToInt32(Console.ReadLine());
            numbersInArray[indexToAdd] = numberToAdd;
            indexToAdd++;
        }

        return numbersInArray;
    }

    public static int[,] FillBidimensionalArray() {
        Random random = new Random();
        int rows = random.Next(2, 10);
        int cols = random.Next(1, 10);
        
        int[,] bidimensionalArray = new int[rows, cols];

        for(int r = 0; r < bidimensionalArray.GetLength(0); r++) {
            for(int c = 0; c < bidimensionalArray.GetLength(1); c++) {
                bidimensionalArray[r,c] = random.Next(0, 999);
            }
        }

        return bidimensionalArray;

    }

    public static void ShowArrayToString(int[] array) {
        Console.Write("[");
        for(int i = 0; i<array.Length; i++)
        {
            Console.Write(array[i]);
            if(i != array.Length -1)
            {
                Console.Write(',');
            }
        }
        Console.Write("]");
    }
}