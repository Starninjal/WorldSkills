namespace Simulado01__Sem_Consulta_
{
    partial class frmConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.txtValorConversao = new System.Windows.Forms.TextBox();
            this.txtValorBase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbMoeda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(145, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moeda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de Conversão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor para conversão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(71, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Convertido";
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.Enabled = false;
            this.txtValorConvertido.Location = new System.Drawing.Point(210, 129);
            this.txtValorConvertido.Multiline = true;
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.Size = new System.Drawing.Size(109, 28);
            this.txtValorConvertido.TabIndex = 7;
            this.txtValorConvertido.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtValorConversao
            // 
            this.txtValorConversao.Location = new System.Drawing.Point(210, 91);
            this.txtValorConversao.Multiline = true;
            this.txtValorConversao.Name = "txtValorConversao";
            this.txtValorConversao.Size = new System.Drawing.Size(109, 28);
            this.txtValorConversao.TabIndex = 8;
            // 
            // txtValorBase
            // 
            this.txtValorBase.Enabled = false;
            this.txtValorBase.Location = new System.Drawing.Point(210, 57);
            this.txtValorBase.Multiline = true;
            this.txtValorBase.Name = "txtValorBase";
            this.txtValorBase.Size = new System.Drawing.Size(109, 28);
            this.txtValorBase.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "v";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cbMoeda
            // 
            this.cbMoeda.FormattingEnabled = true;
            this.cbMoeda.Location = new System.Drawing.Point(210, 29);
            this.cbMoeda.Name = "cbMoeda";
            this.cbMoeda.Size = new System.Drawing.Size(308, 21);
            this.cbMoeda.TabIndex = 14;
            this.cbMoeda.SelectedIndexChanged += new System.EventHandler(this.cbMoeda_SelectedIndexChanged);
            this.cbMoeda.Click += new System.EventHandler(this.cbMoeda_Click);
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 254);
            this.Controls.Add(this.cbMoeda);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValorBase);
            this.Controls.Add(this.txtValorConversao);
            this.Controls.Add(this.txtValorConvertido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConverter";
            this.Text = "frmConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorConvertido;
        private System.Windows.Forms.TextBox txtValorConversao;
        private System.Windows.Forms.TextBox txtValorBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbMoeda;
    }
}