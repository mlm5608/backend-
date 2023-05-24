using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exexplo_2
{
    public class ConversorTemperatura
    {
        // Propriedade estática
        public static float Temperatura { get; set; }

        // método estático
        public static float CelciusParaFahrenheit(float celcius)
        {
            float Temperatura = celcius;

            float fahrenheit = (Temperatura * 9 / 5 + 32);

            return fahrenheit;
        }

        public static float FahrenheitParaCelsius(float fahrenheit)
        {
            float Temperatura = fahrenheit;

            float celcius = (Temperatura - 32) * 5/9;
            return celcius;
        }
    }
}