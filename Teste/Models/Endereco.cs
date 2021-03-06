﻿namespace Teste.Models
{
    public class Endereco
    {
        public int? Id { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int? Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public int IdSocio { get; set; }

        public Endereco()
        {
        }

        public Endereco(int? id, string cep, string rua, int? numero, string bairro, string cidade, string uf, string complemento, int idSocio)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            IdSocio = idSocio;
        }
    }
}
