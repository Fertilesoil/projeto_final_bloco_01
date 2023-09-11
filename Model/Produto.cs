using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produto
    {
        private int id;
        private string nome;
        private int tipo;
        private decimal preco;

        public Produto(int id, string nome, int tipo, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

        public int GetId()
        { return id; }

        public void SetId(int id)
        { this.id = id; }

        public string GetNome()
        { return nome; }

        public void SetNome(string nome)
        { this.nome = nome; }

        public int GetTipo()
        { return tipo; }

        public void SetTipo(int tipo)
        { this.tipo = tipo; }

        public decimal GetPreco()
        { return preco; }

        public void SetPreco(decimal preco)
        { this.preco = preco; }

        public virtual void Mostrar()
        {
            string tipo = string.Empty;
            switch (this.tipo)
            {
                case 1:
                    tipo = "Pelucia";
                    break;
            }
            Console.WriteLine($"O Id do produto é: {this.id}");
            Console.WriteLine($"O Tipo do produto é: {tipo}");
            Console.WriteLine($"O Nome do seu Produto é: {this.nome}");
            Console.WriteLine($"O Preço do seu Produto é: {this.preco:c}");
        }
    }
}
