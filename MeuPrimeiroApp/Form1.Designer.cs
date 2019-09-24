namespace MeuPrimeiroApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ligar = new System.Windows.Forms.Button();
            this.btn_Desligar = new System.Windows.Forms.Button();
            this.btn_Detalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ligar
            // 
            this.btn_Ligar.Location = new System.Drawing.Point(58, 116);
            this.btn_Ligar.Name = "btn_Ligar";
            this.btn_Ligar.Size = new System.Drawing.Size(152, 65);
            this.btn_Ligar.TabIndex = 0;
            this.btn_Ligar.Text = "Ligar";
            this.btn_Ligar.UseVisualStyleBackColor = true;
            this.btn_Ligar.Click += new System.EventHandler(this.Btn_Ligar_Click);
            // 
            // btn_Desligar
            // 
            this.btn_Desligar.Location = new System.Drawing.Point(318, 116);
            this.btn_Desligar.Name = "btn_Desligar";
            this.btn_Desligar.Size = new System.Drawing.Size(162, 65);
            this.btn_Desligar.TabIndex = 1;
            this.btn_Desligar.Text = "Desligar";
            this.btn_Desligar.UseVisualStyleBackColor = true;
            this.btn_Desligar.Click += new System.EventHandler(this.Btn_Desligar_Click);
            // 
            // btn_Detalhes
            // 
            this.btn_Detalhes.Location = new System.Drawing.Point(576, 116);
            this.btn_Detalhes.Name = "btn_Detalhes";
            this.btn_Detalhes.Size = new System.Drawing.Size(175, 65);
            this.btn_Detalhes.TabIndex = 2;
            this.btn_Detalhes.Text = "Detalhes";
            this.btn_Detalhes.UseVisualStyleBackColor = true;
            this.btn_Detalhes.Click += new System.EventHandler(this.Btn_Detalhes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(824, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Detalhes);
            this.Controls.Add(this.btn_Desligar);
            this.Controls.Add(this.btn_Ligar);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxBotao;
        private System.Windows.Forms.Button PrimeiroBotao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Ligar;
        private System.Windows.Forms.Button btn_Desligar;
        private System.Windows.Forms.Button btn_Detalhes;
        private System.Windows.Forms.Button button1;
    }
}

