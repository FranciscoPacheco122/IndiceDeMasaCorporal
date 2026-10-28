using Imc.Models;

Console.WriteLine("Aplicación que calcula el Índice de Masa Corporal de una Persona");
Console.WriteLine();

decimal peso = ReadDecimal("Proporcione el peso en kilogramos de la Persona: ");
decimal estatura = ReadDecimal("Proporcione la estatura en metros de la Persona: ");

decimal imc = CalculadoraImc.IndiceMasaCorporal(peso, estatura);
var estadoNutricional = CalculadoraImc.EstadoNutricional(imc);

Console.WriteLine($"El Indice de Masa Corporal de la persona es: {imc:F4}");
Console.WriteLine($"El estado nutricional es: {estadoNutricional}");

static decimal ReadDecimal(string indicacion)
{
    string entrada;
    bool entradaEsValida;
     decimal valor;

    do
    {
        Console.Write("Proporcione el peso en kilogramos de la Persona: ");
        entrada = Console.ReadLine();
        entradaEsValida = decimal.TryParse(entrada, out valor);
        if (!entradaEsValida)
        {
            Console.WriteLine("Error: La entrada debe ser numerica");
        }
    } while (!entradaEsValida);
    return valor;
}
