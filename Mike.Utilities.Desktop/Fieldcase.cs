using System;
using System.Linq;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
     public static  class FieldCase
    {
         /// <summary>
         /// Deixa somente a primeira letra em maiuscul
         /// </summary>
         /// <param name="txt">textBox, não precisa da propeiedade text</param>
         /// <param name="mininumSize">Mininum de tamanho que  a string tem q ter</param>
         /// <returns>O valor final, se ele passar pelo if</returns>
         public static string UpperCaseOnlyFirst(TextBox txt , int mininumSize = 1)
         {
            return txt.Text.Length >= mininumSize ? txt.Text.First().ToString().ToUpper() + String.Join("", txt.Text.Skip(1)).ToLower() : "";
         }
         /// <summary>
         /// Deixa todas as letras maiusculas
         /// </summary>
         /// <param name="txt">textBox, não precisa da propeiedade text</param>
         /// <param name="mininumSize">Mininum de tamanho que  a string tem q ter</param>
         /// <returns>O valor final, se ele passar pelo if</returns>
         public static string UppeCaseAll(TextBox txt, int mininumSize = 1)
         {
             return txt.Text.Length >= mininumSize ? txt.Text.ToString().ToUpper() : "";
         }
         /// <summary>
         /// Deixa todas as letras minusculas
         /// </summary>
         /// <param name="txt">textBox, não precisa da propeiedade text</param>
         /// <param name="mininumSize">Mininum de tamanho que  a string tem q ter</param>
         /// <returns>O valor final, se ele passar pelo if</returns>
         public static string LowerCaseAll(TextBox txt, int mininumSize = 1)
         {
             return txt.Text.Length >= mininumSize ? txt.Text.ToString().ToLower() : "";
         }
    }
}
