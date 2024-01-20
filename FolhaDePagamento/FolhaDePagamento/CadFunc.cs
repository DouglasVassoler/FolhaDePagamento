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
using System.ComponentModel.Design.Serialization;
using static FolhaDePagamento.managcad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FolhaDePagamento
{

    public partial class CadFunc : Form
    {



        DMC cad = new DMC();
        string sexo = "";

        public CadFunc()
        {
            InitializeComponent();
        }
        private void Criar_Click(object sender, EventArgs e)
        {
            string matricula = Matricula.Text;
            string nome = Nome.Text;
            string cpf = CPF.Text;
            string dtnasc = dtNasc.Text;
            string telef = Telefone.Text;
            string endereco = Endereco.Text;
            string cep = CEP.Text;
            string num = NUM.Text;
            string cargo = Cargo.Text;
            string bairro = Bairro.Text;
            string email = Email.Text;
            string nomeempresa = Empresa.Text;
            string cnpj = CNPJ.Text;
            string ativo = "1";


            Cadastro cadastro = new Cadastro(matricula, nome, cpf, dtnasc, telef, endereco, cep, num, cargo, bairro, email, nomeempresa, cnpj, sexo, ativo);

            cad.Cadastrobd(cadastro);

            Matricula.Text = "";
            Nome.Text = "";
            CPF.Text = "";
            dtNasc.Text = "";
            Telefone.Text = "";
            Endereco.Text = "";
            CEP.Text = "";
            NUM.Text = "";
            Cargo.Text = "";
            Bairro.Text = "";
            Email.Text = "";
            Empresa.Text = "";
            CNPJ.Text = "";

            MessageBox.Show("Cadastro Criado com sucesso");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CadFunc_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sexo = "Feminino";
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sexo = "Masculino";
            }
        }


        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Menucad().Show();
            this.Hide();
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void Endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CEP_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void NUM_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Bairro_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
