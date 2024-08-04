using Estructural.Bridge.Implementación;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Bridge.Abstracción
{
    /// <summary>
    /// Puedes extender clases de la jerarquita de abstraccipón independientemente de las clases de dispositivo.
    /// </summary>
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void Muted()
        {
            _device.SetVolume(0);
        }
    }
}
