using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Utilities.Desktop
{
    public class CustomException : Exception
    {
        public CustomException(string ClasseComOErro)
            : base(ClasseComOErro)
        {

        }
    }
}
