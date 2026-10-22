
double temperature = 65.0;
bool machineOn = true;
bool detectedError = false;

if (temperature > 80) {
    Console.WriteLine($"Température trop élevée ! {temperature}");
} else if (temperature > 60) {
    Console.WriteLine($"Température élevée. {temperature}");
} else{
    Console.WriteLine($"Température normale. {temperature}");
}

if ( ! machineOn) {
    Console.WriteLine("Machine arrêtée.");
}
if (detectedError) {
    Console.WriteLine("Défaut détecté !");
}
if (temperature > 80) {
    Console.WriteLine($"Alerte température ! {temperature}");
}
if (machineOn && ! detectedError && temperature < 80) {
    Console.WriteLine("Machine en fonctionnement normal.");
}
