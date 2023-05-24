using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_4
{
    public interface IContatoComercial
    {
        bool ValidarCnpj(string _cnpj);
    }
}