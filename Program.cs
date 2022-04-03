
namespace Planets
{
    class Program
    {

        static void Main(string[] args)
        {
            //Indtastning af data fra planterne
            Planet mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 3.7, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet venus = new Planet("Venus", 4.87, 12.104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            Planet earth = new Planet("Earth", 5.97, 12.756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet jupiter = new Planet("Jupiter", 1898, 142.984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet saturn = new Planet("Saturn", 568, 120.536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
            Planet uranus = new Planet("Uranus", 86.8, 51.118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
            Planet neptune = new Planet("Neptune", 102, 49.528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

            //Liste med planeternes navne
            List<Planet> planets = new List<Planet>();

            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            planets.Insert(1, venus);
            planets.Remove(pluto);
            planets.Insert(8, pluto);
            Console.WriteLine(planets.Count());

            string path = @"C:\prøve\text.txt";

            //Udskriver planeternes navne
            foreach (Planet planet in planets)
            {
                File.AppendAllText(path, planet.name + " " + planet.moon_temperature + "\n");
                Console.WriteLine(planet.name);
            }



            //Liste over temparturen på planeterne
            List<Planet> temperature = new List<Planet>();

            //Tjekker om planeterne er under 0 grader
            foreach (Planet planet in planets)
            {
                if (planet.moon_temperature < 0)
                {
                    temperature.Add(planet);
                    
                }
            }
            Console.WriteLine();
            //Udskriver platerne med en temperatur på under 0 grader
            foreach (Planet planet in temperature)
            {
                Console.WriteLine(planet.name);
            }

            //Liste over diameteren på planeterne
            List<Planet> diameter = new List<Planet>();

            //Tjekker hvilke planeter der har en diameter mellem 1000 - 5000
            foreach (Planet planet in planets)
            {
                if (planet.diameter > 1000 && planet.diameter < 5000)
                {
                    diameter.Add(planet);

                }
            }
            Console.WriteLine("....");
            //Udskriver planterne med den rette diameter
            foreach (Planet planet in diameter)
            {
                Console.WriteLine(planet.name);
            }

            //Sletter alle planterne i listen
            planets.Clear();

            Console.WriteLine("....");
            //Udskriver planeternes navn igen
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.name);
            }
            
        }
    }
}