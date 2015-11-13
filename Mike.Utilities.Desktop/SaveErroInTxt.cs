using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Utilities.Desktop
{
    public static class SaveErroInTxt
    {
        private static SalvarNoDropBox salvarNoDropBox;
        public static bool RecordInTxtWithDialog()
        {
            try
            {
              
                return true;
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public static bool RecordInTxt(Exception erro, string ClasseComOErro)
        {
            try
            {
                StringBuilder mike = new StringBuilder();

                mike.AppendLine("\nMenssage: " + erro.Message);
                mike.AppendLine("\nData: " + erro.Data);
                mike.AppendLine("\nHelpLink: " + erro.HelpLink);
                mike.AppendLine("\nHResult: " + erro.HResult);
                mike.AppendLine("\nInnerException: " + erro.InnerException);
                mike.AppendLine("\nSource: " + erro.Source);
                mike.AppendLine("\nStackTrace: " + erro.StackTrace);
                mike.AppendLine("\nTargetSite: " + erro.TargetSite);
                mike.AppendLine("\nType: " + erro.GetType());
                string folder = @"ApplcationErrors\" + ClasseComOErro;
                string subFolder = string.Format("{0}-{1}-{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year.ToString("0000"));
                if (!Directory.Exists(folder))
                {
                    if (!Directory.Exists(subFolder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    if (!Directory.Exists(folder + @"\" + subFolder))
                    {
                        Directory.CreateDirectory(folder + @"\" + subFolder);
                    }
                    Directory.CreateDirectory(folder);
                    string hora = string.Format(@"{0}\{8}\Data {1}-{2}-{3} - Hora [{4}-{5}-{6}]{7}", folder, DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year.ToString("0000"), DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"), ".txt", subFolder);
                    salvarNoDropBox = new SalvarNoDropBox(Properties.Settings.Default.NomePadaria + "/" + ClasseComOErro,DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_") + ".txt", erro);
                    salvarNoDropBox.Executar();
                    File.AppendAllText(hora, mike.ToString(), Encoding.UTF8);
                }
                else
                {

                   
                    if (!Directory.Exists(folder + @"\" + subFolder))
                    {
                        Directory.CreateDirectory(folder + @"\" + subFolder);
                    }
                    string hora = string.Format(@"{0}\{8}\Data {1}-{2}-{3} - Hora [{4}-{5}-{6}]{7}", folder, DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year.ToString("0000"), DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"), ".txt", subFolder);
                    salvarNoDropBox = new SalvarNoDropBox(Properties.Settings.Default.NomePadaria+"/"+ClasseComOErro,DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_")+".txt", erro);
                    salvarNoDropBox.Executar();
                    File.AppendAllText(hora, mike.ToString(), Encoding.UTF8);
                }
                return true;

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

    }
}
