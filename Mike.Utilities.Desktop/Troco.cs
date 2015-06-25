

using System;

namespace Mike.Utilities.Desktop
{
    public static class Troco
    {
        public static string GerarTroco(decimal valorPago, decimal valorDaComanda)
        {

            try
            {

                return  (valorPago - valorDaComanda).ToString("C2");

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
