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
    public partial class Menucad : Form
    {
        public Menucad()
        {
            InitializeComponent();
        }

        private void cadastroFuncButton_Click(object sender, EventArgs e)
        {
            new CadFunc().Show();
            this.Hide();
        }

        private void beneficiosButton_Click(object sender, EventArgs e)
        {
            new ConsFunc().Show();
            this.Hide();
        }

        private void matriculasButton_Click(object sender, EventArgs e)
        {
            new ExcFunc().Show();
            this.Hide();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void dadosEmpresaButton_Click(object sender, EventArgs e)
        {
            new AltFunc().Show();
            this.Hide();
        }
    }
}
