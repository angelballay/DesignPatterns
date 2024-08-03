using Creational.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Director
{
    public class Director
    {
        public void ConstructSportCar(ICarBuilder pBuilder)
        {
            pBuilder.Reset();
            pBuilder.SetSeats(2);
            pBuilder.SetTripComputer("DRAGON FORCE ZX1080NT");
            pBuilder.SetGps("GPS 2.0 NTE");
            pBuilder.SetDoors(2);
            pBuilder.SetEngine("Motor v12 4ta gen");
        }

        public void ConstructRegularCar(ICarBuilder pBuilder)
        {
            pBuilder.Reset();
            pBuilder.SetSeats(4);
            pBuilder.SetTripComputer("Roadtrip n20");
            pBuilder.SetDoors(5);
            pBuilder.SetEngine("Motor v6 8va gen");
        }
    }
}
