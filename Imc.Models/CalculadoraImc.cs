namespace Imc.Models
{
    public static class CalculadoraImc
    {
        public static decimal IndiceMasaCorporal(decimal peso, decimal estatura) => peso / (estatura * estatura);

        public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso Bajo";
            }
            if (imc < 25.0m)
            {
                return "Peso Normal";
            }
            if (imc < 30.0m)
            {
                return "Sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obesidad";
            }
            return "Obesidad Extrema";
        }

        internal static decimal IndiceMasaCorporal(decimal peso, object estatura)
        {
            throw new NotImplementedException();
        }
    }
}
