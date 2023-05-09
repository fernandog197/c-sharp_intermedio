namespace InterfacesICloneable
{
    class Auto : IAutomovil, ICloneable
    {
        private double costo;
        private double iva;
        private string modelo;

        public Auto (string modelo, double costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }

        public double Costo { get => this.costo; set => this.costo = value; }
        public string Modelo { get => this.modelo; set => this.modelo = value; }

        //Metodos de IAutomovil
        public void CalcularIVA (double imp)
        {
            this.iva = 5000.0 + this.costo*imp;
        }

        public void MuestraInformacion ()
        {
            Console.WriteLine("Tu automovil modelo {0}", this.modelo);
            Console.WriteLine("Costo {0}, con un iva de: {1}", this.costo, this.iva);
            Console.WriteLine("Costo final: {0}", this.costo + this.iva);
            Console.WriteLine("-------------------------");
        }

        //Metodo para implementar ICloneable
        public object Clone ()
        {
            Auto aux = new Auto(this.modelo, this.costo);

            aux.iva = this.iva;

            return aux;
        }
    }
}