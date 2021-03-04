using System;

namespace Teste.Models
{
    class Receita
    {
        public int Id { get; set; }
        public long Documento { get; set; }
        public int Parcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public int DiaVencimento { get; set; }
        public double Valor { get; set; }
        public bool FlagPago { get; set; }
        public string Obs { get; set; }
        public DateTime DataCadastro { get; set; }
        public long IdSocio { get; set; }

        public Receita()
        {
        }

        public Receita(long documento, DateTime dataVencimento, double valor, long idSocio)
        {
            Documento = documento;
            DataVencimento = dataVencimento;
            Valor = valor;
            IdSocio = idSocio;
        }

        public Receita(int id, long documento, int parcela, DateTime dataVencimento, int diaVencimento, double valor, bool flagPago, string obs)
        {
            Id = id;
            Documento = documento;
            Parcela = parcela;
            DataVencimento = dataVencimento;
            DiaVencimento = diaVencimento;
            Valor = valor;
            FlagPago = flagPago;
            Obs = obs;
        }

        public Receita(int id, long documento, int parcela, DateTime vencimento, int diaVencimento, double valor, bool flagPago, string obs, DateTime dtCadastro, long idSocio)
        {
            Id = id;
            Documento = documento;
            Parcela = parcela;
            DataVencimento = vencimento;
            DiaVencimento = diaVencimento;
            Valor = valor;
            FlagPago = flagPago;
            Obs = obs;
            DataCadastro = dtCadastro;
            IdSocio = idSocio;
        }
    }
}
