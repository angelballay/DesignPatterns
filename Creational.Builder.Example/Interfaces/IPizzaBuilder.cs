
namespace Creational.Builder.Example.Interfaces
{
    public interface IPizzaBuilder
    {
        void Reset();
        void SetCheeses(string[] cheeses);
        void SetSlices(int slices);

        void SetSalami(bool salami);
        void SetChicken(bool chicken);
        void SetSauce(bool sauce);
        void SetTomato(bool tomato);    
        void SetSilantro(bool silantro);
        void SetEggs(bool eggs);    
        void SetName(string name);
        void SetHam(bool ham);


    }
}
