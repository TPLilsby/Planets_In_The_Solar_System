using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    internal class Planet
    {
        //Definere alle navnene på egenskaberne
        public string name;
        public double mass;
        public double diameter;
        public int density;
        public double gravity;
        public double rotation_period;
        public double length_of_day;
        public double distance_from_sun;
        public double orbital_period;
        public double orbital_velocity;
        public int moon_temperature;
        public int number_of_moons;
        public bool ring_system;
        
        //Gør så man kan få og sætte værdierne til egenskaberne
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Diameter { get; set; }
        public int Density { get; set; }
        public double Gravity { get; set; }
        public double Rotation_period { get; set; }
        public double Length_of_day { get; set; }
        public double Distance_from_sun { get; set; }
        public double Orbital_period { get; set; }
        public double Orbital_velocity { get; set; }
        public int Moon_temperature { get; set; }
        public int Number_of_moons { get; set; }
        public bool Ring_system { get; set; }

        //Føre egenskaberne ind i en Construtor så man kan bruge dem i programmet
        public Planet(string Name, double Mass, double Diameter, 
        int Density, double Gravity, double Rotation_period, 
        double Length_of_day, double Distance_from_sun, double Orbital_period,
        double Orbital_velocity, int Moon_temperature, int Number_of_moons, bool Ring_system)
        {
            name = Name;
            mass = Mass;
            diameter = Diameter;
            density = Density;
            gravity = Gravity;
            rotation_period = Rotation_period;
            length_of_day = Length_of_day;
            distance_from_sun = Distance_from_sun;
            orbital_period = Orbital_period;
            orbital_velocity = Orbital_velocity;
            moon_temperature = Moon_temperature;
            number_of_moons = Number_of_moons;
            ring_system = Ring_system;
        }
    }
}
