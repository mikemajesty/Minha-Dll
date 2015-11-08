using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Mike.Utilities.Desktop
{
    public class MyReport
    {
        private ReportViewer reportViewer;
        private List<ReportParameter> listParameter;
        private byte[] bytePDF { get; set; }
        Warning[] warnings;
        string[] streamids;
        string mimeType;
        string encoding;
        string extension;
        //----------------------------------------------------------------------------------------------------//
        public void GerarRelatoriosComParametrosEQueryDefinidosNaQueryPDF(List<ReportParameter> listParameter, string nomeRelatorio = "Relatorio")
        {

            try
            {
                
                reportViewer.LocalReport.SetParameters(listParameter);
                byte[] bytePDF = reportViewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = null;
                nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);

            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }


        }
        public void GerarRelatoriosComParametrosEQueryDefinidosNaQueryWord(List<ReportParameter> listParameter, string nomeRelatorio = "Relatorio")
        {

            try
            {

                reportViewer.LocalReport.SetParameters(listParameter);
                byte[] bytePDF = reportViewer.LocalReport.Render("Word", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = null;
                nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".doc";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);

            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }


        }
        public void GerarRelatoriosComParametrosEQueryDefinidosNaQueryExcel(List<ReportParameter> listParameter, string nomeRelatorio = "Relatorio")
        {

            try
            {

                reportViewer.LocalReport.SetParameters(listParameter);
                byte[] bytePDF = reportViewer.LocalReport.Render("Excel", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = null;
                nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".xls";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);

            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }


        }
        //----------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Esse construtor é feito para usar relatorios somente com parametros
        /// </summary>
        /// <param name="nomeArquivoComExtensao">Nome do relatorio com sua extensão</param>
        public MyReport(string nomeArquivoComExtensao)
        {
            reportViewer = new ReportViewer();
            listParameter = new List<ReportParameter>();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            /*reportViewer.LocalReport.ReportEmbeddedResource ="Mike.Utilities.Desktop.teste.rdlc";  
            se for rodar no mesmo assembly
            */           
            reportViewer.LocalReport.ReportPath = nomeArquivoComExtensao;
            
        }
        public void GerarRelatoriosApenasComParametrosExcel(List<ReportParameter> listParameter, string nomeRelatorio = "Relatorio")
        {

            try
            {
                reportViewer.LocalReport.SetParameters(listParameter);
                byte[] bytePDF = reportViewer.LocalReport.Render("Excel", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".xls";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

           
        }
        public void GerarRelatoriosApenasComParametrosWord(List<ReportParameter> listParameter, string nomeRelatorio = "Relatorio")
        {


            try
            {

                reportViewer.LocalReport.SetParameters(listParameter);
                byte[] bytePDF = reportViewer.LocalReport.Render("Word", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".doc";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }


        }
        public void GerarRelatoriosApenasComParametrosPDF(List<ReportParameter> listParameter, string nomeRelatorio = "Relatorio")
        {

            try
            {

                reportViewer.LocalReport.SetParameters(listParameter);
                byte[] bytePDF = reportViewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

        }

        //------------------------------------------Com Entity Framework-------------------------------------------------------------//
        /// <summary>
        /// Esse construtor é feito para usar somente com o entity framework
        /// </summary>
        /// <param name="_query">Query com a consulta necessaria, exemplo, Banco.Usuario.ToList()</param>
        /// <param name="nomeArquivoComExtensao">Nome do relatorio com sua extensão</param>
        /// <param name="nomeTabela">Nome da tabela que sera usada no relatorio</param>
        /// <param name="processingMode">Tipo de processamento, se vai ser local ou remoto</param>
        public MyReport(IEnumerable _query, string nomeArquivoComExtensao, string nomeTabela, ProcessingMode processingMode)
        {

            try
            {

                reportViewer = new ReportViewer();
                reportViewer.ProcessingMode = processingMode;
                /*reportViewer.LocalReport.ReportEmbeddedResource ="Mike.Utilities.Desktop.teste.rdlc";  
                se for rodar no mesmo assembly
                */

                reportViewer.LocalReport.ReportPath = nomeArquivoComExtensao;
                var list = new ReportDataSource(name: nomeTabela, dataSourceValue: _query);
                reportViewer.LocalReport.DataSources.Add(list);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

        }
        public void GerarRelatoriosComParametrosDefinidosNaQueryPDF(string nomeRelatorio = "Relatorio")
        {

            try
            {
                byte[] bytePDF = reportViewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = null;
                nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }


        }
        public void GerarRelatoriosComParametrosDefinidosNaQueryWord(string nomeRelatorio = "Relatorio")
        {

            try
            {
                byte[] bytePDF = reportViewer.LocalReport.Render("Word", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = null;
                nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".doc";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
        }
        public void GerarRelatoriosComParametrosDefinidosNaQueryExcel(string nomeRelatorio = "Relatorio")
        {

            try
            {
                byte[] bytePDF = reportViewer.LocalReport.Render("Excel", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                FileStream fileStream = null;
                string nomeArquivo = null;
                nomeArquivo = Path.GetTempPath() + nomeRelatorio + "-" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".xls";
                fileStream = new FileStream(nomeArquivo, FileMode.Create);
                fileStream.Write(bytePDF, 0, bytePDF.Length);
                fileStream.Close();
                Process.Start(nomeArquivo);
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
        }
    }
}
