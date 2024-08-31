

namespace Estructural.Facade
{
    /// <summary>
    /// Se crea la clase fachara para esconder la complejdiad del framework tras una interfaz simple.
    /// Es una solucon de equilibrio entre funcionalidad y simplicidad.
    /// </summary>
    public class VideoConverterFacade
    {
        public Estructural.Facade.Framework.File Convert(string filename, string format)
        {
            var file = new Estructural.Facade.Framework.VideoFile();
            var destinationCode = new Estructural.Facade.Framework.CodecFactory();
            var sourceCode = new object();
            if(format == "mp4")
            {
                sourceCode = new Estructural.Facade.Framework.MPEG4CompressionCodec();
            }else
            {
                sourceCode = new Estructural.Facade.Framework.OggCompressionCodec();
            }

            var result = new Estructural.Facade.Framework.AudioMixer(file, destinationCode,sourceCode);

            return new Estructural.Facade.Framework.File(filename,format);

        }
    }
}
