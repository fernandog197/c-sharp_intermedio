using System.IO;

namespace Archivos
{
    class Program
    {
        public static void Main ()
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) Crear un vehiculo 2)Leer vehiculo");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if(opcion == 1)
            {
                //Creamos el objeto CAuto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Por favor escriba el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Por favor escriba el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto miAuto = new CAuto(modelo, costo);

                //Variables extra
                int numeroDeLaSuerte = 5;
                bool acceso = false;
                byte conteo = 120;

                //Creamos el stream
                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                //Creamos el writer
                BinaryWriter writer = new BinaryWriter(fs);

                //Pasamos por el writer los atributos del objeto
                writer.Write(miAuto.Modelo);
                writer.Write(miAuto.Costo);

                //Ahora las variables
                writer.Write(numeroDeLaSuerte);
                writer.Write(acceso);
                writer.Write(conteo);

                //Cerramos el stream
                fs.Close();
            }

            if(opcion == 2)
            {
                //Deserealizamos el objeto
                Console.WriteLine("---Deserealizamos---");

                //Creamos Stream
                Stream fs = new FileStream("MiArchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                //Creamos el lector
                BinaryReader lector = new BinaryReader(fs);

                //Leemos en el mismo orden en el que se escribio
                string modelo = "";
                double costo = 0;
                int numero = 0;
                bool acceso = true;
                byte conteo = 0;

                modelo = lector.ReadString();
                costo = lector.ReadDouble();
                CAuto miAuto = new CAuto(modelo, costo);

                numero = lector.ReadInt32();
                acceso = lector.ReadBoolean();
                conteo = lector.ReadByte();

                //Cerramos el Stream
                fs.Close();

                //Mostramos lo extraido
                miAuto.MuestraInformacion();
                Console.WriteLine(numero);
                Console.WriteLine(acceso);
                Console.WriteLine(conteo);
            }
        }
    }
}