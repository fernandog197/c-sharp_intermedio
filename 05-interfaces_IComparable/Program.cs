namespace InterfacesIComparable
{
    class Program
    {
        public static void Main ()
        {
            Rectangulo[] rectangulos = new Rectangulo[5];

            rectangulos[0] = new Rectangulo(7, 5);
            rectangulos[1] = new Rectangulo(6, 4);
            rectangulos[2] = new Rectangulo(4, 3);
            rectangulos[3] = new Rectangulo(7, 6);
            rectangulos[4] = new Rectangulo(5, 7);

            //Imprimimos el arreglo inicial
            foreach (Rectangulo r in rectangulos)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("-------------");

            //Hacemos uso del sort, el cual necesita la implementacion de IComparable
            Array.Sort(rectangulos);

            //Imprimimos el arreglo ordenado
            foreach (Rectangulo r in rectangulos)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("-------------");
        }
    }
}