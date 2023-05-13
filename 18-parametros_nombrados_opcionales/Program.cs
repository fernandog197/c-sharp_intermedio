namespace ParametrosNombradosOpcionales
{
    class Program
    {
        public static void Main ()
        {
            //Invocamos el metodo de forma "normal"
            //Tres parametro posicionales
            MostrarDatos(3, 5, 7);

            //Invocamos la funcion con el primer parametro normal, y los otros 2 en otro orden
            //1 parametro posicional, 2 nombrados
            MostrarDatos(3, pC: 7, pB: 5);

            //Invocamos con los tres parametros en otro orden
            //3 parametros nombrados
            MostrarDatos(pC: 7, pA: 3, pB: 5);

            //Un parametro posicional no puede venir despues de un nombrado
            //MostrarDatos(pB: 5, 3, 7) -> NO ES VALIDO!!

            Console.WriteLine("Ahora parametros opcionales o por defecto");

            //Invocamos de forma normal, con tres parametros posicionales
            MostrarOpcionales(11, 12, 13);

            //Usamos 2 parametros, c utiliza el default
            MostrarOpcionales(11, 12);

            //Pasamos solo 1 parametro
            MostrarOpcionales(11);

            //Ahora no paso ningun parametro
            MostrarOpcionales();

            Console.WriteLine("Ahora combinamos opcionales(por default) con nombrados");

            //Un opcional y 2 nombrados
            MostrarOpcionales(pC: 13, pB: 12);

            //Dos opcionales y 1 nombrado
            MostrarOpcionales(pB: 12);
        }

        public static void MostrarDatos (int pA, int pB, int pC)
        {
            Console.WriteLine("El valor de A es: {0}", pA);
            Console.WriteLine("El valor de B es: {0}", pB);
            Console.WriteLine("El valor de C es: {0}", pC);
            Console.WriteLine("--------------");
        }

        public static void MostrarOpcionales(int pA = 1, int pB = 2, int pC = 3)
        {
            Console.WriteLine("El valor de A es: {0}", pA);
            Console.WriteLine("El valor de B es: {0}", pB);
            Console.WriteLine("El valor de C es: {0}", pC);
            Console.WriteLine("--------------");
        }
    }
}