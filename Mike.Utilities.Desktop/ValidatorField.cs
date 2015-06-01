
using System;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public class ValidatorField
    {
        /// <summary>
        /// Formato de dinheiro
        /// </summary>
        /// <param name="e">KeyPressEventArgs referente ao evento do metodo</param>
        public static void Money(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Só aceita inteiros
        /// </summary>
        /// <param name="e">KeyPressEventArgs referente ao evento do metodo</param>
        public static void Integer(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
        /// <summary>
        /// Só aceita numero e letras
        /// </summary>
        /// <param name="e">KeyPressEventArgs referente ao evento do metodo</param>
        public static void IntegerAndLetter(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Só aceita letrar
        /// </summary>
        /// <param name="e">KeyPressEventArgs referente ao evento do metodo</param>
        public static void Letter(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


      
        
		
    }

 
		
}
