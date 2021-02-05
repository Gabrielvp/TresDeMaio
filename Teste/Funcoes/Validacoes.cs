using System;

namespace Teste.Funcoes
{
    class Validacoes
    {
        public bool ValidaData(string date)
        {
            bool validou;
            bool ehBissexto = false;
            string dia;
            string mes;
            string ano;
            dia = date.Substring(0, 2);
            mes = date.Substring(3, 2);
            ano = date.Substring(6, 4);

            if (DateTime.IsLeapYear(int.Parse(ano)))
            {
                ehBissexto = true;
            }

            switch (int.Parse(mes))
            {
                case 1:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 2:
                    if (ehBissexto)
                    {
                        if (int.Parse(dia) > 29)
                        {
                            validou = false;
                            break;
                        }
                    }
                    else
                    {
                        if (int.Parse(dia) > 28)
                        {
                            validou = false;
                            break;
                        }
                    }
                    validou = true;
                    break;
                case 3:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 4:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 5:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 6:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 7:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 8:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 9:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 10:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 11:
                    if (int.Parse(dia) > 30)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                case 12:
                    if (int.Parse(dia) > 31)
                    {
                        validou = false;
                        break;
                    }
                    validou = true;
                    break;
                default:
                    validou = false;
                    break;
            }
            return validou;
        }
    }
}
