

Machine convoyeur = new Machine("Convoyeur 01");
convoyeur.Start();
Console.WriteLine(convoyeur.Active);

Sensor temperature = new Sensor("Senseur01", 42.5);
temperature.DisplayValues();
Sensor pressure = new Sensor("Senseur02", 3.2);
pressure.DisplayValues();

Sensor alarm = new Sensor("Senseur03", 60);
Console.WriteLine($"Valeur élevée : {alarm.AlarmMethod()}");

class Machine {
    public string Name;
    public bool Active;


    public Machine(string name) {
        Name = name;
        Active = false;
    }

    public void Start() {
        Active = true;
        Console.WriteLine($"{Name} démarrée.");
    }
}

class Sensor {
    // class fields
    public string Name;
    public double Value;

    // constructor
    public Sensor(string name, double value) {
        Name = name;
        Value = value;
    }

    public void DisplayValues() {
        Console.WriteLine($"{Name} {Value}");
    }

    public bool AlarmMethod() {
        if (Value > 50) {
            return true;
        } else {
            return false;
        }
    }
}
