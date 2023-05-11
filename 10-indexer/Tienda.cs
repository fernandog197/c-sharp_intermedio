using System.Collections;

namespace Indexer
{
    class Tienda
    {
        private Auto[] disponibles;

        public Tienda ()
        {
            disponibles = new Auto[4];

            disponibles [0] = new Auto("Soul", 220000.5);
            disponibles [1] = new Auto("Fit", 170600.75);
            disponibles [2] = new Auto("March", 168900.4);
            disponibles [3] = new Auto("Spark", 160400.25);
        }

        //Aqui creamos el indexer
        public Auto this[int index] //Colocamos el this para utilizar la instancia/objeto de forma directa
        {
            //Usamos un get para obtener el elemento en ese indice
            get { return this.disponibles[index]; }

            //Usamos un set para colocar elementos en ese indice
            set { disponibles[index] = value; }
        }

        //Aplico GetEnumerator() para poder utilizar foreach :D
        public IEnumerator GetEnumerator ()
        {
            return this.disponibles.GetEnumerator();
        }
    }
}