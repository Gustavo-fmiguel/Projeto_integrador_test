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
using System.Security.Cryptography;

namespace Siscola
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string senhaMd5 = "";
        // Senha MD5
        static string GetMd5Hash(MD5 md5Hash, string input)

        {



            // Convert the input string to a byte array and compute the hash. 

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));



            // Create a new Stringbuilder to collect the bytes 

            // and create a string. 

            StringBuilder sBuilder = new StringBuilder();



            // Loop through each byte of the hashed data  

            // and format each one as a hexadecimal string. 

            for (int i = 0; i < data.Length; i++)

            {

                sBuilder.Append(data[i].ToString("x2"));

            }



            // Return the hexadecimal string. 

            return sBuilder.ToString();

        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)

        {

            // Hash the input. 

            string hashOfInput = GetMd5Hash(md5Hash, input);



            // Create a StringComparer an compare the hashes. 

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;



            if (0 == comparer.Compare(hashOfInput, hash))

            {

                return true;

            }

            else

            {

                return false;

            }
        }
            private void frmLogin_Load(object sender, EventArgs e)
        {
            
            

            
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }
        private int i = 255;

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            i = 255;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            string fonte = txtSenha.Text;
            using (MD5 md5hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5hash, fonte);
                senhaMd5 = hash;
            }
            string login = "", senha = "";
            imgLoadLogo.Visible = true;
            var banco = new Banco();
            var usuario = (from user in banco.Usuario where user.login == txtLogin.Text select user).FirstOrDefault();
            if (usuario != null)
            {
                login = usuario.login.ToString();
                senha = usuario.senha.ToString();
            }
            if (txtLogin.Text != "" && txtLogin.Text == login)
            {
                if (txtSenha.Text != "" && senhaMd5 == senha) 
                {
                    DateTime hoje = DateTime.Now;
                    var login_ativo = new Login()
                    {
                        cod_usuario = usuario.cod,
                        data = hoje.ToString("dd/MM/yyyy"),
                        hora = hoje.ToString("HH:mm")
                    };

                    banco.Login.Add(login_ativo);
                    banco.SaveChanges();
                    
                    frmMenu menu = new frmMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Senha Errada");
                    imgLoadLogo.Visible = false;
                }

            }
            
            else
            {
                MessageBox.Show("Login incorreto");
                imgLoadLogo.Visible = false;
            }
        }
        

        private void imgLoadLogo_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.FromArgb(i, SystemColors.Control));

            e.Graphics.FillRectangle(sb, imgLoadLogo.ClientRectangle);

            sb.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)

            {

                // aqui é outra forma de controlar

                // a velocidade de exibição da imagem.

                // Quanto maior o incremento, mais rápido

                // a imagem aparece. Não se esqueça ao mudar

                // o incremento que não há cores com o alfa

                // negativo, logo teste para ver se o valor

                // de i não fique negativo se mudar o intervalo

                i -= 5;

                // isso força que o PictureBox seja redesenhado

                // no form.

                imgLoadLogo.Invalidate();

            }

            else

                timer1.Enabled = false;
        }       
    }
}
