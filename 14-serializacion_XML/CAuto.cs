namespace SerializacionXML
{
    [Serializable]
    public class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get => this.costo; set => this.costo = value; }
        public string Modelo { get => this.modelo; set => this.modelo = value; }

        //En Serializacion XML el constructor no debe tener parametros! D: Averiguar porque!!!
        public CAuto ()
        {
            this.costo = 1000000.78;
            this.modelo = "Vocho";
        }

        public void MostrarInformacion ()
        {
            Console.WriteLine("Tu automovil {0}", this.modelo);
            Console.WriteLine("Costo {0}", this.costo);
            Console.WriteLine("---------------");
        }
    }
}