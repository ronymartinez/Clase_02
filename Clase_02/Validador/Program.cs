namespace Validador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acum = 0;
            int contador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(), out int numero) && Validador.Validar(numero, -100, 100))
                {
                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }
                    acum += numero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Ha ingresado un dato inválido");
                }
            }

            Console.WriteLine("\nEl máximo ingresado es el {0}", maximo);
            Console.WriteLine("El mínimo ingresado es el {0}", minimo);
            Console.WriteLine("El contador de números ingresado es {0}", contador);
            Console.WriteLine("El total de números correctos ingreasdos es {0}", acum);
            Console.WriteLine("El promedio del total es {0}", (float) acum/contador);
        }
    }
}