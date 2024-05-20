using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            int opcion;

            do
            {
                Console.WriteLine("---- Menú de Operaciones ----");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("-----------------------------");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    double resultado;
                    double num1, num2;

                    try
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese el primer número: ");
                                if (!double.TryParse(Console.ReadLine(), out num1))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                Console.Write("Ingrese el segundo número: ");
                                if (!double.TryParse(Console.ReadLine(), out num2))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                resultado = operaciones.Sumar(num1, num2);
                                Console.WriteLine($"El resultado de la suma es: {resultado}");
                                break;
                            case 2:
                                Console.Write("Ingrese el primer número: ");
                                if (!double.TryParse(Console.ReadLine(), out num1))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                Console.Write("Ingrese el segundo número: ");
                                if (!double.TryParse(Console.ReadLine(), out num2))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                resultado = operaciones.Restar(num1, num2);
                                Console.WriteLine($"El resultado de la resta es: {resultado}");
                                break;
                            case 3:
                                Console.Write("Ingrese el primer número: ");
                                if (!double.TryParse(Console.ReadLine(), out num1))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                Console.Write("Ingrese el segundo número: ");
                                if (!double.TryParse(Console.ReadLine(), out num2))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                resultado = operaciones.Multiplicar(num1, num2);
                                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                                break;
                            case 4:
                                Console.Write("Ingrese el primer número: ");
                                if (!double.TryParse(Console.ReadLine(), out num1))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                Console.Write("Ingrese el segundo número: ");
                                if (!double.TryParse(Console.ReadLine(), out num2))
                                {
                                    throw new Exception("Entrada no válida. Por favor, ingrese un número.");
                                }
                                resultado = operaciones.Dividir(num1, num2);
                                Console.WriteLine($"El resultado de la división es: {resultado}");
                                break;
                            case 5:
                                Console.WriteLine("Saliendo del programa...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

                Console.WriteLine(); // Salto de línea para mejorar la legibilidad
            } while (opcion != 5);
        }
    }

    public class Operaciones
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("¡No se puede dividir por cero!");
            }
            return a / b;
        }
    }
}