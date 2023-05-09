using System;
using System.Collections;

namespace _03InterfacesIEnumerableIEnumerator
{
    class Contenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public Contenedora ()
        {
            for(int i = 0; i < valores.Length; i++)
            {
                valores[i] = i * i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }

    class ContenedorEnum:IEnumerator
    {
        public int[] arreglo;
        private int position = -1;

        public ContenedorEnum (int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public bool MoveNext()
        {
            this.position++;
            
            return this.position < this.arreglo.Length;
        }

        public void Reset ()
        {
            this.position = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[position];
            }
        }
    }
}