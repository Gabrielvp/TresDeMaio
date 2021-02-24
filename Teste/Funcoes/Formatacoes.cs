using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Funcoes
{
    static class Formatacoes
    {
        public static string FormataDataSql(string data)
        {
            return data.ToString().Substring(6, 4) + "-" + data.ToString().Substring(3, 2) + "-" + data.ToString().Substring(0, 2); ;
        }
    }
}
