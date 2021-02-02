using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Models
{
    class Pagamento : Receita
    {
        public double Desconto { get; set; }
        public double Juros { get; set; }
        public double ValorDescJuros { get; set; }
        public double ValorPago { get; set; }
        public DateTime DataPagamento { get; set; }
        public string ObsPagamento { get; set; }        
        public long IdReceita { get; set; }

        public Pagamento()
        {
        }

        public Pagamento(long documento, DateTime dataVencimento, double valor, long idSocio, double desconto, double juros, 
            double valorDescJuros, double valorPago, DateTime dataPagamento, string obsPagamento, long idReceita) : base(documento, dataVencimento, valor,  idSocio)
        {
            Desconto = desconto;
            Juros = juros;
            ValorDescJuros = valorDescJuros;
            ValorPago = valorPago;
            DataPagamento = dataPagamento;
            ObsPagamento = obsPagamento;
            IdReceita = idReceita;
        }

        public Pagamento(long documento, DateTime dataVencimento, double valor, int idSocio, double desconto, double juros,
            double valorDescJuros, double valorPago, DateTime dataPagamento, string obsPagamento) : base(documento, dataVencimento, valor, idSocio)
        {
            Desconto = desconto;
            Juros = juros;
            ValorDescJuros = valorDescJuros;
            ValorPago = valorPago;
            DataPagamento = dataPagamento;
            ObsPagamento = obsPagamento;            
        }
    }
}
