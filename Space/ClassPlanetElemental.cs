using System;
using static System.Console;

namespace Space
{
    internal class Elemental : Planet
    {
       protected string _element;
       protected List<string> _flora;
       protected List<string> _fauna;
       protected string _weather;

       internal Elemental(string name, double w, double d, double p, in string val, int[] c,
            string elem, string wether, List<string> flora, List<string> fauna)
            : base(name, w, d, p, val, c)
       {
            this._element = elem;
            this._weather = wether;
            this._fauna = fauna;
            this._flora = flora;
       }
        internal override void PrintPlanet()
        {
            base.PrintPlanet();
            WriteLine("         Additional characteristics of the Element Planet:");
            WriteLine($"            The planet is made up of the element: {this._element}");
            WriteLine($"            The weather on the planet is always: {this._weather} ");
            Write($"            Flora representatives: ");
            foreach (var temp in _flora)
            {
                Write($"{temp}, ");
            }
            WriteLine();
            Write($"            Fauna representatives: ");
            foreach (var temp in _fauna)
            {
                Write($"{temp}, ");
            }
            WriteLine();
        }
    }
}