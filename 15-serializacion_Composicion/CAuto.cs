namespace SerializacionComposicion
{
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;
        private CMotor motor;

        public double Costo { get => this.costo; set => this.costo = value; }
        public string Modelo { get => this.modelo; set => this.modelo = value; }
        public CMotor Motor { get => this.motor; set => this.motor = value; }

        //Constructor sin parametros
        public CAuto () 
        {
            this.costo = 100000.50;
            this.modelo = "Vocho";
            this.motor = new CMotor(); 
        }

        public void MuestraInformacion ()
        {
            Console.WriteLine("Tu automovil {0}", this.modelo);
            Console.WriteLine("Costo {0}", this.costo);
            this.motor.MostrarMotor();
            Console.WriteLine("--------");
        }
    }
}