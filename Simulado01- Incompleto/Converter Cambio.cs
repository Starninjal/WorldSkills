﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioSenai
{
    public partial class frmConverter : Form
    {

        private List<Conversao> conversoes = new List<Conversao>();
        private Conversao conversao;
        
        private StreamWriter writer;

        private int idTexto = 0;

        private retornarDados dados;
    

        public frmConverter()
        {
            InitializeComponent();
            this.conversoes = retornarDados.listarConversao();
            carregarComboMoeda();
            listar();


        }

        public void Converter_Cambio_Load(object sender, EventArgs e)
        {
            

        }

        public void carregarComboMoeda()
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                cbMoeda.Items.Add(conversoes[i].toString());

                
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < conversoes.Count; i++)
                {
                   
                    listar();
                      
                    double calculo = Convert.ToDouble(txtBase.Text) * Convert.ToDouble(txtValorConverter.Text);

                    
                
                    

                    conversao = new Conversao(calculo);



                    if (conversao.ValorConvertido > 0 && txtValorConverter != null)
                    {
                        txtValorConvertido.Text = conversao.ValorConvertido.ToString();
                    }

                    listarArquivo();

                        
             
                    



                }

            }

            catch (Exception e2)
            {
                MessageBox.Show("Ocorreu um erro ao setar o valor! Verifique se ele está preenchido corretamente!");
            }




        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                if(cbMoeda.SelectedItem.ToString() == conversoes[i].toString())
                {
                    conversoes.Remove(conversoes[i]);
                    
                } 
                    
                    
                
                
                MessageBox.Show(conversoes[i].toString());
                cbMoeda.Items.Remove(cbMoeda.SelectedItem);
                break;
                
            }
           
                
                
            
        }

        public void listarArquivo()
        {
           
            for (int i = 0; i < conversoes.Count; i++)
            {
                
                if (cbMoeda.Text.Equals(conversoes[i].toString()))
                {
                     writer = new StreamWriter(@"C:\papsta\BackupConversoes.txt", true, Encoding.Default);
                   
                    
                    if(idTexto == 0)
                    {
                        writer.Write("Relatório de Conversões \n");
                        writer.Write("");
                        idTexto++;
                    }
                    String textoArquivo = "";
                    textoArquivo += "Moeda: " + conversoes[i].toString() + " | " + "Base de Conversao: " + conversoes[i].BaseConversao + " | Calculo | " + " Valor de conversão: " + txtValorConverter.Text + " = " + conversao.ValorConvertido;
                    writer.WriteLine(textoArquivo);
                    writer.Dispose();
                }
            }
        }

        public void listar()    
        {
            for (int i = 0; i < conversoes.Count; i++)
            {
                if (cbMoeda.Text.Equals(conversoes[i].Moeda))
                {
                    txtBase.Text = conversoes[i].BaseConversao.ToString();
                }
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
    }
