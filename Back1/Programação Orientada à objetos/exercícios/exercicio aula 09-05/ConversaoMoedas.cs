using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_aula_09_05
{
    public class ConversaoMoedas
    {
        // Propriedades estáticas
        public static float Dollar { get; set; }
        public static float Real { get; set; }
        public static float Euro { get; set; }
        // Métodos estáticos
        public static float DolarEuro(float dollar)
        {
           float resultado = dollar * 0.91f;
           return resultado;
        }
        public static float DolarReal(float dollar)
        {
            float resultado = dollar * 0.2f;
            return resultado;
        }
        public static float EuroDollar(float euro)
        {
            float resultado = euro * 1.1f;
            return resultado;
        }
        public static float EuroReal(float euro)
        {
            float resultado = euro * 5.47f;
            return resultado;
        }
        public static float RealDollar(float real)
        {
            float resultado = real * 0.2f;
            return resultado;
        }
        public static float RealEuro(float real)
        {
            float resultado = real * 0.18f;
            return resultado;
        }
    }
}