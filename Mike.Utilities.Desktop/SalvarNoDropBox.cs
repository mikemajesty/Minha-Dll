using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mike.Utilities.Desktop
{
    public class SalvarNoDropBox
    {
        private string _nomePasta, _arquivo;
        private Exception _error;
        public SalvarNoDropBox(string nomePasta, string arquivo, Exception error)
        {
            _nomePasta = nomePasta;
            _arquivo = arquivo;
            _error = error;

        }
        public void Executar()
        {

            try
            {
                if (CheckForInternetConnection())
                {
                    var task = Task.Run((Func<Task>)Salvar);
                    task.Wait();
                }
              
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
        private async Task Upload(DropboxClient dbx, string folder, string file, string content)
        {
            try
            {


                using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    var updated = await dbx.Files.UploadAsync(
                        folder + "/" + file,
                        WriteMode.Overwrite.Instance,
                        body: mem);
                    Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev);
                }
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
        private async Task Salvar()
        {

            try
            {

                StringBuilder errorFull = new StringBuilder();

                errorFull.AppendLine("\nMenssage: " + _error.Message);
                errorFull.AppendLine("\nData: " + _error.Data);
                errorFull.AppendLine("\nHelpLink: " + _error.HelpLink);
                errorFull.AppendLine("\nHResult: " + _error.HResult);
                errorFull.AppendLine("\nInnerException: " + _error.InnerException);
                errorFull.AppendLine("\nSource: " + _error.Source);
                errorFull.AppendLine("\nStackTrace: " + _error.StackTrace);
                errorFull.AppendLine("\nTargetSite: " + _error.TargetSite);
                errorFull.AppendLine("\nType: " + _error.GetType());
                using (var dbx = new DropboxClient("-uucI6ot5T0AAAAAAAABsR5u-6mB7He6gT08gxEny8XZHjHdhZp8nzVFE1tcpYuX"))
                {
                    var full = await dbx.Users.GetCurrentAccountAsync();
                    await Upload(dbx, "/" + _nomePasta, _arquivo, errorFull.ToString());
                }

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

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
