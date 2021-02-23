using System;

namespace Teste.Models
{
    public class Dependente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Parentesco { get; set; }
        public int? Numero { get; set; }
        public string Obs { get; set; }
        public string Fone { get; set; }
        public DateTime? DataInclusao { get; set; }
        public int IdSocio { get; set; }

        public Dependente()
        {
        }

        public Dependente(int id, string cpf, string nome, DateTime? dataNascimento, string parentesco, int? numero, string obs, string fone, DateTime? dataInclusao, int idSocio)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
            Parentesco = parentesco;
            Numero = numero;
            Obs = obs;
            Fone = fone;
            DataInclusao = dataInclusao;
            IdSocio = idSocio;
        }
    }
}
