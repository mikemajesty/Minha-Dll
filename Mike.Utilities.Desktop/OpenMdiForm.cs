using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class OpenMdiForm
    {
        /// <summary>
        /// Abre um form filho e fechar o filho que ja esta aberto
        /// </summary>
        /// <param name="formAtual">O form pai, o form que fez a chamada</param>
        /// <param name="formParaAbri">o form filho, que sera aberto pelo pai</param>
        public static void LoadNewFormCloseAnother(Form formAtual,Form formParaAbri)
        {
           
            foreach (Form item in Application.OpenForms)
            {
                if (item.IsMdiChild)
                {
                    item.Close();
                    break;
                }
            }
            Form formlulario = formParaAbri;
            formParaAbri.MdiParent = formAtual;
            formParaAbri.Show();
        }
        /// <summary>
        /// Abre o form se não estiver aberto, se ja estiver da o foco ao mesmo. Abre este filho e mantem o outro filho 
        /// </summary>
        /// <param name="formAtual">O form pai, o form que fez a chamada</param>
        /// <param name="formParaAbri">o form filho, que sera aberto pelo pai</param>
        public static void LoadNewKeepAnother(Form formAtual, Form formParaAbri)
        {
            foreach (Form form in Application.OpenForms)
            {

                if (form.GetType() == formParaAbri.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            Form formlulario = formParaAbri;
            formParaAbri.MdiParent = formAtual;
            formParaAbri.Show();
        }
        /// <summary>
        /// Abre um form chamado usando o metodo Show
        /// </summary>
        /// <param name="formParaAbrir">Form que sera aberto</param>
        public static void OpenForWithShow(Form formParaAbrir,Form formParaFechar)
        {
            formParaAbrir.Show();
            formParaFechar.Hide();
        }
        /// <summary>
        /// Abre um form chamado usando o metodo ShowDialog
        /// </summary>
        /// <param name="formParaAbrir">Form que sera aberto</param>
        public static DialogResult OpenForWithShowDialog(Form formParaAbrir)
        {
            Form formulario = formParaAbrir;
            return formulario.ShowDialog();
        }
      
    }
}
