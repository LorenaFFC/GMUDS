using ProjectGmud.PO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectGmud.PO
{
    public class Prestador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public DateTime DataAdmissao { get; set; }
        public double ValorPorHora { get; set; }
        public StatusFuncionario StatusFuncionario { get; set; }
        public ICollection<Gmud> Gmuds { get; set; } = new List<Gmud>();
        public Prestador()
        {
        }
        public Prestador(int id, string nome, string cPF, string cNPJ, string endereco, string cidade, string uF, DateTime dataAdmissao, double valorPorHora, StatusFuncionario statusFuncionario)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            CNPJ = cNPJ;
            Endereco = endereco;
            Cidade = cidade;
            UF = uF;
            DataAdmissao = dataAdmissao;
            ValorPorHora = valorPorHora;
            StatusFuncionario = statusFuncionario;
        }
    }


}