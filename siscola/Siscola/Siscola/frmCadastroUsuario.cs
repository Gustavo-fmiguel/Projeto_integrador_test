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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text=="")
            {
                MessageBox.Show("Digite um login para nusca");
            }
            else
            {
                var banco = new Banco();
                var busca = (from login in banco.Usuario where login.login == txtLogin.Text select login).FirstOrDefault();
                if (busca != null)
                {
                    txtNome.Text = busca.nome.ToString();
                    txtLogin.Text = busca.login.ToString();
                    txtSenha.Text = busca.senha.ToString();
                    txtCargo.Text = busca.cargo.ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não enconrado");
                }
            }
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            txtCargo.Items.Add(" ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            txtSenha.PasswordChar = '*';
        }
        public void Limpar()
        {
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtCargo.SelectedIndex = 2;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string fonte = txtSenha.Text;
            using(MD5 md5hash = MD5.Create())
            {
                string hash =GetMd5Hash(md5hash, fonte);
                senhaMd5 = hash;
            }
            if (txtNome.Text =="" || txtLogin.Text =="" || txtSenha.Text =="" || txtCargo.Text=="")
            {
                MessageBox.Show("Prencha todos os campos");
            }
            else
            {
                var banco = new Banco();
                var cadastrofuncionario = new Usuario()
                {
                    nome = txtNome.Text,
                    login = txtLogin.Text,
                    senha = senhaMd5,
                    cargo = txtCargo.Text
                };
                banco.Usuario.Add(cadastrofuncionario);
                banco.SaveChanges();
                Limpar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Preencha todos os  campos", "Erro nos campos");
            }
            else
            {
                var banco = new Banco();
                var busca = (from login in banco.Usuario where login.login == txtLogin.Text select login).FirstOrDefault();
                if (busca != null)
                {
                    txtNome.Text = busca.nome.ToString();
                    txtLogin.Text = busca.login.ToString();
                    txtSenha.Text = busca.senha.ToString();
                    txtCargo.Text = busca.cargo.ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
                banco.Usuario.Remove(busca);
                banco.SaveChanges();
                MessageBox.Show("Apagou HAHAHA");
                Limpar();
            }
        }

    }




}

