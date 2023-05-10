namespace DelegadosHandlersMultiples
{
    class Tienda
    {
        public static void MandaViveres (int kilos)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(">> Vamos a mandar sus viveres (Estoy en la tienda)");
            Console.WriteLine(">> Seran {0} kilogramos", kilos);
        }
    }
}