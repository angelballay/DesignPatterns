using Estructural.Bridge.Implementación;

namespace Estructural.Bridge.Abstracción
{
    /// <summary>
    /// La abstraccion define la interfaz para la parte de un "control" de las dos jerarquias de clase. 
    /// Mantiene una referencia a un objeto de la jerarquia de implenetnacion y delega todo el trabajo real a este objeto.
    /// </summary>
    public class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }


        public void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disabled();
            }
            else
            {
                _device.Enabled();
            }
        }

        public void VolumeDown()
        {
            if (_device.GetVolume() > 0)
            {
                _device.SetVolume(_device.GetVolume() - 10);
            }
        }

        public void VolumeUp()
        {
            if (_device.GetVolume() < 100)
            {
                _device.SetVolume(_device.GetVolume() + 10);
            }
        }

        public void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
        }



    }
}
