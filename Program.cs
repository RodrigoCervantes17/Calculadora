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
            string? opcion = Console.ReadLine();
            Console.WriteLine("Ingrese el primer numero:");
            float num1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Ingrese el segundo numero:");
            float num2 = float.Parse(Console.ReadLine()!);

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
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la division es: {resultado}");
                    break;

            }
        }
    }
}
