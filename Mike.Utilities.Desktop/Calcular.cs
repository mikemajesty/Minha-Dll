using System;
using System.Windows.Forms;
using System.Linq;
namespace Mike.Utilities.Desktop
{
    public static class Calcular
    {
        public static string CalcularPorcentagem(TextBox txtPrecoCompra, TextBox txtPrecoVenda)
        {
            try
            {
                decimal _precoVenda = 0, _preconCompra = 0;
                string retorno = "00";

                if (txtPrecoVenda.Text.Trim().Length > 0 && txtPrecoCompra.Text.Trim().Length > 0)
                {
                    _precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                    _preconCompra = Convert.ToDecimal(txtPrecoCompra.Text);
                    decimal porcentagemDecimal = 0;
                    porcentagemDecimal = _precoVenda / _preconCompra * 100;
                    int porcentagem = Convert.ToInt32(porcentagemDecimal);
                    decimal.Floor(porcentagem);
                    if (_precoVenda > _preconCompra)
                    {
                        retorno = string.Format("{0}", porcentagem).Length == 1 ? "0" : string.Format("{0}", porcentagem);

                    }
                }  
                return retorno;
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }


        }
        public static int TratarStringDePorcentagem(TextBox txt)
        {
            try
            {
                

                if (txt.Text.Contains(",")||txt.Text.Contains("%")||txt.Text.Contains("."))
                {
                    int index = txt.Text.LastIndexOf(',');
                    string resultado = txt.Text.Substring(0, index);
                    if (resultado.Contains('.'))
                    {
                        resultado = resultado.Replace(".", "");
                    }
                    return Convert.ToInt32(resultado);
                }
                else
                {
                    return Convert.ToInt32(txt.Text);
                }
            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
