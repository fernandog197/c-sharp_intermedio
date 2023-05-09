namespace _03InterfacesIEnumerableIEnumerator
{
    class Program
    {
        public static void Main ()
        {
            Contenedora datos = new Contenedora();

            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
            }
        }
    }
}