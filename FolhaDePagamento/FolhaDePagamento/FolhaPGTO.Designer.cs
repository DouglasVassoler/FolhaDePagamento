namespace FolhaDePagamento
{
    partial class FolhaPGTO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolhaPGTO));
            cadastroFuncButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            voltarButton = new Button();
            label1 = new Label();
            Consultar = new Button();
            label2 = new Label();
            Nome = new TextBox();
            label10 = new Label();
            Cargo = new TextBox();
            label3 = new Label();
            SalarioB = new MaskedTextBox();
            Matricula = new TextBox();
            INSS = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            HEXTRA = new CheckBox();
            vt = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            CalcularSL = new Button();
            textBox2 = new TextBox();
            ValeTransporte = new MaskedTextBox();
            label12 = new Label();
            textBox1 = new TextBox();
            ValeAlimentacao = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            GerarFolha = new Button();
            SalarioL = new MaskedTextBox();
            label7 = new Label();
            HorasExt = new MaskedTextBox();
            ValeRefeicao = new MaskedTextBox();
            label6 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // cadastroFuncButton
            // 
            cadastroFuncButton.BackColor = Color.FromArgb(3, 139, 202);
            cadastroFuncButton.Cursor = Cursors.Hand;
            cadastroFuncButton.FlatStyle = FlatStyle.Flat;
            cadastroFuncButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroFuncButton.ForeColor = Color.White;
            cadastroFuncButton.Location = new Point(221, 3);
            cadastroFuncButton.Name = "cadastroFuncButton";
            cadastroFuncButton.Size = new Size(890, 34);
            cadastroFuncButton.TabIndex = 72;
            cadastroFuncButton.Text = "Folha de pagamento";
            cadastroFuncButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 660);
            panel1.TabIndex = 71;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(voltarButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 666);
            panel2.TabIndex = 7;
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.FromArgb(0, 74, 173);
            voltarButton.Cursor = Cursors.Hand;
            voltarButton.FlatStyle = FlatStyle.Popup;
            voltarButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.ForeColor = Color.White;
            voltarButton.Location = new Point(4, 3);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(44, 32);
            voltarButton.TabIndex = 33;
            voltarButton.Text = "<";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(253, 54);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 74;
            label1.Text = "Matricula";
            // 
            // Consultar
            // 
            Consultar.BackColor = Color.FromArgb(0, 74, 173);
            Consultar.Cursor = Cursors.Hand;
            Consultar.FlatStyle = FlatStyle.Popup;
            Consultar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Consultar.ForeColor = Color.White;
            Consultar.Location = new Point(458, 48);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(89, 33);
            Consultar.TabIndex = 75;
            Consultar.Text = "Consultar";
            Consultar.UseVisualStyleBackColor = false;
            Consultar.Click += Consultar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 77;
            label2.Text = "Nome";
            // 
            // Nome
            // 
            Nome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.Location = new Point(253, 109);
            Nome.Name = "Nome";
            Nome.Size = new Size(418, 23);
            Nome.TabIndex = 76;
            Nome.TextChanged += Nome_TextChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(689, 86);
            label10.Name = "label10";
            label10.Size = new Size(60, 21);
            label10.TabIndex = 79;
            label10.Text = "Cargo";
            // 
            // Cargo
            // 
            Cargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.Location = new Point(689, 109);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(206, 23);
            Cargo.TabIndex = 78;
            Cargo.TextChanged += Cargo_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 81;
            label3.Text = "Salário Bruto";
            // 
            // SalarioB
            // 
            SalarioB.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SalarioB.Location = new Point(24, 109);
            SalarioB.Name = "SalarioB";
            SalarioB.Size = new Size(114, 23);
            SalarioB.TabIndex = 82;
            SalarioB.MaskInputRejected += SalarioB_MaskInputRejected;
            // 
            // Matricula
            // 
            Matricula.Location = new Point(341, 52);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(100, 23);
            Matricula.TabIndex = 83;
            Matricula.TextChanged += Matricula_TextChanged_1;
            // 
            // INSS
            // 
            INSS.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            INSS.Location = new Point(277, 233);
            INSS.Name = "INSS";
            INSS.Size = new Size(114, 23);
            INSS.TabIndex = 84;
            INSS.TextChanged += INSS_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(277, 209);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 85;
            label4.Text = "INSS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(HEXTRA);
            panel3.Controls.Add(vt);
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(CalcularSL);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(ValeTransporte);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(ValeAlimentacao);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(GerarFolha);
            panel3.Controls.Add(SalarioL);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(HorasExt);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(ValeRefeicao);
            panel3.Controls.Add(INSS);
            panel3.Controls.Add(SalarioB);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(253, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 436);
            panel3.TabIndex = 86;
            panel3.Paint += panel3_Paint;
            // 
            // HEXTRA
            // 
            HEXTRA.AutoSize = true;
            HEXTRA.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HEXTRA.Location = new Point(24, 233);
            HEXTRA.Name = "HEXTRA";
            HEXTRA.Size = new Size(116, 25);
            HEXTRA.TabIndex = 112;
            HEXTRA.Text = "Hora Extras";
            HEXTRA.UseVisualStyleBackColor = true;
            HEXTRA.CheckedChanged += HEXTRA_CheckedChanged;
            // 
            // vt
            // 
            vt.AutoSize = true;
            vt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vt.Location = new Point(277, 140);
            vt.Name = "vt";
            vt.Size = new Size(151, 25);
            vt.TabIndex = 111;
            vt.Text = "Vale Transporte";
            vt.UseVisualStyleBackColor = true;
            vt.CheckedChanged += vt_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(436, 78);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(171, 25);
            checkBox2.TabIndex = 110;
            checkBox2.Text = "Vale Alimentação";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(277, 78);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 25);
            checkBox1.TabIndex = 109;
            checkBox1.Text = "Vale Refeição";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 74, 173);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(140, 388);
            button2.Name = "button2";
            button2.Size = new Size(110, 33);
            button2.TabIndex = 105;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CalcularSL
            // 
            CalcularSL.BackColor = Color.FromArgb(0, 74, 173);
            CalcularSL.Cursor = Cursors.Hand;
            CalcularSL.FlatStyle = FlatStyle.Popup;
            CalcularSL.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CalcularSL.ForeColor = Color.White;
            CalcularSL.Location = new Point(12, 388);
            CalcularSL.Name = "CalcularSL";
            CalcularSL.Size = new Size(110, 33);
            CalcularSL.TabIndex = 104;
            CalcularSL.Text = "Calcular";
            CalcularSL.UseVisualStyleBackColor = false;
            CalcularSL.Click += CalcularSL_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(495, 395);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 103;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // ValeTransporte
            // 
            ValeTransporte.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ValeTransporte.Location = new Point(277, 171);
            ValeTransporte.Name = "ValeTransporte";
            ValeTransporte.Size = new Size(141, 23);
            ValeTransporte.TabIndex = 101;
            ValeTransporte.MaskInputRejected += ValeTransporte_MaskInputRejected;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(277, 263);
            label12.Name = "label12";
            label12.Size = new Size(43, 21);
            label12.TabIndex = 100;
            label12.Text = "IRRF";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(277, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 99;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ValeAlimentacao
            // 
            ValeAlimentacao.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ValeAlimentacao.Location = new Point(436, 109);
            ValeAlimentacao.Name = "ValeAlimentacao";
            ValeAlimentacao.Size = new Size(171, 23);
            ValeAlimentacao.TabIndex = 98;
            ValeAlimentacao.MaskInputRejected += ValeAlimentacao_MaskInputRejected;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(348, 52);
            label9.Name = "label9";
            label9.Size = new Size(105, 22);
            label9.TabIndex = 96;
            label9.Text = "Descontos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 52);
            label8.Name = "label8";
            label8.Size = new Size(102, 22);
            label8.TabIndex = 95;
            label8.Text = "Proventos";
            // 
            // GerarFolha
            // 
            GerarFolha.BackColor = Color.FromArgb(0, 74, 173);
            GerarFolha.Cursor = Cursors.Hand;
            GerarFolha.FlatStyle = FlatStyle.Popup;
            GerarFolha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GerarFolha.ForeColor = Color.White;
            GerarFolha.Location = new Point(379, 388);
            GerarFolha.Name = "GerarFolha";
            GerarFolha.Size = new Size(110, 33);
            GerarFolha.TabIndex = 87;
            GerarFolha.Text = "Gerar Folha";
            GerarFolha.UseVisualStyleBackColor = false;
            GerarFolha.Click += GerarFolha_Click;
            // 
            // SalarioL
            // 
            SalarioL.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SalarioL.Location = new Point(24, 183);
            SalarioL.Name = "SalarioL";
            SalarioL.Size = new Size(114, 23);
            SalarioL.TabIndex = 94;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 159);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 93;
            label7.Text = "Salário Líquido";
            // 
            // HorasExt
            // 
            HorasExt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HorasExt.Location = new Point(24, 263);
            HorasExt.Name = "HorasExt";
            HorasExt.Size = new Size(114, 23);
            HorasExt.TabIndex = 91;
            HorasExt.MaskInputRejected += HorasExt_MaskInputRejected;
            // 
            // ValeRefeicao
            // 
            ValeRefeicao.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ValeRefeicao.Location = new Point(277, 109);
            ValeRefeicao.Name = "ValeRefeicao";
            ValeRefeicao.Size = new Size(137, 23);
            ValeRefeicao.TabIndex = 89;
            ValeRefeicao.MaskInputRejected += ValeRefeicao_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 9);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 92;
            label6.Text = "Lançamentos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(3, 139, 202);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(253, 152);
            panel4.Name = "panel4";
            panel4.Size = new Size(642, 40);
            panel4.TabIndex = 96;
            // 
            // FolhaPGTO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            ClientSize = new Size(1132, 660);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(Matricula);
            Controls.Add(label10);
            Controls.Add(Cargo);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(Consultar);
            Controls.Add(label1);
            Controls.Add(cadastroFuncButton);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FolhaPGTO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FolhaPGTO";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastroFuncButton;
        private Panel panel1;
        private Panel panel2;
        private Button voltarButton;
        private Label label1;
        private Button Consultar;
        private Label label2;
        private TextBox Nome;
        private Label label10;
        private TextBox Cargo;
        private Label label3;
        private MaskedTextBox SalarioB;
        private TextBox Matricula;
        private TextBox INSS;
        private Label label4;
        private Panel panel3;
        private MaskedTextBox HorasExt;
        private MaskedTextBox ValeRefeicao;
        private Button GerarFolha;
        private Button button2;
        private Button CalcularSL;
        private TextBox textBox2;
        private MaskedTextBox ValeTransporte;
        private Label label12;
        private TextBox textBox1;
        private MaskedTextBox ValeAlimentacao;
        private Label label9;
        private Label label8;
        private MaskedTextBox SalarioL;
        private Label label7;
        private Label label6;
        private Panel panel4;
        private CheckBox checkBox1;
        private CheckBox vt;
        private CheckBox checkBox2;
        private CheckBox HEXTRA;
    }
}