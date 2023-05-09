namespace InterfaceCallbackSink
{
    interface IEventosHeladera
    {
        //Aqui definimos los eventos que tendra la heladera
        void EReservasBajas (int kilos);
        void EDescongelado (int grados);
    }
}