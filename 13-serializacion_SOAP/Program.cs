using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SerializacionSOAP
{
    class Program
    {
        public static void Main ()
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) Crear y serializar auto, 2) Leer auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if(opcion == 1)
            {
                //Creamos el objeto
                string modelo = "";
                double costo = 0.0;

                Console.WriteLine("Escriba el modelo: ");
                modelo = Console.ReadLine();

                Console.WriteLine("Escriba el precio del automovil: ");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto miAuto = new CAuto(modelo, costo);

                Console.WriteLine("Automovil a serializar");
                miAuto.MostrarInformacion();

                //Empezamos la serializacion
                Console.WriteLine("----Serializacion----");

                //Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                //Creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formateador.Serialize(miStream, miAuto);

                //Cerramos el Stream
                miStream.Close();
            }

            if(opcion == 2)
            {
                //Deserealizamos el objeto
                Console.WriteLine("----Deserializacion----");

                //Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();
            
                //Creamos el Stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserializamos
                CAuto miAuto = (CAuto) formateador.Deserialize(miStream);

                //Cerramos el stream
                miStream.Close();

                //Utilizamos el objeto deserealizado
                Console.WriteLine("El objeto deserealizado es: ");
                miAuto.MostrarInformacion();
            }
        }
    }   
}