class Program
{
    static void Main()
    {
        // Console.WriteLine("Bonjour tout le monde");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 123;

        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 45;

        Planet earth = new Planet();
        earth._name = "Earth";
        earth._diameter = 240;

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem._solarSystem.Add(earth);
    }
}