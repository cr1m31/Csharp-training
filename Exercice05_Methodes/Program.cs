

static void DisplayMachineState(double temperature) {
    Console.WriteLine($"Température : {temperature} °C");
}

DisplayMachineState(25.0);
DisplayMachineState(72.0);

static double ConvertCelsiusToFahrenheit(double celsius) {
    return celsius * 9.0 / 5.0 + 32.0;
}

double result = ConvertCelsiusToFahrenheit(20);

Console.WriteLine(result);

static bool NormalTemperature(double temperature) {
    if (temperature >= 10 && temperature <= 80) {
        return true;
    } else {
        return false;
    }
}

Console.WriteLine(NormalTemperature(25));
Console.WriteLine(NormalTemperature(80));
Console.WriteLine(NormalTemperature(95));
Console.WriteLine(NormalTemperature(5));
