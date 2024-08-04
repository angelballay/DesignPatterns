using Estructural.Bridge.Abstracción;
using Estructural.Bridge.Implementación;

namespace Estructural.Bridge
{

    /// <summary>
    /// Utilizar el patron Bridge cuando quieras dividir y oraganizar una clase monolitica que tenga muchas variantes de una sola funcionalidad.
    /// ( por ejemplo, si la clase puede trabajar con diversos servidores de bases de datos).
    ///  Conforme mas crece una clase mas dificil resulta entender como funciona y mas timepo se tarde en realizar un cambio.
    /// Cmabiar una de las variacones de funcionalidad puede exigir realizra muchos cambios a toda la clase, lo que a menudo provoca que se cometarn errores
    /// o nose aborden algunos de los efectos colaterales criticos.
    /// 
    /// El patron bridge permite dividir la clase monolitica en varias jerarquitas de clase, 
    /// Despues dpuedes cambiar las clases de cada jerarquita indepedniemente de las clases de las otras.
    /// Esta solucion simplifica el mantenimiento del código y minimiza el riesgo de descomponeter el codigo existente.
    /// 
    /// </summary>
    internal class Program
    {
        /*
         * COMO IMPLEMENTARLO
         * 
         * 1- Identifica las dimensiones ortogonales de tus clases : Abstracicion/plataforma - Dominio/infreaestrucutra - interfaz/implementación
         * 2. Comprueba que operaciones necesita el cliente y definales en la clase base abstraccion.
         * 3- Determina las operaciones diposnibles en todas las plataformas. Declara aquellas que necesite la abstaccion en la interfaz general de implementacion.
         * 4. Crea las calses concretas de implemetancion para todas las plataformasde tu dominio. pero asegurate que todos sigan la interfaz de implenetación.
         * 5. Dentro dfe la clase de abstraccion añade un campo de referencia para el tipo de implenetación.
         *    La abbsytraccion delega la mayor parte del trabajo al objeto de la implementación referenciado en ese campo.
         *    
         * 6. Si tienes muchas variantes de l logica de alto nivel, crea abvbstracciones refinadas para cada variante extendiendo la clase base de abstraccion.
         * 7. El codigo cliente debe pasar un objeto de implentacion al consutrctor de la abstracccion para asocir el uno con el otro.
         * Despues el liente puede ignorar la implentacion y trabajar solo con el objeto de la abstraccion.
         * 
         */

        public static IDevice _device;

        public static RemoteControl RemoteControl { get; private set; }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Que quieres escuchar? RADIO = 1 o TV = 2");
            string? lectura = Console.ReadLine();

            _device = InitDevice(lectura);

            RemoteControl = new RemoteControl(_device);

            RemoteControl.TogglePower();

            RemoteControl.ChannelUp();
            RemoteControl.ChannelDown();
            RemoteControl.ChannelUp();
            RemoteControl.ChannelUp();
            RemoteControl.ChannelUp();
            RemoteControl.ChannelUp();
            RemoteControl.ChannelUp();

            RemoteControl.ChannelDown();

            RemoteControl.VolumeUp();
            RemoteControl.VolumeUp();
            RemoteControl.VolumeUp();
            RemoteControl.VolumeUp();
            RemoteControl.VolumeUp();
            RemoteControl.VolumeUp();
            RemoteControl.VolumeUp();

            RemoteControl.VolumeDown();
            RemoteControl.VolumeDown();

            RemoteControl.TogglePower();

            Console.ReadLine();
        }

        public static IDevice InitDevice(string? lectura)
        {
            IDevice device = new Tv();
            if (lectura != null)
            {
                if (lectura == "1")
                {
                    return new Radio();

                }
            }

            return device;  
        }
    }
}
