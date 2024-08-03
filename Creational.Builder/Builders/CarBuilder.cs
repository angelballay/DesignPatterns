using Creational.Builder.Interfaces;
using Creational.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Builders
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            _car = new Car();
        }

        public void SetDoors(int? doors = null)
        {
            _car.Doors = doors != null ? doors.Value : 2;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetGps(string Gps)
        {
            _car.Gps = Gps;
        }

        public void SetSeats(int? seats = null)
        {
            _car.Seats = seats != null ? seats.Value : 4;
        }

        public void SetTripComputer(string tripComputer)
        {
            _car.TriperComputer = tripComputer;
        }

        public Car GetProduct()
        {
            Car product = _car;
            this.Reset();
            return product;
        }
    }
}
