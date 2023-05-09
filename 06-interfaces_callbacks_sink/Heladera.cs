using System.Collections;

namespace InterfaceCallbackSink
{
    class Heladera
    {
        //Aqui guardamos todos los Sinks con los que se comunicara Heladera
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimento;
        private int grados;

        public Heladera (int kilosAlimento, int grados)
        {
            this.kilosAlimento = kilosAlimento;
            this.grados = grados;
        }

        //Getter & Setters
        public int Kilos { get => this.kilosAlimento; set => this.kilosAlimento = value; }
        public int Grados { get => this.grados; set => this.grados = value; }

        //Con este metodo agregamos un sink a la lista
        public void AgregarSink (IEventosHeladera sink)
        {
            if(sink != null)
            {
                this.listaSinks.Add(sink);
            }
        }

        //Con este metodo eliminamos un sink de la lista
        public void EliminarSink (IEventosHeladera sink)
        {
            if(this.listaSinks.Contains(sink))
            {
                this.listaSinks.Remove(sink);
            }
        }

        public void Trabajar (int consumo)
        {
            //Actualizamos la carga de la heladera
            this.kilosAlimento -= consumo;

            //Subimos la temperatura
            this.grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kgs, {1} grados", this.kilosAlimento, this.grados);

            //Verificamos si se cumple la condicion para invocar los handlers del evento

            //Esta es la condicion del evento
            if(this.kilosAlimento < 10)
            {
                //Invocamos los handles de cada Sink
                foreach (IEventosHeladera handler in this.listaSinks)
                {
                    handler.EReservasBajas(this.kilosAlimento);
                }
            }

            //Establecemos la condicion para el handler Descongelado
            if(grados >= 0)
            {
                foreach (IEventosHeladera handler in this.listaSinks)
                {
                    handler.EDescongelado(this.grados);
                }
            }
        }
    }
}