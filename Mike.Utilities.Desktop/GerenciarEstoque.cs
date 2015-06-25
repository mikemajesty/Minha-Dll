using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class GerenciarEstoque
    {
       /* private void DarBaixaNoEstoque(ListView ltv)
        {

            try
            {

                foreach (ListViewItem lstItem in ltv.Items)
                {
                    Produto produto = _produtoRepositorio.GetProdutoPorCodigoUnidade(lstItem.SubItems[1].Text);
                    if (produto != null)
                    {
                        Estoque estoque = new Estoque() { ProdutoCodigo = lstItem.SubItems[1].Text, Quantidade = Convert.ToInt32(lstItem.SubItems[2].Text) };
                        _estoqueRepositorio.DarBaixa(produto, estoque);

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


        }*/

    }
}
