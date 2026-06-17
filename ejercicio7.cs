using System;

class Program
{
    static void Main(string[] args)
    {
        int[] asistencia = new int[5];
        int indiceModificar, nuevoValor;
        bool existeCero = false;

        // Registrar asistencias
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Asistencia sesión {i}: ");
            asistencia[i] = int.Parse(Console.ReadLine());
        }

        // Buscar si existe alguna sesión con 0 asistentes
        for (int i = 0; i < 5; i++)
        {
            if (asistencia[i] == 0)
            {
                existeCero = true;
            }
        }

        if (existeCero)
        {
            Console.WriteLine("Alerta: existe una sesión con 0 asistentes");
        }
        else
        {
            Console.WriteLine("No hay sesión con 0 asistentes");
        }

        Console.Write("Índice a modificar: ");
        indiceModificar = int.Parse(Console.ReadLine());

        if (indiceModificar >= 0 && indiceModificar < 5)
        {
            Console.Write("Nuevo valor: ");
            nuevoValor = int.Parse(Console.ReadLine());

            asistencia[indiceModificar] = nuevoValor;
        }
        else
        {
            Console.WriteLine("Índice no válido");
        }

        Console.WriteLine("\nAsistencias actualizadas:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Sesión {i}: {asistencia[i]}");
        }
    }
}