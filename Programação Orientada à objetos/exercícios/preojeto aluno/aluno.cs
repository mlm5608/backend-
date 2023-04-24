using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace preojeto_aluno
{
    public class aluno
    {
        // nome, curso, idade, rg, se é ou não bolsista, média final, mensalidade.

        public string nome;
        public string curso;
        public int idade;
        public int RG;
        public bool bolsa;
        public float valorBolsa;
        public float mediaF;
        public float mensalidade;
        public float valorMensalidade;
        public float VerMediaFinal(float mediaF)
        {
            if (mediaF >= 8)
            {
                bolsa = true;
                valorBolsa = 0.5f;
            }
            else if (mediaF >= 6 && mediaF < 8)
            {
                bolsa = true;
                valorBolsa = 0.3f;
            }
            else
            {
                Console.WriteLine($"ele não tem bolsa");
            }
            return valorBolsa;
        }
        public float VerMensalidade(float mensalidade, float valorBolsa)
        {
            valorMensalidade = mensalidade - (mensalidade * valorBolsa);
            return valorMensalidade;
        }

    }
}