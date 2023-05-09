namespace Interfaces01
{
    class Multiplicacion:IOperacion
    {
        private double r = 0;

        //Metodos a implementar de la Interfaz
        public void calcular (double a, double b)
        {
            this.r = a * b;
        }

        public void mostrar ()
        {
            Console.WriteLine("El resultado de la multiplicacion es: {0}", this.r);
        }
    }
}