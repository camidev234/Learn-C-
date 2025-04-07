namespace MyTestApp.clases;

public class TestConcurrency {

    /*
        Concurrency allows do things in background.
        Every function that return type will be Task or Task<T>, when invoked
        starts the execution, it doesn't matter if the call does not have await 
        because the function is a task.

        use await only when we need the result, otherwise the function might does not finish.
    */


    public static async Task FirstFun() {
        Console.WriteLine("FirstFun started...");
        await Task.Delay(2000);
        Console.WriteLine("FirstFun finished.");
    }

    public static async Task SecondFun() {
        Console.WriteLine("SecondFun started...");
        await Task.Delay(4000);
        Console.WriteLine("SecondFun finished.");
    }
}