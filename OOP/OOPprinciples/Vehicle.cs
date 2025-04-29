using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public ushort Year { get; set; }
        public sbyte NumberOfWheels { get; set; }

        public virtual string VehicleType => this.GetType().Name;

        public virtual void Start() => Console.WriteLine($"{VehicleType} is starting...");

        public virtual void Stop() => Console.WriteLine($"{VehicleType} is stopping");
    }
}
