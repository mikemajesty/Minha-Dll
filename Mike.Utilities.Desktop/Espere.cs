using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mike.Utilities.Desktop
{
    public static class Espere
    {

        private static CancellationTokenSource ReferenciarNoCancellationToken()
        {
            var ts = new CancellationTokenSource();
            return ts;
        }
        public static CancellationToken ReferenciarNoTask()
        {

            CancellationToken ct = ReferenciarNoCancellationToken().Token;
            return ct;
        }

        public static void CancelarTask()
        {
            ReferenciarNoCancellationToken().Cancel();
        }




      
    }
}
