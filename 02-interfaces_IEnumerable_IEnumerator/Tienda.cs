using System.Collections;

namespace InterfacesIEnumerableIEnumerator
{
    class Tienda
    {
        private Auto[] disponibles;

        public Tienda ()
        {
            this.disponibles = new Auto[4];

            disponibles[0] = new Auto("Soul", 220000.50);
            disponibles[1] = new Auto("Fit", 175600.70);
            disponibles[2] = new Auto("March", 168900.23);
            disponibles[3] = new Auto("Spark", 160400.40);
        }

        public IEnumerator GetEnumerator ()
        {
            return this.disponibles.GetEnumerator();
        }
    }
}