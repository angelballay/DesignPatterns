using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Prototype.ConcretePrototype
{
    /// <summary>
    /// Prototypo completo, el metodode de clonacion cre aun nuevo objeto y lo pasa al constructor. 
    /// Hasta que el construro termina, tiene una referencia a un nuevo clona.
    /// De este metodo nadite tiene accesion a un clon a medio temrinar. 
    /// Esto garantiza la consistencia del resutaldo de la clonacion.
    /// </summary>
    internal class Rectangle : Shape
    {
        public int width;
        public int height;

        public Rectangle()
        {

        }
        public Rectangle(Rectangle source) : base(source)
        {
            //Para copiar campos privados definidos en la clase padre es necesario una llamada al consutrctor padre.
            this.width = source.width;
            this.height = source.height;
        }
        
        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
