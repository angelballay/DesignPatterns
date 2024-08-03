
namespace Creational.Builder.Interfaces
{
    /// <summary>
    /// La interfaz constructora especifica metodos para crear las distintas partes de los objetos del producto.
    /// </summary>
   public interface ICarBuilder
    {
        void Reset();
        void SetSeats(int? seats = null);
        void SetEngine(string engine);

        void SetDoors(int? doors = null);

        void SetTripComputer(string tripComputer);
        void SetGps(string Gps);
    }
}
