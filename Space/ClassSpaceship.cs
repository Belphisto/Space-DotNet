using System;
using static System.Console;

namespace Space
{
    internal class Spaceship : SpaceObject
    {
       private double _speed {get;set;}
       private double _engineBonus;
       private double _penalty_weight;
       private double _weight;
       private string _captain;
       private string _appointment;
       private DateTime _launchDate;

       internal Spaceship(string type, string name, string captain, string appointment, double speed, double engin, double penalty, double weight, DateTime launch)
       : base(type, name)
       {
            this._speed = speed;
            this._engineBonus = engin;
            this._penalty_weight = penalty;
            this._weight = weight;
            this._captain = captain;
            this._appointment = appointment;
       }
       internal override double GetSpeed() => _speed*(_engineBonus - _penalty_weight);
       internal override ulong GetDistance() => (ulong)(_speed*(DateTime.Now - _launchDate).TotalSeconds);
       internal override void PrintObject()
       {
            WriteLine($"    Space object type: {this._type}, name {this._name}");
            WriteLine($"    Crew leader: {this._captain}");
            WriteLine($"    Object characteristics:");
            WriteLine($"        Airspeed: {this._speed} km/s");
            WriteLine($"        Engine speed increase factor: {this._engineBonus}");
            WriteLine($"        Ship weight: {this._weight} tons");
            WriteLine($"    Purpose of the ship: {this._appointment}");
       }

    }
}