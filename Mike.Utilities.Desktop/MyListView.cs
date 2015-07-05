﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class MyListView
    {

        public static bool RemoverItem(ListView ltvProdutos)
        {
            try
            {
                bool retorno = false;
                for (int i = 0; i < ltvProdutos.Items.Count; i++)
                {
                    if (ltvProdutos.Items[i].Selected)
                    {
                        ltvProdutos.Items[i].Remove();
                        i--;
                        retorno = true;
                    }
                }
                return retorno;
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

     
        public static void ColumnWidthChanging(ColumnWidthChangingEventArgs e, ListView ltv)
        {
            try
            {

                e.Cancel = true;
                e.NewWidth = ltv.Columns[e.ColumnIndex].Width;

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

        public static string RetornarValorPeloIndexDaColuna(ListView ltv, int indiceDaListView)
        {
            try
            {

                ListViewItem item = ltv.SelectedItems[0];
                return item.SubItems[indiceDaListView].Text;

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

        public static decimal GetValorNaComanda(ListView ltv,int indexDaColunaDoValorASerSomado,Label lblParaExibirValor)
        {

            try
            {

                decimal sum = 0;
                foreach (ListViewItem lstItem in ltv.Items)
                {

                    sum += decimal.Parse(lstItem.SubItems[indexDaColunaDoValorASerSomado].Text);
                }


                lblParaExibirValor.Text = sum.ToString("C2");
              
                return sum;
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
        public static decimal GetValorLucroTotal(ListView ltv,int indexDaColunaOndeOLucroEsta)
        {

            try
            {

                decimal lucro = 0;
                foreach (ListViewItem lstItem in ltv.Items)
                {

                    lucro += decimal.Parse(lstItem.SubItems[indexDaColunaOndeOLucroEsta].Text);
                }



                return lucro;
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



        public static int VerificarSeExisteItensNoListView(ListView ltv)
        {

            try
            {
                return ltv.Items.Count;


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

        public static List<BaixarEstoque> RetornarValoresParaDarBaixaNoEstoque(ListView ltv, 
            int indiceDoCodigo = 1, 
            int indexDaQuantidade = 2,
            int indexDoValorTotal = 3,
            int indexDoLucroTotal = 4)
        {
            try
            {
                List<BaixarEstoque> estoqueList = new List<BaixarEstoque>();
                foreach (ListViewItem lstItem in ltv.Items)
                {
                    estoqueList.Add(new BaixarEstoque()
                    {
                        Codigo = lstItem.SubItems[1].Text,
                        Quantidade = lstItem.SubItems[2].Text != "Peso" ? Convert.ToInt32(lstItem.SubItems[2].Text) : 0,
                        LucroTotal = decimal.Parse(lstItem.SubItems[4].Text),
                        ValorTotal = decimal.Parse(lstItem.SubItems[3].Text)
                    });

                }

                return estoqueList;

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
        /*private static void AdicionarItensNoListView(ListView ltv, IQueryable<dynamic> _venda)
        {

            try
            {

                ListViewItem listView;


                if (ltv.Columns.Count == 0)
                {
                    ltv.Columns.Add("Nome").Width = 160;
                    ltv.Columns.Add("Codigo").Width = 106;
                    ltv.Columns.Add("Quantidade").Width = 76;
                    ltv.Columns.Add("Total").Width = 70;
                    ltv.Columns.Add("LucroTotal").Width = 0;

                }

                foreach (var item in _venda)
                {
                    listView = new ListViewItem(item.Nome);
                    listView.SubItems.Add(item.Codigo);
                    if (item.Quantidade == 0)
                    {
                        listView.SubItems.Add("Peso");
                    }
                    else
                    {
                        listView.SubItems.Add("" + item.Quantidade);
                    }
                    listView.SubItems.Add("" + item.Total);
                    listView.SubItems.Add("" + item.LucroTotal);
                    ltv.Items.Add(listView);
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
