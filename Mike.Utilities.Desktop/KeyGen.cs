using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class KeyGen
    {

        public static string GerarValor(Label lbl)
        {
            try
            {

                Random ramdom = new Random();
                string valor = ramdom.Next(100000000, 900000000).ToString();
                lbl.Text = valor ;
                return valor;
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
          public static decimal Validador(Label lbl)
        {
            try
            {
                decimal resultado = ((Convert.ToDecimal(lbl.Text) * Convert.ToDecimal(3.5)) + 666) / 5;
                return resultado;
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
