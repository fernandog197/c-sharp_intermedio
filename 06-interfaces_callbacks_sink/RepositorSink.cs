namespace InterfaceCallbackSink
{
    class RepositorSink : IEventosHeladera
    {
        public void EReservasBajas (int kilos)
        {
            //Colocamos el codigo a ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Enviando viveres!");
            Console.WriteLine("--> El repositor depositara {0} kilos extra", kilos);
        }

        public void EDescongelado (int grados)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--> Enviando técnico!");
        }
    }
}