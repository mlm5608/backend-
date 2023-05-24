using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_construtores
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        // ctor
        public Produto()
        {
            Console.WriteLine($"Tem nada não");
        }
        public Produto(string codigo)
        {
            Codigo = codigo;
            Console.WriteLine($"{codigo}");
            
        }
        public Produto(string codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;

            Console.WriteLine(@$"
{codigo}
{nome}
{preco}
            ");
            
        }
    }
}