using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FolhaDePagamento.managcad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FolhaDePagamento
{
    public partial class ExcFunc : Form
    {
        DMC consulta = new DMC();
        Cadastro cadastro = new Cadastro();


        public ExcFunc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro = consulta.Consulta(Matricula.Text);

            Nome.Text = cadastro.nome;
            Empresa.Text = cadastro.nomeempresa;
            CNPJ.Text = cadastro.cnpj;
            CPF.Text = cadastro.cpf;
            Telef.Text = cadastro.telef;
            DtNasc.Text = cadastro.dtnasc;
            Endereco.Text = cadastro.endereco;
            Num.Text = cadastro.num;
            CEP.Text = cadastro.cep;
            Bairro.Text = cadastro.bairro;
            Email.Text = cadastro.email;
            Cargo.Text = cadastro.cargo;


            if (cadastro.sexo == "Feminino")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta.Excluir(cadastro.matricula);

            Matricula.Text = "";
            Nome.Text = "";
            CPF.Text = "";
            DtNasc.Text = "";
            Telef.Text = "";
            Endereco.Text = "";
            CEP.Text = "";
            Num.Text = "";
            Cargo.Text = "";
            Bairro.Text = "";
            Email.Text = "";
            Empresa.Text = "";
            CNPJ.Text = "";

            MessageBox.Show("Cadastro excluido com sucesso");
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Menucad().Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
