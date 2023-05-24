using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_4
{
    public class Agenda : IAgenda
    {
        public List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }
    }
}