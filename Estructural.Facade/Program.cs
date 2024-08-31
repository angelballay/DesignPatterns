using System.Security.Cryptography.X509Certificates;

namespace Estructural.Facade
{
    internal class Program
    {
        /// <summary>
        /// Las clases Aplicación, en este caso Main, no depdenden de un millon de clasese porpocionadas por el complejo framework
        /// Ademas, si decides cambiar los frameworks, solo tendras  de volv a escribir la clase fachada.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Inicio:
            Console.WriteLine("Ingrese el formato al cual quiere convertir el archivo");

            string format = Console.ReadLine();

            if(format == "mp4")
            {
                format = "mp4";
            }
            else
            {
                format = "ogg";
            }


            VideoConverterFacade converter = new VideoConverterFacade();

            var mp4 = converter.Convert("ArchivoDeVideoGracioso", format);
            Console.WriteLine("Se conviernte el archivo a " + format);
            mp4.Save();


            Console.WriteLine("Desea convertir otro archivo? presione 1, 0 para salir");
            try
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (value > 0)
                {
                    goto Inicio;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            

           

        }
    }
}
