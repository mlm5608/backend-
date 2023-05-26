using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_MVC.Model
{
    public class Produto
    {
        // propriedades
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // caminho da pasta e do arquivo csv

        private const string PATH = "Database/Produto.csv";

        public Produto()
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

        public List<Produto> Ler()
        {
            // instancia de lista 
            List<Produto> produtos = new List<Produto>();

            // sepração das linhas
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                // separação de cada linha 
                string[] atributos = item.Split(";");
                
                // instância do produto
                Produto p = new Produto();

                // aatribuição de valores dentro do objeto
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);
                
                // adiciona o abjeto à lista
                produtos.Add(p);
            }

            // retorna a lista
            return produtos;
        }

        // Método para preparar as linhas à serem inseridas no csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        // Método para inserir produto na linha do CSV
        public void Inserir(Produto p)
        {
            // array que armazena as linhas obtidas pelo método PrepararLinhasCSV
            string[] linhas = {PrepararLinhasCSV(p)};

            // Inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }
    }
}