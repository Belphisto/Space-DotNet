using System;
using static System.Console;

namespace Space
{
    internal class Technoplanet : Planet
    {
       protected double _power;
       protected string _luminosityColor;
       protected double _calculationSpeed;
       protected int _numberCores;

       internal Technoplanet(string name, double w, double d, double p, in string val, int[] c,
            double power, string color, double calc, int numberCores)
            : base(name, w, d, p, val, c)
        {
            var random = new Random();
            List<string> Resource = new List<string> {"Latest generation processor", "electric cube", "Hi-tech", "Quantum Computers", "Teleportation"};
            int index = random.Next(Resource.Count);
            this._valuableResource = Resource[index];
            this._power = power;
            this._calculationSpeed = calc;
            this._luminosityColor = color;
            this._numberCores = numberCores;
        }
        internal override void PrintPlanet()
        {
            base.PrintPlanet();
            WriteLine("         Additional characteristics of the Technoplanet:");
            WriteLine($"            Constant power dissipated into space: {this._power}");
            WriteLine($"            Planet luminosity color: {this._luminosityColor}");
            WriteLine($"            Number of cores inside the planet: {this._numberCores}");
            WriteLine($"            Computing speed on the planet: {this._calculationSpeed * this._numberCores}");
        }
        
    }
}