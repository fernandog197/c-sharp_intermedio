namespace Delegados
{
    class Radio
    {
        //Este metodo actuara como delegado
        public static void MetodoRadio (string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase Radio");
            Console.WriteLine("Este es tu mensaje: {0}", mensaje);
        }
    }
}