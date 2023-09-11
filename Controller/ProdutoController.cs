using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01
{
    public class ProdutoController : IRepository
    {
        private readonly List<Produto> ListaProdutos = new();
        int numero = 0;

        public void AtualizarProduto(Produto produto)
        {
            string tipo = string.Empty;
            if (produto.GetTipo() == 1)
                tipo = "Pelucia";

            var buscarProduto = BuscarNaCollection(produto.GetId());
            if (buscarProduto is not null)
            {
                var index = ListaProdutos.IndexOf(buscarProduto);
                ListaProdutos[index] = produto;
                Console.WriteLine($"O Produto {produto.GetNome()} do tipo {tipo} foi atualizado!");
            }
        }

        public void ConsultarPorId(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
                produto.Mostrar();
            else
                Console.WriteLine("Produto não encontrado");
        }

        public void CriarProduto(Produto produto)
        {
            string tipo = string.Empty;
            if (produto.GetTipo() == 1)
                tipo = "Pelucia";

            ListaProdutos.Add(produto);
            Console.WriteLine($"Seu produto {produto.GetNome()} do tipo {tipo} foi cadastrado!");
        }

        public void DeletarProduto(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
            {
                ListaProdutos.Remove(produto);
                Console.WriteLine($"O Produto {produto.GetNome()} do tipo {produto.GetTipo()} foi removido!");
            }
            else
            {
                Console.WriteLine("Produto não foi encontrado");
            }
        }

        public void ListarTodosProdutos()
        {
            foreach (var produto in ListaProdutos)
            {
                produto.Mostrar();
            }
        }

        public int ContadorProduto()
        {
            return ++numero;
        }

        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in ListaProdutos)
            {
                if (produto.GetId() == id)
                    return produto;
            }
            return null;
        }
    }
}
