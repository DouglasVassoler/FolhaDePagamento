using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamento
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void fecharButton5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dadosEmpresaButton_Click(object sender, EventArgs e)
        {
            new DadosEmpresa().Show();
            this.Hide();
        }

        private void cadastroFuncButton_Click(object sender, EventArgs e)
        {
            new Menucad().Show();
            this.Hide();
        }

        private void matriculasButton_Click(object sender, EventArgs e)
        {
            new Encargos().Show();
            this.Hide();
        }

        private void folhaDePagamentoButton_Click(object sender, EventArgs e)
        {
            new FolhaPGTO().Show();
            this.Hide();
        }

        private void beneficiosButton_Click(object sender, EventArgs e)
        {
            new Holerite().Show();
            this.Hide();
        }
    }
}
