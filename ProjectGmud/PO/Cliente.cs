using ProjectGmud.PO.Enum;
using System;
using System.Collections.Generic;

namespace ProjectGmud.PO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public DateTime DataCadastro { get; set; }
        public Servicos Servicos { get; set; }
        public ICollection<Gmud> Gmuds { get; set; } = new List<Gmud>();

        public Cliente()
        {
        }

        public Cliente(int id, string cNPJ, string razaoSocial, string endereco, string cidade, string uF, DateTime dataCadastro, Servicos servicos)
        {
            Id = id;
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
            Endereco = endereco;
            Cidade = cidade;
            UF = uF;
            DataCadastro = dataCadastro;
            Servicos = servicos;
        }

        public bool validation()
        {
            //nulo vazio ou bco
            return string.IsNullOrWhiteSpace(this.CNPJ);

          /*  if (txtCNPJ.Text != null
                   && txtCNPJ.Text != ""
                   && txtCidade.Text != null
                   && txtCidade.Text != ""
                   && txtEndereco.Text != null
                   && txtEndereco.Text != ""
                   && txtRS.Text != null
                   && txtRS.Text != ""
                   && selectUF.Value != ""
                   && selectUF.Value != null)*/
        }
    }
}