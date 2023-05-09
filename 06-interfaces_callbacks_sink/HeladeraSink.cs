namespace InterfaceCallbackSink
{
    class HeladeraSink : IEventosHeladera
    {
        //Esta es la clase Sink. Aqui colocamos los handles de los eventos definidos en la interfaz.
        private bool paro;

        public HeladeraSink ()
        {
            this.paro = false;
        }

        public bool Paro { get => this.paro; set => this.paro = value; }

        public void EReservasBajas (int kilos)
        {
            //Aqui colocamos el codigo necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Reservas bajas de alimento!");
            Console.WriteLine("--> Quedan {0} kilogramos", kilos);
        }

        public void EDescongelado (int grados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> El refri se descongela! <<<");

            if(grados > 0)
            {
                this.paro = true;
            }
        }
    }
}