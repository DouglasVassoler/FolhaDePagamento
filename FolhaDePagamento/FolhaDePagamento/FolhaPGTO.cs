using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FolhaDePagamento.managcad;
using static FolhaDePagamento.Managefolha;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FolhaDePagamento
{
    public partial class FolhaPGTO : Form
    {
        public class Folha
        {
            public int IDFolha = 0;
            public double vr = 0;
            public double va = 0;
            public double vt = 0;
            public double salarioB = 0;
            public double inss = 0;
            public double irrf = 0;
            public double horaex = 0;
            public double SalarioL = 0;

        }
        Folha calculo = new Folha();







        public FolhaPGTO()
        {
            InitializeComponent();
        }



        private void Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void INSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gerar_Click(object sender, EventArgs e)
        {

        }

        private void ValeTransporte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ValeRefeicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void ValeAlimentacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void VR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void Matricula_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Consultar_Click_1(object sender, EventArgs e)
        {
            DMC consul = new DMC();

            Cadastro cadastro = consul.Consulta(Matricula.Text);

            Nome.Text = cadastro.nome;
            Cargo.Text = cadastro.cargo;

        }

        private void Cargo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Nome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SalarioB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void INSS_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IRRF_Click(object sender, EventArgs e)
        {

        }
        private void CalcularSL_Click(object sender, EventArgs e)
        {

            try
            {
                calculo.salarioB = double.Parse(SalarioB.Text);

            }
            catch (FormatException)
            {
                // Lidar com o caso em que o texto não pode ser convertido para double.
                MessageBox.Show("Por favor, insira um valor válido.");
            }

            if (calculo.salarioB <= 1302.00)
            {
                calculo.inss = calculo.salarioB * 0.075;
            }
            else if (calculo.salarioB <= 2571.29)
            {
                calculo.inss = calculo.salarioB * 0.09;
            }
            else if (calculo.salarioB <= 3856.94)
            {
                calculo.inss = calculo.salarioB * 0.12;
            }
            else if (calculo.salarioB <= 7507.49)
            {
                calculo.inss = calculo.salarioB * 0.14;
            }
            else
            {
                calculo.inss = 1051.05;
            }


            if (calculo.salarioB <= 1903.98)
            {
                calculo.irrf = 0;
            }
            else if (calculo.salarioB <= 2826.65)
            {
                calculo.irrf = (calculo.salarioB * 0.75) - 142.80;
            }
            else if (calculo.salarioB <= 3751.05)
            {
                calculo.irrf = (calculo.salarioB * 0.15) - 354.080;
            }
            else if (calculo.salarioB <= 4664.68)
            {
                calculo.irrf = (calculo.salarioB * 0.225) - 636.13;
            }
            else
            {
                calculo.irrf = (calculo.salarioB * 0.275) - 869.36;
            }



            calculo.SalarioL = (calculo.salarioB + calculo.horaex) - calculo.inss - calculo.irrf - calculo.vr - calculo.va - calculo.vt;




            SalarioL.Text = calculo.SalarioL.ToString();
            INSS.Text = calculo.inss.ToString();
            textBox1.Text = calculo.irrf.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                // Se o CheckBox está marcado, habilita o controle ValeRefeicao
                ValeRefeicao.Enabled = true;

                // Verifica se o texto é um número válido antes de fazer a conversão
                if (double.TryParse(ValeRefeicao.Text, out double valor))
                {
                    calculo.vr = valor;
                }
                else
                {
                    // Tratar o caso em que o texto não é um número válido
                    MessageBox.Show("Por favor, insira um valor válido para o Vale Refeição.");
                    // Pode ser útil redefinir o controle ValeRefeicao.Text ou definir o valor padrão.
                    // Exemplo: ValeRefeicao.Text = "0";
                }
            }
            else
            {
                // Se o CheckBox está desmarcado, desabilita o controle ValeRefeicao
                ValeRefeicao.Enabled = false;

                // Define o valor do benefício como zero (ou qualquer valor padrão desejado)
                calculo.vr = 0;
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ValeAlimentacao.Enabled = true;

                if (double.TryParse(ValeAlimentacao.Text, out double valor))
                {
                    calculo.va = valor;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido para o Vale Refeição.");
                }
            }
            else
            {
                ValeAlimentacao.Enabled = false;

                calculo.va = 0;
            }
        }

        private void vt_CheckedChanged(object sender, EventArgs e)
        {
            if (vt.Checked)
            {
                ValeTransporte.Enabled = true;

                if (double.TryParse(ValeTransporte.Text, out double valor))
                {
                    calculo.vt = double.Parse(SalarioB.Text) * 0.08;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido para o Vale Transporte.");

                }
            }
            else
            {
                ValeTransporte.Enabled = false;

                calculo.vt = 0;
            }

        }

        private void HEXTRA_CheckedChanged(object sender, EventArgs e)
        {
            if (HEXTRA.Checked)
            {
                HorasExt.Enabled = true;

                if (double.TryParse(HorasExt.Text, out double valor))
                {
                    calculo.horaex = valor;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido para as horas extras.");
                }
            }
            else
            {
                HorasExt.Enabled = false;

                calculo.horaex = 0;
            }
        }

        private void HorasExt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HorasExt.Text = "";
            SalarioB.Text = "";
            ValeTransporte.Text = "";
            ValeRefeicao.Text = "";
            ValeAlimentacao.Text = "";
            SalarioL.Text = "";
            INSS.Text = "";
            textBox1.Text = "";
        }

        private void GerarFolha_Click(object sender, EventArgs e)
        {
            DMC consul = new DMC();
            Cadastro cadastro = consul.Consulta(Matricula.Text);

            Nome.Text = cadastro.nome;
            Cargo.Text = cadastro.cargo;


            calculo.IDFolha = calculo.IDFolha + 1;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog=DB_PIM; Integrated Security=true";
            con.Open();

            SqlCommand cdm = new SqlCommand();

            cdm.Connection = con;
            cdm.CommandText = "INSERT INTO TB_Holerite " +
                    "(IDFolha, matricula, nome, vr, va, vt, salarioB, inss, irrf, horaextra, salarioL)"
                    +
                "VALUES('" + calculo.IDFolha +
                "','" + cadastro.matricula +
                "','" + cadastro.nome +
                "','" + calculo.vr +
                "','" + calculo.va +
                "','" + calculo.vt +
                "','" + calculo.salarioB +
                "','" + calculo.inss +
                "','" + calculo.irrf +
                "','" + calculo.horaex +
                "','" + calculo.SalarioL + "');";

            cdm.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Folha gerada com sucesso.");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = calculo.IDFolha.ToString();
        }
    }
}
