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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            int cod = 0;
            string data, hora;
            data = hoje.ToString("dd/MM/yy");
            hora = hoje.ToString("HH:mm");
            var Banco = new Banco();
            var login = (from log in Banco.Login where log.hora ==hora  &&
                         log.data == data  select log).FirstOrDefault();
            if (login != null)
            {
                cod = login.cod_usuario;
            }
            var usuario = (from user in Banco.Usuario where user.cod == cod select user).FirstOrDefault();
            if (usuario != null)
            {
                if (usuario.cargo == "ADM")
                {
                    MnuRelatorio.Enabled = false;
                    TxtUsuario.Text = "Olá Srºª. " + usuario.nome;
                }
                if (usuario.cargo == "RH")
                {
                    MnuCadastrar.Enabled = false;
                    MnuConsultar.Enabled = false;
                    TxtUsuario.Text = "Olá Srºª. " + usuario.nome + " " + data + " "+hora;
                }
            }

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro_user usuario = new FrmCadastro_user();
            usuario.ShowDialog();
        }
    }
}
