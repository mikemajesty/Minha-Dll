using System;
using System.IO;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class SaveInFile
    {

        public static void SaveComoTxt(string textoASerTransformadoEmTxt)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                   
                    sfd.Filter = "text files (*.txt)|*.txt";
                    sfd.FilterIndex = 2;
                    sfd.AddExtension = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string mike = null;
                        if (sfd.FileName.Contains(".txt"))
                        {
                            File.WriteAllText(mike != null ? mike : sfd.FileName, textoASerTransformadoEmTxt);
                        }
                        else
                        {
                            throw new Exception("Esse formato de arquivo não pode ter essa extensão");
                        }


                    }
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public static void SaveComoSnippet(string textoASerTransformadoEmSnippet)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {

                    sfd.Filter = "snippet files (*.snippet)|*.snippet";
                    sfd.FilterIndex = 2;
                    sfd.AddExtension = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string mike = null;
                        if (sfd.FileName.Contains(".txt"))
                        {
                            mike = sfd.FileName.Replace(".txt", ".snippet");
                        }

                        File.WriteAllText(mike != null ? mike : sfd.FileName, textoASerTransformadoEmSnippet);

                    }
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }



    }
}
