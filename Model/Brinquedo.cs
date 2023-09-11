using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    internal class Brinquedo : Produto
    {
        private string tamanho = string.Empty;
        public Brinquedo(int id, string nome, int tipo, decimal preco, string tamanho)
        : base(id, nome, tipo, preco)
        {
            this.tamanho = tamanho;
        }

        public string GetTamanho()
        { return tamanho; }

        public void SetTamanho(string tamanho)
        { this.tamanho = tamanho; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Tamanho do seu Produto: {this.tamanho}.");
        }
    }
}
