using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos_interface
{
    public interface ICarrinho
    {
        // regras do "contrato"
        // Métodos que devem apenas serem declarados

        // CRUD : Create, Read, Update, Delete
        // Padrão de chamada de método 
        // tipo Nome(parâmetros)

        // Create
        void Adicionar(Produto _produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int _codigo, Produto _produto);
        // Delete
        void Remover(Produto _produto);
    }
}