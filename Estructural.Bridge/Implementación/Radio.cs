using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructural.Bridge.Implementación
{
    internal class Radio : IDevice
    {
        private int _channel { get; set; }
        private int _volume { get; set; }

        private bool isEnabled { get; set; }
        public bool Disabled()
        {
            Console.WriteLine("Apaga la Radio.");
            return true;
        }

        public bool Enabled()
        {
            Console.WriteLine("Enciende la Radio.");
            return true;
        }

        public int GetChannel()
        {
            Console.WriteLine($"Canal en la Radio : {_channel}");
            return _channel;
        }

        public int GetVolume()
        {
            Console.WriteLine($"Volumen en la Radio : {_volume}");
            return _volume;
        }
        public bool IsEnabled()
        {
            Console.WriteLine($"Estado en la Radio : {isEnabled}");
            return isEnabled;
        }

        public bool SetChannel(int channel)
        {
            Console.WriteLine($"Canal elegido : {channel}");
            _channel = channel;
            return true;
        }

        public bool SetVolume(int volumen)
        {
            Console.WriteLine($"Volumen elegido : {volumen}");
            _volume = volumen;
            return true;
        }
    }
}
