using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_4
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}