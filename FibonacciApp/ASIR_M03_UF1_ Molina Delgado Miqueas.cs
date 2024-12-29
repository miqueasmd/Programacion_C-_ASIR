using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        //--- Declaracion de variables
        int numero = 0;
        int[] sec_fibo;

        //------------------------------------------------------------------------------------------ Ejecución libre del programa

        //-------------------------- Se valida que el número introducido sea correcto
        do
        {
            Console.Write("Inserta el número elementos de Fibonacci a calcular: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out numero))
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                continue;
            }

        } while (NumeroValido(numero) == false);

        //-------------------------- Se obtiene la secuencia Fibonacci
        Console.WriteLine("Generando secuencia Fibonacci...");
        sec_fibo = SecuenciaFibo(numero);
        Console.WriteLine("Secuencia Fibonacci: " + string.Join(", ", sec_fibo));

        //-------------------------- Se obtiene la secuencia Fibonacci invertida
        Console.WriteLine("Invirtiendo secuencia Fibonacci...");
        sec_fibo = SecuenciaReverse(sec_fibo);
        Console.WriteLine("Secuencia Fibonacci invertida: " + string.Join(", ", sec_fibo));

        //-------------------------- Se obtiene la primera posición donde aparece el número que más veces está en el array
        Console.WriteLine("Buscando el número que más veces aparece en la secuencia...");
        Console.WriteLine(PosicionNumeroMasVisto(sec_fibo));

        //--- Fin de la ejecución del programa
        Console.ReadKey();
    }

    // Función NumeroValido
    public static bool NumeroValido(int numero)
    {
        return numero >= 3 && numero <= 20;
    }

    // Función SecuenciaFibo
    public static int[] SecuenciaFibo(int numero)
    {
        int[] secuencia = new int[numero];
        secuencia[0] = 0;
        secuencia[1] = 1;
        for (int i = 2; i < numero; i++)
        {
            secuencia[i] = secuencia[i - 1] + secuencia[i - 2];
        }
        return secuencia;
    }

    // Función SecuenciaReverse
    public static int[] SecuenciaReverse(int[] secuencia)
    {
        int[] invertida = new int[secuencia.Length];
        for (int i = 0; i < secuencia.Length; i++)
        {
            invertida[i] = secuencia[secuencia.Length - 1 - i];
        }
        return invertida;
    }

    // Función PosicionNumeroMasVisto
    public static string PosicionNumeroMasVisto(int[] arr_secuencia)
    {
        //--- Se inicializan variables
        int posicion = 0;
        int valor = 0;
        int recuento = 0;

        // Diccionario para contar las ocurrencias de cada número
        Dictionary<int, int> contador = new Dictionary<int, int>();

        // Contar las ocurrencias de cada número en el array
        for (int i = 0; i < arr_secuencia.Length; i++)
        {
            if (contador.ContainsKey(arr_secuencia[i]))
            {
                contador[arr_secuencia[i]]++;
            }
            else
            {
                contador[arr_secuencia[i]] = 1;
            }
        }

        // Encontrar el número con más ocurrencias
        foreach (var kvp in contador)
        {
            if (kvp.Value > recuento)
            {
                valor = kvp.Key;
                recuento = kvp.Value;
                posicion = Array.IndexOf(arr_secuencia, valor);
            }
        }

        if (recuento > 1)
        {
            return "El valor " + valor + " se repite " + recuento + " veces según la posicion " + posicion + " del array bidimensional.";
        }
        else
        {
            return "Todos los valores de la secuencia aparecen por igual.";
        }
    }
}