using Clase_02.Prueba;
using IOFile = System.IO.File; // Alias


namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Prueba.File file = new Prueba.File();

            file.leer();
        }
    }
}