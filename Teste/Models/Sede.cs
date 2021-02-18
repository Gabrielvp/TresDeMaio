using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Models
{
    class Sede
    {
        public long Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Sede()
        {
        }

        public Sede(long id, string nomeFantasia, string razaoSocial, string cnpj, string inscricaoEstadual, string endereco, string numero, string bairro, string cidade, string uf, string telefone, string email)
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Telefone = telefone;
            Email = email;
        }
    }
}
