using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Bridge.Implementación
{
    /// <summary>
    /// La interfaz de implementación declara metodos comunes a todas las clases concretas de implementación.
    /// No tiene porque coincidir con la interfaz de la abstraccion. De hecho, las dos interfaces pueden ser copmletamente diferentes
    /// Normalmente, la interfaz de implemnetación unicamnete proporciona operaciones primitivas, 
    /// mientras que la abstraccion define operaciones de mas alto nivel con base en las primitivas.
    /// </summary>
    public interface IDevice
    {
        bool IsEnabled();
        bool Enabled();

        bool Disabled();

        int GetVolume();
        bool SetVolume(int volumen);
        int GetChannel();

        bool SetChannel(int channel);   
        
    }
}
