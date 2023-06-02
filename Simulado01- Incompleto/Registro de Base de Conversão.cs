using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioSenai
{
    public partial class frmRegistro : Form
    {
        private Conversao conversao;

        private List<Conversao> conversoes = new List<Conversao>();

        private Double baseConvert;

        private retornarDados dados;

        private ServiceBase service = new ServiceBase();

        private frmConverter converter = new frmConverter();






        public frmRegistro()
        {
            InitializeComponent();
        }

 

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            try
            {
                String moeda = txtMoeda.Text;

                baseConvert = Convert.ToDouble(maskBase.Text);

                conversao = new Conversao(moeda, baseConvert);


                service.validarBase(conversao);

                retornarDados.adicionarConversao(conversao);

                MessageBox.Show("Inserido com sucesso!");

            } catch(Exception e2)
            {
                MessageBox.Show("Houve um erro ao inserir a base. Motivo: " + e2.Message);
            }
            

        }




        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtMoeda.Text = "";
            txtBaseConversao.Text = "";
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            txtMoeda.Text = conversoes[0].toString();

            txtBaseConversao.Text = conversoes[0].BaseConversao.ToString();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            txtMoeda.Text = conversoes[conversoes.Count - 1].toString();

            txtBaseConversao.Text = conversoes[conversoes.Count - 1].BaseConversao.ToString();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                if (conversoes[i].Moeda.Equals(txtMoeda.Text) && conversoes[i].BaseConversao == Convert.ToDouble(txtBaseConversao.Text))
                {

                    if (conversoes[i].toString().Equals(txtMoeda.Text))
                    {
                        txtMoeda.Text = conversoes[i + 1].toString();
                        txtBaseConversao.Text = conversoes[i + 1].BaseConversao.ToString();
                        i++;

                    }


                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnUltimo_Click(sender, e);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                if (conversoes[i].Equals(txtMoeda.Text))
                {

                    if (conversoes[i].Equals(txtMoeda.Text))
                    {
                        txtMoeda.Text = conversoes[i - 1].ToString();
                        txtBaseConversao.Text = conversoes[i - 1].BaseConversao.ToString();
                        i--;

                    }


                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listarAdicionar();
        }

        public void listarAdicionar()
        {
            String lista = "";
            for (int i = 0; i < conversoes.Count; i++)
            {
                lista += conversoes[i].toString();
            }
            MessageBox.Show(lista);
        }

        private void maskBase_Leave(object sender, EventArgs e)
        {
            /*
            try
            {

                
                if (Convert.ToDouble(maskBase.Text.ToString()) > 10)
                {
                    if (maskBase.Text.Contains("."))
                    {
                        String[] mask = maskBase.Text.Split('.');
                        MessageBox.Show(string.Format("Numeração {0}", mask[0]));
                        MessageBox.Show(string.Format("Numeração {0}", mask[1]));


                            
                        maskBase.Mask = mask[0] + "." + mask[1];
                    } else
                    {
                        maskBase.Mask = "00.00";
                        MessageBox.Show("É obrigatório colocar 2 casas após a virgula para melhor aproveitamento na performance do aplicativo!");
                    }

                } else if(Convert.ToDouble(maskBase.Text.ToString()) < 10)
                {
                    if (maskBase.Text.Contains("."))
                    {
                        String [] mask = maskBase.Text.Split('.');
                    } else
                    {
                        maskBase.Mask = "0.00";
                        MessageBox.Show("É obrigatório colocar 2 casas após a virgula para melhor aproveitamento na performance do aplicativo!");
                    }
                }     
                    
                    
                    
               
            }
            catch (Exception e2)
            {
                MessageBox.Show("O valor não pode ser nulo!");
            }

    */
        }

    
    }
}
    


