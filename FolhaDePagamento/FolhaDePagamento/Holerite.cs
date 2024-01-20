using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FolhaDePagamento.FolhaPGTO;
using static FolhaDePagamento.managcad;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FolhaDePagamento
{
    public partial class Holerite : Form
    {


        public Holerite()
        {
            InitializeComponent();
        }

        Folha consul = new Folha();

        public class CadastroHolerite
        {
            public string IDFolha = "0";
            public string vr = "0";
            public string va = "0";
            public string vt = "0";
            public string salarioB = "0";
            public string inss = "0";
            public string irrf = "0";
            public string horaex = "0";
            public string SalarioL = "0";

        }

        private void EnderecoEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void BIRRF_Click(object sender, EventArgs e)
        {
        }

        private void FGTS_Click(object sender, EventArgs e)
        {
        }

        private void BFGTS_Click(object sender, EventArgs e)
        {
        }

        private void SalBase_Click(object sender, EventArgs e)
        {
        }

        private void INSS_Click(object sender, EventArgs e)
        {
        }

        private void SalarLiq_Click(object sender, EventArgs e)
        {
        }

        private void TDescontos_Click(object sender, EventArgs e)
        {
        }

        private void TProventos_Click(object sender, EventArgs e)
        {
        }

        private void DescIRRF_Click(object sender, EventArgs e)
        {
        }

        private void DescINSS_Click(object sender, EventArgs e)
        {
        }

        private void DescTP_Click(object sender, EventArgs e)
        {
        }

        private void DescVA_Click(object sender, EventArgs e)
        {
        }

        private void DescVR_Click(object sender, EventArgs e)
        {
        }

        private void DescHE_Click(object sender, EventArgs e)
        {
        }

        private void SalarioDesc_Click(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void label30_Click(object sender, EventArgs e)
        {
        }

        private void ProvVR_Click(object sender, EventArgs e)
        {
        }

        private void ProvHE_Click(object sender, EventArgs e)
        {
        }

        private void ProvSalario_Click(object sender, EventArgs e)
        {
            ProvSalario.Text = consul.salarioB.ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Func_Click(object sender, EventArgs e)
        {
        }

        private void CBO_Click(object sender, EventArgs e)
        {
        }

        private void DtAdmis_Click(object sender, EventArgs e)
        {
        }

        private void NomeFunc_Click(object sender, EventArgs e)
        {
        }

        private void CodFunc_Click(object sender, EventArgs e)
        {
        }

        private void Mesref_Click(object sender, EventArgs e)
        {
        }

        private void CNPJ_Click(object sender, EventArgs e)
        {
        }

        private void NomeEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {            

            new holerite2().Show();
            this.Hide();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
