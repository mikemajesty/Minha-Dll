using System;
using System.Data;
using System.Windows.Forms;
namespace Mike.Utilities.Desktop
{
    public static class ToXml
    {
        /// <summary>
        /// Abre um xml e joga para um DataTable
        /// </summary>
        /// <returns>Retorna uma tabela preenchida</returns>
        public static DataTable OpeXmlToDataTable()
        {
            try
            {
                var open = new OpenFileDialog();
                open.Filter = "xml files (*.xml)|*.xml";
                open.FilterIndex = 2;
                open.AddExtension = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var data = new DataSet())
                    {
                        var table = new DataTable();
                        data.ReadXml(open.FileName, XmlReadMode.Auto);
                        return table = data.Tables[0];
                       
                    }

                }
                return null;
               
            }
            catch (Exception)
            {

                throw new Exception("Xml corrompido!");
            }
        }
        /// <summary>
        /// Abre um echema em xml e joga para uma dataset que passa para um tabela
        /// </summary>
        /// <returns>Retorna a primeira tabela do schema</returns>
        public static DataTable OpenXsdSchemaToDataTable()
        {
            try
            {
                var open = new OpenFileDialog();
                open.Filter = "xsd files (*.xsd)|*.xsd";
                open.FilterIndex = 2;
                open.AddExtension = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (var data = new DataSet())
                    {
                        var table = new DataTable();
                        data.ReadXmlSchema(open.FileName);
                        return table = data.Tables[0];                       
                    }

                }
                return null;
               
            }
            catch (Exception)
            {

                throw new Exception("Xsd corrompido!");
            }
        }
        /// <summary>
        /// Escreve uma tabela para o formato xml, o xml se chama mikeescreve.xml
        /// </summary>
        /// <param name="table">A tabela a ser convertida</param>
        public static void CreateXmlFormDataTable(DataTable table)
        {
            try
            {
                if (table!= null)
                {
                    table.WriteXml("mikeescreve.xml");
                }
                else
                {
                    throw new Exception();
                }
               

            }
            catch (Exception)
            {

                throw new Exception("Xsd corrompido!");
            }
        }
        /// <summary>
        /// Escreve uma schema para o formato xml, o xml se chama mikeescreve.xml
        /// </summary>
        /// <param name="table">A tabela a ser convertida</param>
        public static void CreateXdsSchemaFromDataTable(DataTable table)
        {
            try
            {
                if (table != null)
                {
                    table.WriteXmlSchema("mikeescreve.xml");
                }
                else
                {
                    throw new Exception();
                }


            }
            catch (Exception)
            {

                throw new Exception("Xsd corrompido!");
            }
        }


    }
}
