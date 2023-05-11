namespace Indexer
{
    class Program
    {
        public static void Main ()
        {
            int i = 0;

            //Creamos la tienda
            Tienda miTienda = new Tienda();

            //Obtenemos un auto
            Auto miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            //Creamos y agregamos un nuevo auto
            Auto otroAuto = new Auto("Vocho", 850000.00);
            miTienda[1] = otroAuto;

            //Imprimimos toda la tienda
            foreach (Auto a in miTienda)
            {
                a.MuestraInformacion();
            }
        }
    }
}