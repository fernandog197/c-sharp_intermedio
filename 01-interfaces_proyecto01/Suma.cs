using System;
using System.Collections;

namespace Interfaces01
{
    class Suma:IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();

        //Metodos a implementar de la Interfaz
        public void calcular (double a, double b)
        {
            r = a + b;
        }

        public void mostrar ()
        {
            Console.WriteLine("El resultado de la suma es: {0}", this.r);
            resultados.Add(r);
        }

        //Metodos propios de la clase
        public void MostrarResultados ()
        {
            foreach (double r in resultados)
            {
                Console.WriteLine(r);
            }
        }
    }
}