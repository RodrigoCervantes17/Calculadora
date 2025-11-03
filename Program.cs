using System;

class Program
{
    static void Main()
    {
        Console.Title = "Calculadora de consola";
        bool continuar = true;
        float resultado = 0;

        while (continuar)
        {
            Console.WriteLine("==CALCULADORA DE RODRIGO :)==");
            Console.WriteLine("Seleccione una operacion:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            string? opcion = Console.ReadLine();
            Console.WriteLine("Ingrese el primer numero:");
            float num1, num2;
            while (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Por favor ingresa un número válido:");
            }

            Console.WriteLine("Ingrese el segundo número:");
            while (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Por favor ingresa un número válido:");
            }


            switch (opcion)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    }
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                    break;

            }
            Console.WriteLine("Continuar? s/n");// Línea en blanco para mejor legibilidad
            string? sigOperacion = Console.ReadLine();
            if (sigOperacion.ToLower()!= "s")
            {
                continuar = false;
                Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
            }
            Console.Clear();
        }
    }
}
