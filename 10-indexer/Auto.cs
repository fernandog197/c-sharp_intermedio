namespace Indexer
{
    class Auto
    {
        double costo;
        double iva;
        string modelo;

        //Constructor
        public Auto (string modelo, double costo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        //Metodos
        public void MuestraInformacion ()
        {
            Console.WriteLine("Tu automovil {0}", this.modelo);
            Console.WriteLine("Costo {0}", this.costo);
            Console.WriteLine("-------------");
        }
    }
}