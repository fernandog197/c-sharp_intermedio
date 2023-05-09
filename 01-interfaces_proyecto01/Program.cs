namespace Interfaces01
{
    class Program
    {
        public static void Main ()
        {
            int opcion = 0;
            double valA = 0.0;
            double valB = 0.0;

            string read = "";

            IOperacion operacion = new Suma();

            while(opcion != 5)
            {
                Console.WriteLine("Elija la operación que desea realizar: ");
                Console.WriteLine("1 - Suma || 2 - Resta || 3 - Mulplicacion || 4 - Division || 5 - Salir");
                read = Console.ReadLine();
                opcion = Convert.ToInt32(read);

                if(opcion == 5)
                {
                    break;
                }

                Console.WriteLine("Por favor inserte el primer valor.");
                read = Console.ReadLine();
                valA = Convert.ToDouble(read);

                Console.WriteLine("Por favor inserte el segundo valor.");
                read = Console.ReadLine();
                valB = Convert.ToDouble(read);

                //Polimorfismo
                if(opcion == 2)
                {
                    operacion = new Resta();
                }

                if(opcion == 3)
                {
                    operacion = new Multiplicacion();
                }

                if(opcion == 4)
                {
                    operacion = new Division();
                }

                operacion.calcular(valA, valB);
                operacion.mostrar();
            }
        }
    }
}