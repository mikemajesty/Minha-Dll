using System;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class ValorPago
    {
        public static  decimal ValorPagoPeloCliente(TextBox txt)
        {
            try
            {
                decimal valorPago = 0;
                valorPago = txt.Text == "" ? 0 : Convert.ToDecimal(txt.Text);
                return valorPago;

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
