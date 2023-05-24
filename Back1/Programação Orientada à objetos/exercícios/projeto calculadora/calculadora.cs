using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_calculadora
{
    public class calculadora
    {
        // Operações
        public float numero1;
        public float numero2;
        public float resultado;
        public float soma(float numero1,float numero2){
            resultado = numero1 + numero2;
            return resultado;
        }
        public float sub(float numero1,float numero2){
            resultado = numero1 - numero2;
            return resultado;
        }
        public float div(float numero1,float numero2){
            resultado = numero1 / numero2;
            return resultado;
        }
        public float mult(float numero1,float numero2){
            resultado = numero1 * numero2;
            return resultado;
        }
    }
}