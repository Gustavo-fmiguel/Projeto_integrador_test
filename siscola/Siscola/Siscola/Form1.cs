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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            PcbLoader.Visible = true;
            var Banco = new Banco();
            var usuario = (from user in Banco.Usuario where user.login == TxtLogin.Text select user).FirstOrDefault();
            string login = "", senha = "";
            if (usuario != null)
            {
                login = usuario.login;
                senha = usuario.senha;
            }
            if(TxtLogin.Text!="" && TxtLogin.Text == login)
            {
                if(TxtSenha.Text!="" && TxtSenha.Text == senha)
                {
                    DateTime hoje = DateTime.Now;
                    var login_ativo = new Login()
                    {
                        cod_usuario = usuario.cod,
                        data = hoje.ToString("dd/MM/yy"),
                        hora = hoje.ToString("HH:mm")
                    };
                    Banco.Login.Add(login_ativo);
                    Banco.SaveChanges();
                    FrmMenu menu = new FrmMenu();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha Invalida");
                    PcbLoader.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Login Invalido");
                PcbLoader.Visible = false;
            }
        }
    }
}
