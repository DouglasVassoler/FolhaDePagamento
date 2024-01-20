using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FolhaDePagamento.managcad;

namespace FolhaDePagamento
{
    public partial class AltFunc : Form
    {
        //DMC = Classe / consulta = objeto / new Produto = instância
        DMC consulta = new DMC();
        Cadastro cadastro = new Cadastro();

        public AltFunc()
        {
            InitializeComponent();
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

        private void Cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltFunc_Load(object sender, EventArgs e)
        {
        }

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Telef_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void DtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Bairro_TextChanged(object sender, EventArgs e)
        {
        }

        private void CEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {
        }

        private void Endereco_TextChanged(object sender, EventArgs e)
        {
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
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

        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Menucad().Show();
            this.Hide();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {

            cadastro.matricula = Matricula.Text;
            cadastro.cargo = Cargo.Text;
            cadastro.telef = Telef.Text;
            cadastro.email = Email.Text;

            consulta.Alterar(Matricula.Text, Cargo.Text, Telef.Text, Email.Text);

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

            MessageBox.Show("Cadastro Atualizado com sucesso");
        }
    
    }
}
