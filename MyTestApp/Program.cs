using MyTestApp.clases;

namespace MyTestApp;

public class MyTestApp {
    public static void Main() {
        /*
            When you create a variable, you have 3 parts:
            1. Declaration is only declare the name with his type and name
            2. Initialization is assign a value for these variable
            3. After we can use these value in these variable to operations
        
            1. int numberExample;
            2. numberExample = 10;
            3. System.console.writeLine(numberExample + 10);

            however, we can make it in only one step:

            int numberExample = 10;

            and after use the value.

            also, you can declare one or more variables in a line (all variables must be of the same type):

            int primerNumero = 234, segundoNumero = 567; 

            --------------------------------------------------------

            When we want to print a message using these variables, we can do it in the following way:

            in the following example, the first parameter is the text, however in the text we include the 
            variables using the position in order of the variables passed in the second parameter

            example: primerNumero is in the index 0, segundoNumero is in the index 1 ...

            System.Console.WriteLine("La suma de {0} y {1} es {2}", primerNumero, segundoNumero, suma); 


        */

        // await TestConcurrency.FirstFun();
        // await TestConcurrency.SecondFun();

        // await Task.Delay(5000);

        // Console.WriteLine("Ejecucion total finalizada");

        // Init with menu
        Menu.ExectuteMenu();
    }
}