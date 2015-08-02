using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public class Espere
    {
        private CancellationTokenSource ReferenciarNoCancellationToken { get; set; }
        public CancellationToken Cancel { get; set; }

        public Espere()
        {
            ReferenciarNoCancellationToken = new CancellationTokenSource();
            Cancel = ReferenciarNoCancellationToken.Token;
        }
        private CancellationToken ReferenciarNoTask()
        {
            try
            {
                CancellationToken ct = ReferenciarNoCancellationToken.Token;
                return ct;
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
         
        }

        public void CancelarTask()
        {
            try
            {
                ReferenciarNoCancellationToken.Cancel();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
           
        }
        public void Start(Action action)
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                new Task(action, Cancel).Start();
            }
            catch (Exception erro)
            {
                
                throw new Exception(erro.Message);
            }
          
        }




    }
}
