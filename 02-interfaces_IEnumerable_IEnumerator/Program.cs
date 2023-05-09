

namespace InterfacesIEnumerableIEnumerator
{
    class Program
    {
        public static void Main ()
        {
            Tienda miTienda = new Tienda();

            foreach (Auto miAuto in miTienda)
            {
                miAuto.CalcularIVA(0.05);
                miAuto.MuestraInformacion();
            }
        }
    }
}