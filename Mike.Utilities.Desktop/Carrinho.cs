using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Utilities.Desktop
{
    public class Carrinho
    {

        public bool MyMethod()
        {
            try
            {
                return true;
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
