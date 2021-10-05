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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mmuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            string data, hora;
            data = hoje.ToString("dd/MM/yyyy");
            hora = hoje.ToString("HH:mm");
            int cod = 0;
            var banco = new Banco();
            var login = (from log in banco.Login where log.hora == hora && log.data == data select log).FirstOrDefault();
            if (login != null)
            {
                cod = login.cod_usuario;
            }
            var usuario = (from user in banco.Usuario where user.cod == cod select user).FirstOrDefault();
            if(usuario != null)
            {
                if (usuario.cargo == "ADM")
                {
                    mmuRelatorio.Enabled = false;
                    txtUsuario.Text = "Ola Srªº. " + usuario.nome + "Horario: " + hora + "Data: " + data;
                    txtUsuario.Visible = true;
                }
                if (usuario.cargo == "RH")
                {
                    mmuConsultar.Enabled = false;
                    mmuCadastrar.Enabled = false;
                    txtUsuario.Text = "Ola Srªº. " + usuario.nome + " Horario: " + hora + " Data: " + data;
                    txtUsuario.Visible = true;
                }
            }
           

        }

        private void funcionarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            cadastroUsuario.ShowDialog();
        }
    }
}
