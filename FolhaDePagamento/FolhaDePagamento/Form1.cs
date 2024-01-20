using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolhaDePagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //neste método tem a função de mostrar a senha.
        {
            textBoxSenha1.UseSystemPasswordChar = checkBox1.Checked;
        }

        private void fecharLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Aqui irá fechar a aplicação.
        {
            Application.Exit();
        }

        private void esqueciSenhaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //vai abrir o Forms2 
        {
            new Form2().Show();
            this.Hide();
        }

        //Aqui irei fazer a conexão com o banco de dados
        //Porém deixo avisado que pode haver alterações 
        //Pois no momento é só um teste
        private void loginButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog= DB_PIM;" + "Integrated Security = true";
            con.Open();

            SqlCommand cdm = new SqlCommand();
            cdm.Connection = con;

            string entrar = "select * from TB_Usuario where email_user = '" + textBoxEmail1.Text + "' and senha_user = '" + textBoxSenha1.Text + "'";

            cdm = new SqlCommand(entrar, con);
            SqlDataReader dr = cdm.ExecuteReader();
            if (dr.Read() == true)
            {
                new Form5().Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenha1.Text = "";
                textBoxEmail1.Focus();
            }
        }

        private void tituloLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}