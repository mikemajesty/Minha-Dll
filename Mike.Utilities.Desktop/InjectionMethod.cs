using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
namespace Mike.Utilities.Desktop
{
    public static class InjectionMethod
    {
        public static string ToDataCerta(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public static string ToDataCertaSemHora(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }
        public static bool RetornaErro(this bool retorno, string erro)
        {
            throw new CustomException(erro);
        }
        public static void FocoNoTxt(this Form form, TextBox txt)
        {
            form.ActiveControl = txt;
        }
        public static void FocoNoBotao(this Form form, Button btn)
        {
            form.ActiveControl = btn;
        }
        public static void FocoNoComboBox(this Form form, ComboBox cbb)
        {
            form.ActiveControl = cbb;
        }
        public static void FocoNoRadioButton(this Form form, RadioButton rdb)
        {
            form.ActiveControl = rdb;
        }
        public static Form FormException(this Form form, string erro)
        {
            throw new CustomException(erro);

        }
        public static string UpperCaseOnlyFirst(this string txt)
        {
            return txt.First().ToString().ToUpper() + String.Join("", txt.Skip(1)).ToLower();
        }
        public static char MostrarSenha(this TextBox txt)
        {
            return txt.PasswordChar = '\0';
        }
        public static void AjustartamanhoDoDataGridView(this DataGridView dgv, List<TamanhoGrid> tamanhoGrid)
        {
            foreach (var item in tamanhoGrid)
            {
                dgv.Columns[item.ColunaNome].Width = item.Tamanho;


            }

        }
        public static int ErroCustomForTernary(this int number, string erro)
        {
            throw new CustomException(erro);
        }
        public static void EsconderColuna(this DataGridView dgv, string comunName)
        {
            dgv.Columns[comunName].Visible = false;
        }
        public static void LimparTxtNoEventoChanged(this TextBox txt, EventHandler evento)
        {
            txt.TextChanged -= evento;
            txt.Clear();
            txt.TextChanged += evento;
        }
        public static void LimparTxt(this TextBox txt)
        {

            txt.Text = string.Empty;

        }
        public static void EsconderLinhaComUmaCor(this DataGridView dgv, Color color, string coluna)
        {

            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {

                    if (Convert.ToDecimal(row.Cells["Preço"].Value) <= 0)
                    {
                        row.Cells[coluna].Style.SelectionBackColor = color;
                        row.Cells[coluna].Style.SelectionForeColor = color;
                        row.Cells[coluna].Style.BackColor = color;
                        row.Cells[coluna].Style.ForeColor = color;
                    }

                }
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
        public static DateTime DataNoFormatoDate(this DateTime dtt)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        private static LinhaDoGrid GetInformacoesDoGrid(DataGridView dgv)
        {

            try
            {
                LinhaDoGrid linhaDoGrid = null;
                if (dgv.Rows.Count > 0)
                {

                    for (int contador = 0; contador < dgv.Rows.Count; ++contador)
                    {
                        linhaDoGrid = new LinhaDoGrid()
                        {
                            LucroTotal = Convert.ToDecimal(dgv.Rows[contador].Cells[1].Value),
                            ValorTotal = Convert.ToDecimal(dgv.Rows[contador].Cells[0].Value),
                            Quantidade = Convert.ToInt32(dgv.Rows[contador].Cells[2].Value)
                        };
                    }
                }
                return linhaDoGrid;
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
