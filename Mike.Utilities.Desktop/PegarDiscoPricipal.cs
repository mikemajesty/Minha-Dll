using System;
using System.IO;

namespace Mike.Utilities.Desktop
{
    public class PegarDiscoPricipal
    {


        public static string GetPrimaryDisk()
        {
            try
            {
                return Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
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
