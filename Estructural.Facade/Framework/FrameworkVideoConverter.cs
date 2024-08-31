using Estructural.Facade.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Estructural.Facade.Framework
{

    //Estas son algunas de las clases de un framework de conversion de video de un tercero.
    //No controlamos ese codigo, por lo que no podemos simplificarlo.
    public class FrameworkVideoConverter
    {
     

    }
    
    public class File
    {
        public string Name { get; set; }
        public string Format {get; set; }  

        public File(string args1, string args2)
        {
            this.Name = args1;
            this.Format = args2;
        }

        public void Save()
        {
            Console.WriteLine("Se guarda el archivo"+ this.Name+"."+this.Format);
        }
    }
    public class VideoFile
    {
        public VideoFile() {
            Console.WriteLine("Se instancia VideoFile");
        }
    }

    public class OggCompressionCodec
    {
        public OggCompressionCodec()
        {
            Console.WriteLine("Se instancia OggCompressionCodec");
        }
    }

    public class MPEG4CompressionCodec
    {
        public MPEG4CompressionCodec()
        {
            Console.WriteLine("Se instancia MPEG4CompressionCodec");
        }
    }

    public class CodecFactory
    {
        public CodecFactory()
        {
            Console.WriteLine("Se instancia CodecFactory");
        }
    }

    public class BitrateReader
    {
        public BitrateReader()
        {
            Console.WriteLine("Se instancia BitrateReader");
        }
    }


    public class AudioMixer
    {

        public AudioMixer(dynamic file, dynamic code, dynamic buffer )
        {
            Console.WriteLine("Se instancia AudioMixer");
        }
    }
}
