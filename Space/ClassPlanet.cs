using System;
using static System.Console;

namespace Space
{
    internal class Planet
    {
        protected string _name {get; set;}
        protected double _weight {get; set;}
        protected double _diameter {get; set;}
        protected double _period {get; set;}
        protected string _valuableResource {get;set;}
        protected int[] _coordinate = new int[3];
        protected StarSystem? _mainStar {get;set;}

        internal string GetName() => this._name;


        internal Planet(string name, double w, double d, double p, string val, int[] c)
        {
            this._name = name;
            this._weight = w;
            this._diameter = d;
            this._period = p;
            this._valuableResource = val;
            this._coordinate = c;
            _mainStar = null;
        }
        internal virtual void PrintPlanet()
        {
            WriteLine($"Planet {this._name}:");
            WriteLine($"    It is located at a distance x = {this._coordinate[0]}, y = {this._coordinate[1]}, z = {this._coordinate[2]} from the center of the star {this._mainStar} system");
            WriteLine($"    Diameter of the planet {this._diameter} space units");
            WriteLine($"    Weight of the planet {this._weight} space units");
            WriteLine($"    Orbital period around a star is {this._period} days");
            WriteLine($"    Useful resource: {this._valuableResource}");
        }

        internal bool CheckAddToStar(StarSystem star)
        {
            if (this._mainStar == null)
            {
                this._mainStar = star;
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static double GetDistBetwPlanets (Planet planet1, Planet planet2)
        {
            double distance = Math.Sqrt((planet2._coordinate[0] - planet1._coordinate[0])^2+(planet2._coordinate[1]
             - planet1._coordinate[1])^2+(planet2._coordinate[2] - planet1._coordinate[2])^2);
            return distance;
        }
        
    }
}