namespace InterfacesIComparable
{
    class Rectangulo : IComparable
    {
        private double ancho;
        private double largo;
        private double area;

        public Rectangulo (double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
            CalcularArea();
        }

        private void CalcularArea ()
        {
            this.area = this.ancho * this.largo;
        }

        public override string ToString()
        {
            return string.Format("Ancho[{0}] Largo[{1}] -> Area[{2}]", this.ancho, this.largo, this.area);
        }

        //Implementamos IComparable
        int IComparable.CompareTo(object? obj)
        {
            //Hacemos type casto con el objeto a comparar
            Rectangulo aux = (Rectangulo)obj;

            //Si somos mas grandes que el objeto regresamos 1
            if(this.area > aux.area)
            {
                return 1;
            }

            //Si somos mas pequeños que el objeto regresamos -1
            if(this.area < aux.area)
            {
                return -1;
            }

            //Si somos iguales al objeto devolvemos 0
            return 0;
        } 
    }
}