namespace DelegadosHandlersMultiples
{
    delegate void ReservasBajas (int kilos);
    delegate void Descongelado (int grados);
    class Heladera
    {
        //Definimos los delegados

        private int kilos;
        private int grados;

        //Aqui estan las variables que usaremos para invocar
        private ReservasBajas deReservas;
        private Descongelado deDescongelado;

        public Heladera (int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }

        //Estos metodos permiten referenciar las variables
        public void AdicionarMetodosReservas (ReservasBajas metodo)
        {
            this.deReservas += metodo;
        }

        public void EliminarMetodosReservas (ReservasBajas metodo)
        {
            this.deReservas -= metodo;
        }

        public void AdicionarMetodosDescongelados (Descongelado metodo)
        {
            this.deDescongelado += metodo;
        }

        public void EliminarMetodosDescongelados (Descongelado metodo)
        {
            this.deDescongelado -= metodo;
        }

        //Getters & Setters
        public int Kilos { get => this.kilos; set => this.kilos = value; }
        public int Grados { get => this.grados; set => this.grados = value; }

        public void Trabajar (int consumo)
        {
            //Actualizamos las reservas de la heladera
            this.kilos -= consumo;
             
            //Subimos la temperatura
            this.grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos de carga || {1} grados de temperatura", this.kilos, this.grados);

            //Verificamos si se cumple la condicion para invocar los handlers del evento

            //Condicion 01. Evento Carga.
            if(this.kilos < 10)
            {
                this.deReservas(this.kilos);
            }

            //Condicion 02. Evento temperatura.
            if(this.grados > 0)
            {
                this.deDescongelado(this.grados);
            }
        }
    }
}