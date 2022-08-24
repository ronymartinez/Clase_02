using System.Xml;

namespace Ej_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool primero;
            bool segundo;
            bool tercero = false;
            string operacionString = null;
            string continuar;
            float resultado = 0;

            do
            {

                Console.Write("Ingrese el primer numero: ");

                primero = int.TryParse(Console.ReadLine(), out int numero1);

                Console.Write("Ingrese el segundo numero: ");
                segundo = int.TryParse(Console.ReadLine(), out int numero2);

                Console.Write("\n1. Suma\n2. Resta\n3. Multiplicación\n4. División\nIngrese la operación a realizar: ");
                if (int.TryParse(Console.ReadLine(), out int operacion) && operacion < 5 && operacion > 0)
                {
                    switch (operacion)
                    {
                        case 1:
                            operacionString = "Suma";
                            tercero = true;
                            break;
                        case 2:
                            operacionString = "Resta";
                            tercero = true;
                            break;
                        case 3:
                            operacionString = "Multiplicacion";
                            tercero = true;
                            break;
                        case 4:
                            operacionString = "Division";
                            tercero = false;
                            break;
                    }
                  
                }

                if (primero && segundo && tercero)
                {
                    resultado = Ej_Calculadora.Calculadora.Calcular(numero1, numero2, operacionString);
                    Console.WriteLine("\nEl resultado es {0}", resultado);
                }
                else
                    {
                        Console.WriteLine("\nNo se ha realizado correctamente la validación.");
                    }




                Console.WriteLine("\nIngrese 's' para continuar");
                continuar = Console.ReadLine();
                Console.Clear();

            }while (continuar == "s");
        }
    }
}