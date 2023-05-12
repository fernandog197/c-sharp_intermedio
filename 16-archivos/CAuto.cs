namespace Archivos
{
    class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get => this.costo; set => this.costo = value; }
        public string Modelo { get => this.modelo; set => this.modelo = value; }

        //Constructor sin parametros
        public CAuto (string modelo, double costo) 
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void MuestraInformacion ()
        {
            Console.WriteLine("Tu automovil {0}", this.modelo);
            Console.WriteLine("Costo {0}", this.costo);
            Console.WriteLine("--------");
        }
    }
}