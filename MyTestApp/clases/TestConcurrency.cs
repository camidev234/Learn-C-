namespace MyTestApp.clases;

public class TestConcurrency {
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