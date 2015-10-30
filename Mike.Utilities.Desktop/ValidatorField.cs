
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
        public static void NoVirgula(KeyPressEventArgs e, object sender)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if ((sender as TextBox).Text.Contains(",") || (sender as TextBox).Text.Length == 0)
                    e.Handled = true; // Caso exista, aborte 

            }

        }

        public static void NoSpace(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }

        }
        public static void AllowOneSpaceTogether(KeyPressEventArgs e, object sender)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }
        }
        /// <summary>
        /// Desabilita o tab no datagridview, esse evento tem que ser chamado no KeyDown
        /// </summary>
        /// <param name="sender">o próprio datagridview, como sobrecarga do metodo KeyDowb</param>
        /// <param name="e">o evento em si</param>
        public static void DisableTabInGrid(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (sender as DataGridView);
            if (e.KeyCode == Keys.Tab)
            {
                dgv.Enabled = false;
                dgv.GetNextControl(dgv, true).Focus();
                dgv.Enabled = true;
                e.Handled = true;
            }
        }

        public static void Peso(KeyPressEventArgs e, object sender)
        {

            if ((sender as TextBox).Text.Length <= 5)
            {


                string n = string.Empty;
                double v = 0;

                n = (sender as TextBox).Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "00";

                n = n.PadLeft(4, '0');
                if (n.Length < 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;
                (sender as TextBox).Text = string.Format("{0:N2}", v);
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
        }
        public static void MoneyTeste(KeyPressEventArgs e, object sender)
        {

            if ((sender as TextBox).Text.Contains(","))
            {
                if ((sender as TextBox).Text.IndexOf(" ") != -1)
                {
                    var money = (sender as TextBox).Text.Substring(0, (sender as TextBox).Text.IndexOf(" ") - 1);
                    (sender as TextBox).Text = String.Format("{0:D0}", money);
                }
                (sender as TextBox).Text = ""; // Tod
            }
        }
    }


}
