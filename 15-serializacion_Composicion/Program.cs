using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SerializacionComposicion
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
                int cilindros = 0;
                int hp = 0;

                Console.WriteLine("Por favor escriba el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Por favor escriba el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                Console.WriteLine("Ingrese los cilindros del vehiculo");
                valor = Console.ReadLine();
                cilindros = Convert.ToInt32(valor);

                Console.WriteLine("Por ingrese el hp del vehiculo");
                valor = Console.ReadLine();
                hp = Convert.ToInt32(valor);

                CAuto miauto = new CAuto();
                CMotor miMotor = new CMotor();

                miMotor.Cilindros = cilindros;
                miMotor.Hp = hp;

                miauto.Modelo = modelo;
                miauto.Costo = costo;
                miauto.Motor = miMotor;

                Console.WriteLine("Auto a serializar");
                miauto.MuestraInformacion();

                //Empezamos la serializacion
                Console.WriteLine("---Serializamos---");

                //Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                //Creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos
                formateador.Serialize(miStream, miauto);

                //Cerramos el stream
                miStream.Close();
            }

            if(opcion == 2)
            {
                //Deserializamos el objeto
                Console.WriteLine("---Deserealizamos---");

                //Seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                //Creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserealizamos
                CAuto miAuto = (CAuto) formateador.Deserialize(miStream);

                //Cerramos el stream
                miStream.Close();

                //Mostramos el objeto deserealizado
                Console.WriteLine("El auto deserealizado es: ");
                miAuto.MuestraInformacion();
            }
        }
    }
}