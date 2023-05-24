using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_2
{
    public class MaquinaCafe
    {
        public float acucarDisponivel = 20;

        public void FazerCafe(float x)
        {
            if (x < acucarDisponivel)
            {
                Console.WriteLine($"Será adicionado {x} gramas de açúcar!");
                acucarDisponivel = acucarDisponivel - x;
            }
            else
            {
                Console.WriteLine($"Açucar insuficiente! Procure um dos nossos atendentes ou peça um café sem açúcar");
            }    
        }
        public void FazerCafe()
        {
            Console.WriteLine($"Será adicionado 10 gramas de açúcar!");
            acucarDisponivel = acucarDisponivel - 10;
        }
    }
}