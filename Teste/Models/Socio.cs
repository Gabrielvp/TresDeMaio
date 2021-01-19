using System;

namespace Teste.Models
{
    class Socio
    {
        public int Id { get; set; }
        public int Titulo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string UfOrgaoExpedidor { get; set; }
        public DateTime DataExpedicao{ get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdesao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string FoneResidencial { get; set; }
        public string FoneCelular { get; set; }
        public string FoneComercial { get; set; }
        public string Email { get; set; }       
        public string Obs { get; set; }
        public string Situacao { get; set; }
        public string UltPagto { get; set; }
        public bool Ativo { get; set; }
        public string PathImagem { get; set; }
    }
}
