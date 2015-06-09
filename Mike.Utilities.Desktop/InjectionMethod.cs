using System;
using System.Windows.Forms;
using System.Linq;
namespace Mike.Utilities.Desktop
{
   public static class InjectionMethod
    {
       public static string ToDataCerta(this DateTime data)
       {           
          return data.ToString("dd/MM/yyyy HH:mm:ss");
       }
       public static bool RetornaErro(this bool retorno,string erro)
       {
           throw new CustomException(erro);
       }
       public static void FocoNoTxt(this Form form,TextBox txt)
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
       public static Form FormException(this Form form,string erro)
       {
           throw new CustomException(erro);
          
       }
       public static string UpperCaseOnlyFirst(this string txt)
       {
           return txt.First().ToString().ToUpper() + String.Join("", txt.Skip(1)).ToLower();
       }
    }
}
