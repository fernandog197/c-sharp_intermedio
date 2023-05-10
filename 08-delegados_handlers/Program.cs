namespace DelegadosHandlers
{
    class Program
    {
        public static void Main ()
        {
            Heladera miHeladera = new Heladera(70, -20);
            Random random = new Random();

            //Adicionamos los handlers
            miHeladera.AdicionarMetodosReservas(new Heladera.ReservasBajas(InformeKilos));
            miHeladera.AdicionarMetodosDescongelados(new Heladera.Descongelado(InformeGrados));

            //Ponemos la Heladera en funcionamiento
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