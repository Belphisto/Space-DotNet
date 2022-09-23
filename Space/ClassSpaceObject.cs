using System;
using static System.Console;

namespace Space
{
    internal abstract class SpaceObject
    {
        protected string _type {get;set;} = "SpaceObject";
        protected string _name {get;set;} = "NoName";
        internal SpaceObject (string type, string name) {_type = type; _name = name;}
       internal abstract ulong GetDistance();
       internal abstract double GetSpeed();
       internal virtual string GetName() => this._name;
       internal abstract void PrintObject();
        /*{
        WriteLine($"The  {_type} {_name} has flown a distance of {this.GetDistance()} km since launch. ");
        WriteLine($"Speed is {this.GetSpeed()} km/s");
        }*/
    }
}

