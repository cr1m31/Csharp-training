/*  Écris une boucle for qui affiche :
    Traitement de la pièce 1
    Traitement de la pièce 2
    Traitement de la pièce 3
    ...
    Traitement de la pièce 10
    Production terminée.

    Bonus : affiche uniquement les numéros pairs entre 0 et 20.
*/

for (int i = 0; i < 20; i++) {
    // no zero part so part 1 = element 0 so i + 1 = part 1 etc.
    int iPlusOne = i + 1;
    if (iPlusOne % 2 == 0) {
            Console.WriteLine($"Traitement de la pièce {iPlusOne}");
    }



}

Console.WriteLine("Production terminée.");

// modulo __ 10 % 2 == 0 __ if 10 divided by two has a remainder of zero then it is an even number
Console.WriteLine("modulo test: " + (12 % 2 == 0).ToString());
