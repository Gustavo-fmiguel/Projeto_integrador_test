namespace Siscola
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnAcessar = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.PcbLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(340, 238);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 2;
            // 
            // BtnAcessar
            // 
            this.BtnAcessar.Location = new System.Drawing.Point(340, 283);
            this.BtnAcessar.Name = "BtnAcessar";
            this.BtnAcessar.Size = new System.Drawing.Size(100, 20);
            this.BtnAcessar.TabIndex = 3;
            this.BtnAcessar.Text = "Acessar";
            this.BtnAcessar.UseVisualStyleBackColor = true;
            this.BtnAcessar.Click += new System.EventHandler(this.BtnAcessar_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(340, 155);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(100, 20);
            this.TxtLogin.TabIndex = 4;
            // 
            // PcbLoader
            // 
            this.PcbLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PcbLoader.Image = global::Siscola.Properties.Resources.load;
            this.PcbLoader.InitialImage = null;
            this.PcbLoader.Location = new System.Drawing.Point(272, 97);
            this.PcbLoader.Name = "PcbLoader";
            this.PcbLoader.Size = new System.Drawing.Size(256, 256);
            this.PcbLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PcbLoader.TabIndex = 5;
            this.PcbLoader.TabStop = false;
            this.PcbLoader.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PcbLoader);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnAcessar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PcbLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnAcessar;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.PictureBox PcbLoader;
    }
}

