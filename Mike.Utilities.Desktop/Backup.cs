using System;
using System.IO;
using System.Data.Entity;

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
                string caminho = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\" + folder + subFolder).FullName;

                Directory.CreateDirectory(caminho);
                string sql = "BACKUP DATABASE " + data.Database.Connection.Database + " to Disk = '"
                    + caminho + @"\"
                   + data.Database.Connection.Database +
                   ".bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of jiradb'";

                sql = sql.Replace(@"\\", @"\");
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
