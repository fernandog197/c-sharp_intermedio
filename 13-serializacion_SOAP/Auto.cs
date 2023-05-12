namespace SerializacionSOAP
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto (string modelo, double costo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void MostrarInformacion ()
        {
            Console.WriteLine("Tu automovil {0}", this.modelo);
            Console.WriteLine("Costo {0}", this.costo);
            Console.WriteLine("---------------");
        }
    }
}