

using System;

namespace Mike.Utilities.Desktop
{
    public static class Troco
    {
        public static string GerarTroco(decimal valorPago, decimal valorDaComanda)
        {

            try
            {
            

                decimal retorno = 0;
                if (valorPago == 0)
                {
                    return retorno.ToString("C2");
                }
                if (valorPago >= valorDaComanda )
                {
                    retorno =  (valorPago - valorDaComanda);
                }

                return retorno.ToString("C2");

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
