using Creational.Builder.Interfaces;
using Creational.Builder.Products;

namespace Creational.Builder.Builders
{
    public class CarManualBuilder : ICarBuilder
    {
        private Manual _manual;
        public CarManualBuilder() { 
            this.Reset();
        }
        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetDoors(int? doors = null)
        {
            _manual.AddChapter($"El coche tendra {doors} puertas y se abriran con manijita");
        }

        public void SetEngine(string engine)
        {
            _manual.AddChapter($"El coche tendra el motor {engine} que es lo maximo tio.");
        }

        public void SetGps(string Gps)
        {
            _manual.AddChapter($"El coche cuenta con GPS {Gps}");
        }

        public void SetSeats(int? seats = null)
        {
            _manual.AddChapter($"El coche cuenta con {seats} butacas comodas reclinables y con cinturon de seguridad.");
        }

        public void SetTripComputer(string tripComputer)
        {
            _manual.AddChapter($"El coche cuenta con la computadora a bordo modelo {tripComputer}");
        }

        public Manual GetProduct()
        {
            Manual manual = _manual;
            this.Reset();
            return manual;
        }
    }
}
