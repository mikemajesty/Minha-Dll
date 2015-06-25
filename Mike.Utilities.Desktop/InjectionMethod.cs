using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
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
        public static int ErroCustomForTernary(this int number,string erro)
        {
            throw new CustomException(erro);
        } 
         public static void EsconderColuna(this DataGridView dgv,string comunName)
        {
            dgv.Columns[comunName].Visible = false;
        } 
    }
}
