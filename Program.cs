using System;
using System.IO;

class Program
{
    static string rutaHistorial = "historial.txt";

    static void Main()
    {
        Console.Title = "Calculadora de consola";
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("== CALCULADORA DE RODRIGO :) ==");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Ver historial");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");
            string? opcion = Console.ReadLine();

            if (opcion == "6")
            {
                continuar = false;
                Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                break;
            }

            if (opcion == "5")
            {
                MostrarHistorial();
                continue;
            }

            // Pedir números de forma segura
            Console.Write("Ingrese el primer número: ");
            float num1;
            while (!float.TryParse(Console.ReadLine(), out num1))
                Console.Write("Número inválido, intenta de nuevo: ");

            Console.Write("Ingrese el segundo número: ");
            float num2;
            while (!float.TryParse(Console.ReadLine(), out num2))
                Console.Write("Número inválido, intenta de nuevo: ");

            float resultado = 0;
            string descripcion = "";

            switch (opcion)
            {
                case "1":
                    resultado = num1 + num2;
                    descripcion = $"{num1} + {num2} = {resultado}";
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    descripcion = $"{num1} - {num2} = {resultado}";
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    descripcion = $"{num1} * {num2} = {resultado}";
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        descripcion = $"{num1} / {num2} = {resultado}";
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        descripcion = $"{num1} / {num2} = ERROR (división por cero)";
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    continue;
            }

            // ✅ Guardar la operación en el historial
            GuardarEnHistorial(descripcion);

            Console.Write("\n¿Deseas realizar otra operación? (s/n): ");
            string? sigOperacion = Console.ReadLine()?.Trim().ToLower();
            if (sigOperacion != "s")
            {
                continuar = false;
                Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
            }
        }
    }
    static void GuardarEnHistorial(string descripcion)
    {
        string registro = $"{DateTime.Now:G} -> {descripcion}{Environment.NewLine}";
        File.AppendAllText(rutaHistorial, registro);
    }

    static void MostrarHistorial()
    {
        Console.Clear();
        Console.WriteLine("=== HISTORIAL DE OPERACIONES ===\n");

        if (File.Exists(rutaHistorial))
        {
            string contenido = File.ReadAllText(rutaHistorial);
            Console.WriteLine(contenido);
        }
        else
        {
            Console.WriteLine("Aún no hay operaciones registradas.");
        }

        Console.WriteLine("\nPresiona una tecla para volver al menú...");
        Console.ReadKey();
    }
}
