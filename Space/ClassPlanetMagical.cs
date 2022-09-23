using System;
using static System.Console;

namespace Space
{
    internal class Magical : Planet
    {
       protected string _kindMagic;
       protected string _element;
       protected int _etherStock;
       protected int _numberMagicalCreatures;

       internal Magical(string name, double w, double d, double p, in string val, int[] c,
            string kind, string elem, int stock, int number)
            : base(name, w, d, p, val, c)
        {
            this._kindMagic = kind;
            this._element = elem;
            this._etherStock = stock;
            this._numberMagicalCreatures = number;
        }
        internal override void PrintPlanet()
        {
            base.PrintPlanet();
            WriteLine("         Additional characteristics of the Magical Planet:");
            WriteLine($"            The planet uses {this._kindMagic} kind of magic");
            WriteLine($"            The main magical element of the planet: {this._element}");
            WriteLine($"            Amount of essential particles: ");
            WriteLine($"            There are {this._numberMagicalCreatures} types of magical creatures on the planet");
        }
    }
}