namespace Estructural.Composite.Interfaces
{
    /// <summary>
    /// La interfaz componenten declara operaciones comunes para objetos simples y complejos de una composición.
    /// </summary>
    public interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }
}
