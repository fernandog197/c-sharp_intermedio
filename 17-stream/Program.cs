using System.IO;

namespace Stream
{
    class Program
    {
        public static void Main ()
        {
            //Utilizamos long porque los streams trabajan con este tipo de dato
            long cantidad = 0;
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("Datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            //Obtenemos la cantidad
            cantidad = fs.Length;
            Console.WriteLine("El archivo mide {0}", cantidad);
            //Recordar! La unidad de medida es bytes, por endet, el length nos dice cuantos bytes tiene el archivo

            //Leemos byte por byte
            for(n=0; n<cantidad; n++)
            {
                fs.Seek(n, SeekOrigin.Begin);

                valor = fs.ReadByte();

                Console.Write("{0}, ", (char)valor);
            }

            Console.WriteLine("\n------------\n");

            //Leemos en sentido contrario
            for(n=1; n<=cantidad; n++)
            {
                fs.Seek(-n, SeekOrigin.End);

                valor = fs.ReadByte();

                Console.Write("{0}, ", (char)valor);
            }

            Console.WriteLine("\n------------\n");

            fs.Seek(0, SeekOrigin.Begin);

            //Leer sin conocer la longitud
            while((valor = fs.ReadByte()) > 0)
            {
                Console.Write("{0}, ", (char)valor);
            }

            Console.WriteLine("\n------------\n");

            fs.Close();
        }
    }
}