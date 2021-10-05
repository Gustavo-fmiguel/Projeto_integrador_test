namespace Siscola
{
    partial class frmMenu
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
            this.mmuMenu = new System.Windows.Forms.MenuStrip();
            this.mmuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.mmuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmuMenu
            // 
            this.mmuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuCadastrar,
            this.mmuConsultar,
            this.mmuRelatorio,
            this.mmuSair,
            this.txtUsuario});
            this.mmuMenu.Location = new System.Drawing.Point(0, 0);
            this.mmuMenu.Name = "mmuMenu";
            this.mmuMenu.Size = new System.Drawing.Size(800, 27);
            this.mmuMenu.TabIndex = 0;
            this.mmuMenu.TabStop = true;
            this.mmuMenu.Text = "menuStrip1";
            // 
            // mmuCadastrar
            // 
            this.mmuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem2});
            this.mmuCadastrar.Name = "mmuCadastrar";
            this.mmuCadastrar.Size = new System.Drawing.Size(69, 23);
            this.mmuCadastrar.Text = "Cadastrar";
            // 
            // funcionarioToolStripMenuItem2
            // 
            this.funcionarioToolStripMenuItem2.Name = "funcionarioToolStripMenuItem2";
            this.funcionarioToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.funcionarioToolStripMenuItem2.Text = "Funcionario";
            this.funcionarioToolStripMenuItem2.Click += new System.EventHandler(this.funcionarioToolStripMenuItem2_Click);
            // 
            // mmuConsultar
            // 
            this.mmuConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem});
            this.mmuConsultar.Name = "mmuConsultar";
            this.mmuConsultar.Size = new System.Drawing.Size(70, 23);
            this.mmuConsultar.Text = "Consultar";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // mmuRelatorio
            // 
            this.mmuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem1});
            this.mmuRelatorio.Name = "mmuRelatorio";
            this.mmuRelatorio.Size = new System.Drawing.Size(71, 23);
            this.mmuRelatorio.Text = "Relatorios";
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem1.Text = "Funcionario";
            // 
            // mmuSair
            // 
            this.mmuSair.Name = "mmuSair";
            this.mmuSair.Size = new System.Drawing.Size(38, 23);
            this.mmuSair.Text = "Sair";
            this.mmuSair.Click += new System.EventHandler(this.mmuSair_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(255, 23);
            this.txtUsuario.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mmuMenu);
            this.MainMenuStrip = this.mmuMenu;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mmuMenu.ResumeLayout(false);
            this.mmuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmuMenu;
        private System.Windows.Forms.ToolStripMenuItem mmuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem mmuConsultar;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem mmuSair;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txtUsuario;
    }
}