using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class GerenciarControles
    {
        private const bool Mostrar = true;
        private const bool Esconder = false;
        public static void LimparTxt(List<TextBox> txtList)
        {
            try
            {

                foreach (var txt in txtList)
                {
                    txt.Text = string.Empty;
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
        public static void EsconderGroupBoxOuMostrar(List<GroupBox> listGpb, bool esconderOuMostrar)
        {

            try
            {

                foreach (var gpb in listGpb)
                {
                    if (gpb is GroupBox)
                    {
                        if (esconderOuMostrar == Esconder)
                        {
                            gpb.Visible = Esconder;
                        }
                        else
                        {
                            gpb.Visible = Mostrar;
                        }
                    }
                }

            }
            catch (CustomException erro)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(erro.Message, "Aviso");
            }
            catch (Exception erro)
            {
                DialogMessage.MessageComButtonOkIconeErro(erro.Message, "Erro");
            }

        }




        
    }
}
