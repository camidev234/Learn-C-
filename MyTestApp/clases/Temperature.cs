namespace MyTestApp.clases;

/*
Class with static methods to manage temperatures

*/

public class Temperature {
    public static double CleciusToKelvin(double celcius) {
        double kelvin = celcius + 273.15;
        return kelvin;
    }

    public static double CelciusToFahrenheit(double celcius) {
        double fahrenheit = (celcius * 9/5) + 32;
        return fahrenheit;
    }
}