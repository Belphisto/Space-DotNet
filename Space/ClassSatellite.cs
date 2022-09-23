using System;
using static System.Console;

namespace Space
{
    internal class Satellite : SpaceObject
    {
        private DateTime _dateBirth;
        private double _speed;
        private string _company;
        private DateTime _launchDate;

        internal Satellite(string type, string name, DateTime date, double speed, string company, DateTime launch)
        : base(type, name)
        {
            this._dateBirth = date;
            this._speed = speed;
            this._company = company;
            this._launchDate = launch;
        }
        internal override double GetSpeed() => this._speed;
        internal override ulong GetDistance() => (ulong)(_speed*(DateTime.Now - _launchDate).TotalSeconds);

        internal override void PrintObject()
        {
            WriteLine($"    Space object type: {this._type}, name {this._name}");
            WriteLine($"    Development company: {this._company}");
            WriteLine($"    date of creation: {this._dateBirth}");
            WriteLine($"    Launch date: {this._launchDate}");
            WriteLine($"    Flight speed: {this._speed}");
        }
    }
}