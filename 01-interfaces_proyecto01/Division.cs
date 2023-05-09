namespace Interfaces01
{
    class Division:IOperacion
    {
        private double r = 0;

        //Metodos a implementar de la Interfaz
        public void calcular (double a, double b)
        {
            this.r = a / b;
        }

        public void mostrar ()
        {
            Console.WriteLine("El resultado de la division es: {0}", this.r);
        }
    }    
}