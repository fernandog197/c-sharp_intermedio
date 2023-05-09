namespace InterfaceCallbackSink
{
    class Program
    {
        public static void Main ()
        {
            //Creamos la heladera
            Heladera miHeladera = new Heladera(50, -20);

            Random random = new Random();

            //Creamos el Sink
            //En este caso, Sink01 contiene el codigo que se ejecutara cuando suceda el evento.
            HeladeraSink Sink01 = new HeladeraSink();
            RepositorSink Sink02 = new RepositorSink();

            //Agregamos el Sink a la miHeladera
            miHeladera.AgregarSink(Sink01);
            miHeladera.AgregarSink(Sink02);

            //Programamos el trabajo de la heladera
            while(miHeladera.Kilos > 0 && Sink01.Paro == false)
            {
                miHeladera.Trabajar(random.Next(1, 5));
            }
        }
    }
}