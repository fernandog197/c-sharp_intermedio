namespace InterfacesIEnumerableIEnumerator
{
    class Auto:IAutomovil
    {
        double costo;
        double iva;
        string modelo;

        public Auto (string modelo, double costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }

        //Metodos de la interfaz
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
    }
}