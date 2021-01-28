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
        public long IdSocio { get; set; }

        public Receita()
        {
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

        public Receita(int id, long documento, int parcela, DateTime vencimento, int diaVencimento, double valor, bool flagPago, string obs, long idSocio)
        {
            Id = id;
            Documento = documento;
            Parcela = parcela;
            DataVencimento = vencimento;
            DiaVencimento = diaVencimento;
            Valor = valor;
            FlagPago = flagPago;
            Obs = obs;
            IdSocio = idSocio;
        }      
    }
}
