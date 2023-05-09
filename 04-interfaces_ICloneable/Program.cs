namespace InterfacesICloneable
{
    class Program
    {
        public static void Main ()
        {
            Auto Auto01 = new Auto("March", 170000.43);

            //Aqui referenciamos Auto01 a una nueva variable. NO CLONAMOS NADA! D:
            Auto Auto02 = Auto01;

            Auto01.CalcularIVA(0.21);
            Auto02.CalcularIVA(0.21);

            Auto01.MuestraInformacion();
            Auto02.MuestraInformacion();

            Console.WriteLine("--------------");

            //Si fuera un clon, al hacer un cambio, solo el referenciado deberia cambiar.
            Auto01.Costo = 60000;

            Auto01.MuestraInformacion();
            Auto02.MuestraInformacion();

            Console.WriteLine("==============");

            //Ahora creamos un clon utilizando ICloaneable
            Auto Auto03 = (Auto) Auto01.Clone();

            Auto01.MuestraInformacion();
            Auto03.MuestraInformacion();

            Console.WriteLine("--------------");

            //Ahora si modificamos Auto01, Auto03 no deberia alterarse
            Auto01.Costo = 60123;

            Auto01.MuestraInformacion();
            Auto03.MuestraInformacion();

            Console.WriteLine("==============");
        }
    }
}