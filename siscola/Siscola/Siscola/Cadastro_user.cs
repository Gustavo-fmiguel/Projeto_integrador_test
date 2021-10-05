using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siscola.Data;

namespace Siscola
{
    public partial class FrmCadastro_user : Form
    {
        public FrmCadastro_user()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtLogin.Text == "")
            {
                MessageBox.Show("Digite um Login para busca!!");
            }
            else
            {
                var banco = new Banco();
                var buscaLogin = (from log in banco.Usuario where log.login == TxtLogin.Text select log).FirstOrDefault();
                if (buscaLogin != null)
                {
                    TxtLogin.Text = buscaLogin.login.ToString();
                    TxtNome.Text = buscaLogin.nome.ToString();
                    TxtSenha.Text = buscaLogin.senha.ToString();
                    CmbCargo.Text = buscaLogin.cargo.ToString();

                }
                else
                {
                    MessageBox.Show("Usuário não Cadastrado");
                }

            }
        }
    }

    private void BtnBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void FrmCadastro_user_Load(object sender, EventArgs e)
    {
        TxtSenha.PasswordChar = '♣';
    }

    private void pictureBox1_DragLeave(object sender, EventArgs e)
    {

    }

    private void pictureBox1_DragEnter(object sender, DragEventArgs e)
    {

    }

    private void pictureBox1_MouseLeave(object sender, EventArgs e)
    {


        TxtSenha.PasswordChar = '♣';

    }

    private void pictureBox1_MouseHover(object sender, EventArgs e)
    {


        TxtSenha.PasswordChar = '\0';

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        if (TxtNome.Text == "" && TxtLogin.Text == "" && TxtSenha.Text == "" && CmbCargo.Text == "")
        {
            MessageBox.Show("Preencha todos os Campos", "Erro Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            var banco = new Banco();
            var CadFuncionario = new Usuario()
            {
                nome = TxtNome.Text,
                login = TxtLogin.Text,
                senha = TxtSenha.Text,
                cargo = CmbCargo.Text
            };
            banco.Usuario.Add(CadFuncionario);
            banco.SaveChanges();
            MessageBox.Show("Salvo com Sucesso!");
            Limpar();
        }
    }
    public void Limpar()
    {
        TxtLogin.Clear();
        TxtNome.Clear();
        TxtSenha.Clear();
        CmbCargo.Text = "";
    }
}
}
