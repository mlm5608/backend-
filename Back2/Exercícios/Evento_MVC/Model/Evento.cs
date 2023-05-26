using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evento_MVC.Model
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Descrição { get; set; }
        public string? Data { get; set; }

        private const string PATH = "Database/Evento.csv";

        public Evento()
        {
        // criar lógica para gerar pasta e produto

            // obter o caminho da pasta
            string pasta = PATH.Split("/")[0];
 
            // verificar se na pasta já esxiste uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            // verificar se na pasta já esxiste um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
    }
}