//Comando para agregar la libreria: dotnet add reference <Ruta de la carpeta que contiene el proyecto>

using Operaciones;

namespace Pruebas
{
    class Program
    {
        public static void Main ()
        {
            double resultado;

            resultado = COperaciones.Suma(5, 98.45);

            Console.WriteLine(resultado);
        }
    }
}