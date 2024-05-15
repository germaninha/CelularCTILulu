using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Aparelho
    {
        private Int64 id_aparelho;
        private string modelo;
        private Fabricante fabricante;
        private double espessura;
        private double largura;
        private double altura;
        private double peso;
        private double quantidade;
        private decimal preco;
        private decimal desconto;
        private string obsercacao;

        public Int64 Id_Aparelho { get; set; }

        public string Modelo { get; set; }

        public Fabricante Fabricante { get; set; }

        public double Espessura { get; set; }

        public double Largura { get; set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public double Quantidade { get; set; }

        public decimal Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value < 0)
                    throw new Exception("O campo Preco deve ser maior ou igual zero!");
                else
                    preco = value;
            }
        }

        public decimal Desconto { get; set; }

        public string Obsercacao { get; set; }

        // sobrescrever o método ToString da classe Aparelho
        public override string ToString()
        {
            return Fabricante.Nome.PadRight(12) + 
                    Modelo.PadRight(30) + 
                    Preco.ToString("C").PadLeft(16) + "       ( " + Quantidade + " em estoque )";
        }
    }
}
