using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class GerenciarGroupBox
    {
        private const bool Mostrar = true;
        private const bool Esconder = false;
        /// <summary>
        /// Metodo para esconder ou mostrar um GroupBox
        /// </summary>
        /// <param name="gpb">Nome do GroupBox</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar um GroupBox, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrar(GroupBox gpb, bool esconderOuMostrar = Esconder) => gpb.Visible = esconderOuMostrar;
        /// <summary>
        /// Metodo para esconder ou mostrar uma lista de GroupBox
        /// </summary>
        /// <param name="listGpb">Nome do GroupBox</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar uma lista de GroupBox, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrarMuitos(List<GroupBox> listGpb, bool esconderOuMostrar)
            => listGpb.OfType<GroupBox>().ToList().ForEach(c => c.Visible = esconderOuMostrar == Esconder ? Esconder : Mostrar);
        /// <summary>
        /// Metodo para mudar o tamanho do GroupBox
        /// </summary>
        /// <param name="gpb">Nome do GroupBox</param>
        /// <param name="size">Tamanho a ser atribuido ao GroupBox</param>
        public static void MudarTamanho(GroupBox gpb, Size size) => gpb.Size = size;
        /// <summary>
        /// Metodo para mudar a localização do GroupBox
        /// </summary>
        /// <param name="gpb">Nome do GrouoBox</param>
        /// <param name="location">Localização a ser atribuida ao GroupBox</param>
        public static void MudarPosicao(GroupBox gpb, Point location) => gpb.Location = location;
        public static void DesabilitarOuHabilitar(GroupBox gpb, bool desabilitarOuHabilitar = false) => gpb.Enabled = desabilitarOuHabilitar;

        public static void DesabilitarOuHabilitarMuitos(List<GroupBox> gpb, bool desabilitarOuHabilitar = false) => gpb.ForEach(c => c.Enabled = desabilitarOuHabilitar);
    }
    public static class GerenciarTextBox
    {
        private const bool Mostrar = true;
        private const bool Esconder = false;
        /// <summary>
        /// Metodo para esconder ou mostrar um TextBox
        /// </summary>
        /// <param name="txt">O nome do TextBox</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar um TextBox, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrar(TextBox txt, bool esconderOuMostrar = Esconder) => txt.Visible = esconderOuMostrar;
        /// <summary>
        /// Metodo para esconder ou mostrar uma lista de TextBox
        /// </summary>
        /// <param name="listtxt">Uma lista de TextBox</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar uma Lista de TextBox, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrarMuitos(List<TextBox> listtxt, bool esconderOuMostrar = Esconder)
          => listtxt.OfType<TextBox>().ToList().ForEach(c => c.Visible = esconderOuMostrar == Esconder ? Esconder : Mostrar);
        /// <summary>
        /// Metodo para mudar o tamnho de um TextBox
        /// </summary>
        /// <param name="txt">O nome do TextBox</param>
        /// <param name="size">O tamanho a ser mudado</param>
        public static void MudarTamanho(TextBox txt, Size size) => txt.Size = size;
        /// <summary>
        /// Metodo para mudar o tamanho do TextBox
        /// </summary>
        /// <param name="txt">O nome do TextBox</param>
        /// <param name="location">A localização a ser adicionado</param>
        public static void MudarPosicao(TextBox txt, Point location) => txt.Location = location;
        public static void DesabilitarOuHabilitar(TextBox txt, bool desabilitarOuHabilitar = false) => txt.Enabled = desabilitarOuHabilitar;
        public static void DesabilitarOuHabilitarMuitos(List<TextBox> gpb, bool desabilitarOuHabilitar = false) => gpb.ForEach(c => c.Enabled = desabilitarOuHabilitar);
    }
    public static class GerenciarButton
    {
        private const bool Mostrar = true;
        private const bool Esconder = false;
        /// <summary>
        /// Metodo para esconder ou mostrar um Button
        /// </summary>
        /// <param name="btn">O nome do Button</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar um Button, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrar(Button btn, bool esconderOuMostrar = Esconder) => btn.Visible = esconderOuMostrar;
        /// <summary>
        /// Metodo para esconder ou mostrar uma lista de Button
        /// </summary>
        /// <param name="listbtn">Nome da lista de Button</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar uma Lista de Button, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrarMuitos(List<Button> listbtn, bool esconderOuMostrar = Esconder)
          => listbtn.OfType<Button>().ToList().ForEach(c => c.Visible = esconderOuMostrar == Esconder ? Esconder : Mostrar);
        /// <summary>
        /// Metodo para mudar o tamanho do Button
        /// </summary>
        /// <param name="btn">Nome do button</param>
        /// <param name="size">Tamanho a ser atribuido</param>
        public static void MudarTamanho(Button btn, Size size) => btn.Size = size;
        /// <summary>
        /// Metodo para mudar a posicao do Button
        /// </summary>
        /// <param name="btn">Nome do Button</param>
        /// <param name="location">A localização a ser atribuida</param>
        public static void MudarPosicao(Button btn, Point location) => btn.Location = location;
        public static void DesabilitarOuHabilitar(Button btn, bool desabilitarOuHabilitar = false) => btn.Enabled = desabilitarOuHabilitar;
        public static void DesabilitarOuHabilitarMuitos(List<Button> gpb, bool desabilitarOuHabilitar = false) => gpb.ForEach(c => c.Enabled = desabilitarOuHabilitar);
    }
    public static class GerenciarComboBox
    {
        private const bool Mostrar = true;
        private const bool Esconder = false;
        public static void DesabilitarOuHabilitarMuitos(List<ComboBox> gpb, bool desabilitarOuHabilitar = false) => gpb.ForEach(c => c.Enabled = desabilitarOuHabilitar);
        public static void DesabilitarOuHabilitar(ComboBox gpp, bool desabilitarOuHabilitar = false) => gpp.Enabled = desabilitarOuHabilitar;
        /// <summary>
        /// Metodo para esconder ou mostrar um ComboBox
        /// </summary>
        /// <param name="btn">O nome do ComboBox</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar um ComboBox, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrar(ComboBox btn, bool esconderOuMostrar = Esconder) => btn.Visible = esconderOuMostrar;
        /// <summary>
        /// Metodo para esconder ou mostrar uma lista de ComboBox
        /// </summary>
        /// <param name="listbtn">Nome da lista de ComboBox</param>
        /// <param name="esconderOuMostrar">Parametro booleano para esconder ou mostrar uma Lista de ComboBox, o parametro padrão é Esconder </param>
        public static void EsconderOuMostrarMuitos(List<ComboBox> listbtn, bool esconderOuMostrar = Esconder)
          => listbtn.OfType<ComboBox>().ToList().ForEach(c => c.Visible = esconderOuMostrar == Esconder ? Esconder : Mostrar);
        /// <summary>
        /// Metodo para mudar o tamanho do ComboBox
        /// </summary>
        /// <param name="btn">Nome do ComboBox</param>
        /// <param name="size">Tamanho a ser atribuido</param>
        public static void MudarTamanho(ComboBox btn, Size size) => btn.Size = size;
        /// <summary>
        /// Metodo para mudar a posicao do ComboBox
        /// </summary>
        /// <param name="btn">Nome do ComboBox</param>
        /// <param name="location">A localização a ser atribuida</param>
        public static void MudarPosicao(ComboBox btn, Point location) => btn.Location = location;
    }
    public static class GerenciarForm
    {
        public static void MudarTamanho(Form frm, Size size) => frm.Size = size;
    }
}
