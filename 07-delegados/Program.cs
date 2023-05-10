namespace Delegados
{
    //Definimos el delegado con las caracteristicas que nos interesan
    public delegate void MiDelegado (string m);
    class Program
    {
        public static void Main ()
        {
            //Creamos un objeto del Delegado y lo referenciamos a un metodo
            MiDelegado delegadoRadio = new MiDelegado(Radio.MetodoRadio);

            //Ahora por medio del delegado hacemos uso del metodo
            delegadoRadio("Hola a todos!");

            //Hacemos que el delegado apunte a otro metodo D:
            delegadoRadio = new MiDelegado(Pastel.MostrarPastel);

            //Invocamos el otro metodo
            delegadoRadio("Feliz cumpleaños! :D");
        }
    }
}