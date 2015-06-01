using System;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class DialogMessage
    {
        /// <summary>
        /// Dialog full com button [s/n] e icone de interrogação
        /// </summary>
        /// <param name="message">Menssagem que sera exibida aoa usúario</param>
        /// <param name="title">Titulo da menssage exibida ao usúario</param>
        /// <returns>Retorna a resposta do usuaio [s/n] para servir de validação na classe cliente</returns>
        public static DialogResult MessageFullQuestion(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        /// <summary>
        /// Dialog com butão de ok com icone de Erro
        /// </summary>
        /// <param name="message">Menssagem que sera exibida aoa usúario</param>
        /// <param name="title">Titulo da menssage exibida ao usúario</param>
        /// <returns>Retorna a menssagem a ser exibida</returns>
        public static DialogResult MessageComButtonOkIconeErro(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Dialog com butão de ok com icone de aviso
        /// </summary>
        /// <param name="message">Menssagem que sera exibida aoa usúario</param>
        /// <param name="title">Titulo da menssage exibida ao usúario</param>
        /// <returns>Retorna a menssagem a ser exibida</returns>
        public static DialogResult MessageFullComButtonOkIconeDeInformacao(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Menssage customizada atraves de uma classe DialogCustom, pode criar 
        /// uma classe da sua forma
        /// </summary>
        /// <param name="menssage">Objeto DialogCustom com todos os campos necessarioa
        /// <returns>Retorna uma menssagem customizada ao usuario</returns>
        public static DialogResult MessageCustom(DialogCustom menssage)
        {
            return MessageBox.Show(menssage.Message
                                  , menssage.Title
                                  , menssage.Button
                                  , menssage.Icon);
        }

    }
}
