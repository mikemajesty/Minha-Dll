using System;
using System.IO;
using System.Data.Entity;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class Backup
    {
        public static int GerarBeckup(DbContext data)
        {
            try
            {
                string folder = @"Backup\";
                string subFolder = string.Format("{0}-{1}-{2}"
                                 , DateTime.Now.Day.ToString("00"),
                                  DateTime.Now.Month.ToString("00"),
                                  DateTime.Now.Year.ToString("0000"));
                string caminho = Application.StartupPath + @"\" + folder + subFolder;
                Directory.CreateDirectory(caminho);
                string sql = "BACKUP DATABASE " + data.Database.Connection.Database + @" to Disk = '" + caminho + @"\" + data.Database.Connection.Database + ".bak' WITH FORMAT, MEDIANAME = 'Mike Rodrigues De Lima', NAME = 'Full Backup'";
                var dados = data.Database.ExecuteSqlCommand(transactionalBehavior: System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, sql: sql);
                return dados;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
