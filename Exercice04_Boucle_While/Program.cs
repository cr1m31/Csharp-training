/*
int pressure = 0;

while (pressure < 5) {
    Console.WriteLine($"Pression actuelle : {pressure}");
    pressure++;
}

Console.WriteLine("Pression cible atteinte.");*/


bool machineStarted = false;
int attempts = 0;

while (!machineStarted && attempts < 5) {
    Console.WriteLine("Tentatives : " + attempts);
    attempts++;
    if (attempts >= 3) {
        machineStarted = true;
        Console.WriteLine("Machine démarée avec succès.");
    }
}
