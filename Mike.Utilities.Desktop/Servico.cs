using System;
using System.ServiceProcess;

namespace Mike.Utilities.Desktop
{
    public static class Servico
    {
        public static string StartServico(string instanceName)
        {

            try
            {
                string myServiceName = $"MSSQL${instanceName}";
                
                ServiceController mySC = new ServiceController(myServiceName);
                if (mySC.Status.Equals(ServiceControllerStatus.Stopped) | mySC.Status.Equals(ServiceControllerStatus.StopPending))
                {
                    mySC.Start();
                    mySC.WaitForStatus(ServiceControllerStatus.Running);                    
                }

                return mySC.Status.ToString();


            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
    }
}
