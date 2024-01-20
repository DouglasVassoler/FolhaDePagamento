using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static FolhaDePagamento.managcad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Logging;

namespace FolhaDePagamento
{
    public partial class ConsFunc : Form
    {

        public ConsFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DMC consulta = new DMC(); //chama a classe DMC (Data Manage Cad)

            // Precisa chamar o DMC para poder chamar a classe Cadastro que está dentro do DMC.
            Cadastro cadastro = consulta.Consulta(Matricula.Text); //Chama a classe consulta para poder atribuir os valores consultados no BD para o textbox.

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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            new Menucad().Show();
            this.Hide();
        }

        private void ConsFunc_Load(object sender, EventArgs e)
        {


        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Menucad().Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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

        private void Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
