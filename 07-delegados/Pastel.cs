namespace Delegados
{
    class Pastel
    {
        public static void MostrarPastel (string anuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevara el siguiente anuncio: {0}", anuncio);
        }
    }
}   