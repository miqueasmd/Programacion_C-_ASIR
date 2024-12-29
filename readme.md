# Fibonacci Sequence Console Application

This is a C# console application that calculates the Fibonacci sequence, reverses it, and finds the most frequently occurring number in the reversed sequence.

## Features

1. **Validate Input Number**: Ensures the input number is between 3 and 20.
2. **Calculate Fibonacci Sequence**: Generates a Fibonacci sequence of the specified length.
3. **Reverse Fibonacci Sequence**: Reverses the generated Fibonacci sequence.
4. **Find Most Frequent Number**: Finds the most frequently occurring number in the reversed sequence and its first position.

## Requirements

- .NET SDK

## How to Run

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/FibonacciApp.git
   cd FibonacciApp
   ```

2. Build and run the application:
   ```sh
   dotnet run
   ```

3. Follow the prompts in the console to input the number of Fibonacci elements to calculate.

## Project Structure

- `Program.cs`: Contains the main logic of the application, including the entry point and user interaction code.
- `ASIR_M03_UF1_Molina_Delgado_Miqueas.cs`: Contains the implementation of the core functions:
  - `NumeroValido`: Input validation
  - `SecuenciaFibo`: Fibonacci sequence generation
  - `SecuenciaReverse`: Sequence reversal
  - `PosicionNumeroMasVisto`: Frequency analysis
- `README.md`: Project documentation and usage instructions
- `.gitignore`: Specifies which files Git should ignore
- `FibonacciApp.csproj`: Project configuration file
- `PAC.pdf`: Assignment instructions and requirements document

## Functions

### NumeroValido

Validates that the input number is between 3 and 20.

```csharp
public static bool NumeroValido(int numero)
{
    return numero >= 3 && numero <= 20;
}
```

### SecuenciaFibo

Generates a Fibonacci sequence of the specified length.

```csharp
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
```

### SecuenciaReverse

Reverses the generated Fibonacci sequence.

```csharp
public static int[] SecuenciaReverse(int[] secuencia)
{
    int[] invertida = new int[secuencia.Length];
    for (int i = 0; i < secuencia.Length; i++)
    {
        invertida[i] = secuencia[secuencia.Length - 1 - i];
    }
    return invertida;
}
```

### PosicionNumeroMasVisto

Finds the most frequently occurring number in the reversed sequence and its first position.

```csharp
public static string PosicionNumeroMasVisto(int[] arr_secuencia)
{
    int posicion = 0;
    int valor = 0;
    int recuento = 0;

    Dictionary<int, int> contador = new Dictionary<int, int>();

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
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## ☕ Support Me

If you like my work, consider supporting my studies!

Your contributions will help cover fees and materials for my **Computer Science and Engineering studies  at UoPeople** starting in September 2025.

Every little bit helps—you can donate from as little as $1.

<a href="https://ko-fi.com/miqueasmd"><img src="https://ko-fi.com/img/githubbutton_sm.svg" /></a>