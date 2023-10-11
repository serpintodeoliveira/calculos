using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// implementa operacoes de conversao.
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversao de temperatura a executar.    
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Tipo de conversao de distancias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }


        /// <summary>
        /// Conversaod e Temperaturas.
        /// </summary>
        /// <param name="conversao">A conversao a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversao</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }
        /// <summary>
        /// Conversao se distancias
        /// </summary>
        /// <param name="conversao">A conversao a efetuar</param>
        /// <param name="distancia">A distancia a converter</param>
        /// <returns>Resultado da conversao da distancia</returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if(conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            return -1;
        }
    }
}
