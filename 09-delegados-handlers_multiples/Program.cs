namespace DelegadosHandlersMultiples
{
    class Program
    {
        public static void Main ()
        {
            Heladera miHeladera = new Heladera(70, -20);
            Random random = new Random();

            //Variables para el multicasting, necesitamos la instancia para poder adicionar o eliminar
            ReservasBajas reservas01 = new ReservasBajas(InformeKilos);
            ReservasBajas reservas02 = new ReservasBajas(Tienda.MandaViveres);

            Descongelado descongelado01 = new Descongelado(InformeGrados);

            //Adicionamos lo handlers
            miHeladera.AdicionarMetodosReservas(reservas01);
            miHeladera.AdicionarMetodosReservas(reservas02);
            miHeladera.AdicionarMetodosDescongelados(descongelado01);

            //Arrancamos el funcionamiento
            while(miHeladera.Kilos > 0)
            {
                miHeladera.Trabajar(random.Next(1, 5));
            }

            //Eliminamos un handler
            miHeladera.EliminarMetodosReservas(reservas02);
            
            //Reiniciamos
            miHeladera.Kilos = 50;
            miHeladera.Grados = -15;

            //Arracamos nuevamente
            while(miHeladera.Kilos > 0)
            {
                miHeladera.Trabajar(random.Next(1, 5));
            }
        }
        public static void InformeKilos (int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">>>> Reservas bajas de alimentos. Estoy al nivel de Main");
            Console.WriteLine("Quedan {0} kilogramos");
        }

        public static void InformeGrados (int grados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>> La temperatura es muy baja! Estoy a nivel de Main");
            Console.WriteLine("Estamos a {0} grados", grados);
        }
    }
}