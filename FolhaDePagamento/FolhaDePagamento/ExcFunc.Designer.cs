namespace FolhaDePagamento
{
    partial class ExcFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcFunc));
            panel1 = new Panel();
            voltarButton = new Button();
            button1 = new Button();
            CNPJ = new MaskedTextBox();
            label14 = new Label();
            label13 = new Label();
            Empresa = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label12 = new Label();
            label11 = new Label();
            Email = new TextBox();
            label10 = new Label();
            Cargo = new TextBox();
            label9 = new Label();
            Bairro = new TextBox();
            CEP = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            Num = new TextBox();
            label6 = new Label();
            Endereco = new TextBox();
            Telef = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            DtNasc = new MaskedTextBox();
            CPF = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            Nome = new TextBox();
            label1 = new Label();
            Matricula = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(voltarButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 669);
            panel1.TabIndex = 1;
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.FromArgb(0, 74, 173);
            voltarButton.Cursor = Cursors.Hand;
            voltarButton.FlatStyle = FlatStyle.Popup;
            voltarButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.ForeColor = Color.White;
            voltarButton.Location = new Point(4, 2);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(44, 32);
            voltarButton.TabIndex = 32;
            voltarButton.Text = "<";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 74, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1035, 1);
            button1.Name = "button1";
            button1.Size = new Size(70, 32);
            button1.TabIndex = 61;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CNPJ
            // 
            CNPJ.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CNPJ.Location = new Point(512, 136);
            CNPJ.Mask = "00,000,000/0000-00";
            CNPJ.Name = "CNPJ";
            CNPJ.Size = new Size(131, 23);
            CNPJ.TabIndex = 60;
            CNPJ.MaskInputRejected += maskedTextBox5_MaskInputRejected;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(512, 113);
            label14.Name = "label14";
            label14.Size = new Size(52, 21);
            label14.TabIndex = 59;
            label14.Text = "CNPJ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(233, 113);
            label13.Name = "label13";
            label13.Size = new Size(77, 21);
            label13.TabIndex = 58;
            label13.Text = "Empresa";
            // 
            // Empresa
            // 
            Empresa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Empresa.Location = new Point(233, 136);
            Empresa.Name = "Empresa";
            Empresa.Size = new Size(255, 23);
            Empresa.TabIndex = 57;
            Empresa.TextChanged += textBox8_TextChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(979, 200);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 24);
            radioButton2.TabIndex = 56;
            radioButton2.TabStop = true;
            radioButton2.Text = "Feminino";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(979, 221);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(102, 24);
            radioButton1.TabIndex = 55;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(979, 177);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(46, 21);
            label12.TabIndex = 54;
            label12.Text = "Sexo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(233, 337);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 53;
            label11.Text = "E-mail";
            // 
            // Email
            // 
            Email.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(233, 360);
            Email.Name = "Email";
            Email.Size = new Size(255, 23);
            Email.TabIndex = 52;
            Email.TextChanged += textBox7_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(233, 496);
            label10.Name = "label10";
            label10.Size = new Size(60, 21);
            label10.TabIndex = 51;
            label10.Text = "Cargo";
            // 
            // Cargo
            // 
            Cargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.Location = new Point(233, 519);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(206, 23);
            Cargo.TabIndex = 50;
            Cargo.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(950, 259);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 49;
            label9.Text = "Bairro";
            // 
            // Bairro
            // 
            Bairro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bairro.Location = new Point(950, 282);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(134, 23);
            Bairro.TabIndex = 48;
            Bairro.TextChanged += textBox5_TextChanged;
            // 
            // CEP
            // 
            CEP.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CEP.Location = new Point(844, 282);
            CEP.Mask = "00000-000";
            CEP.Name = "CEP";
            CEP.Size = new Size(100, 23);
            CEP.TabIndex = 47;
            CEP.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(844, 259);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 46;
            label8.Text = "cep";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(800, 259);
            label7.Name = "label7";
            label7.Size = new Size(26, 21);
            label7.TabIndex = 45;
            label7.Text = "nº";
            // 
            // Num
            // 
            Num.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Num.Location = new Point(800, 282);
            Num.Name = "Num";
            Num.Size = new Size(38, 23);
            Num.TabIndex = 44;
            Num.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(233, 259);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 43;
            label6.Text = "Endereço";
            // 
            // Endereco
            // 
            Endereco.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Endereco.Location = new Point(233, 282);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(561, 23);
            Endereco.TabIndex = 42;
            Endereco.TextChanged += textBox3_TextChanged;
            // 
            // Telef
            // 
            Telef.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Telef.Location = new Point(786, 200);
            Telef.Mask = "(00) 0 0000-0000";
            Telef.Name = "Telef";
            Telef.Size = new Size(100, 23);
            Telef.TabIndex = 41;
            Telef.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(786, 177);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 40;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(892, 177);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(74, 21);
            label4.TabIndex = 39;
            label4.Text = "Dt. nasc";
            // 
            // DtNasc
            // 
            DtNasc.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DtNasc.Location = new Point(892, 200);
            DtNasc.Mask = "00/00/0000";
            DtNasc.Name = "DtNasc";
            DtNasc.Size = new Size(74, 23);
            DtNasc.TabIndex = 38;
            DtNasc.TextAlign = HorizontalAlignment.Center;
            DtNasc.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // CPF
            // 
            CPF.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CPF.Location = new Point(680, 200);
            CPF.Mask = "000,000,000-00";
            CPF.Name = "CPF";
            CPF.Size = new Size(100, 23);
            CPF.TabIndex = 37;
            CPF.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(680, 177);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 36;
            label3.Text = "CPF *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(233, 177);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 35;
            label2.Text = "Nome completo *";
            // 
            // Nome
            // 
            Nome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.Location = new Point(233, 200);
            Nome.Name = "Nome";
            Nome.Size = new Size(441, 23);
            Nome.TabIndex = 34;
            Nome.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 33;
            label1.Text = "Matricula";
            // 
            // Matricula
            // 
            Matricula.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Matricula.Location = new Point(233, 52);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(100, 23);
            Matricula.TabIndex = 32;
            Matricula.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 74, 173);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(929, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 62;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ExcFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            ClientSize = new Size(1132, 660);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CNPJ);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Empresa);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(Email);
            Controls.Add(label10);
            Controls.Add(Cargo);
            Controls.Add(label9);
            Controls.Add(Bairro);
            Controls.Add(CEP);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Num);
            Controls.Add(label6);
            Controls.Add(Endereco);
            Controls.Add(Telef);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DtNasc);
            Controls.Add(CPF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(label1);
            Controls.Add(Matricula);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExcFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExcFunc";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button voltarButton;
        private Button button1;
        private MaskedTextBox CNPJ;
        private Label label14;
        private Label label13;
        private TextBox Empresa;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label12;
        private Label label11;
        private TextBox Email;
        private Label label10;
        private TextBox Cargo;
        private Label label9;
        private TextBox Bairro;
        private MaskedTextBox CEP;
        private Label label8;
        private Label label7;
        private TextBox Num;
        private Label label6;
        private TextBox Endereco;
        private MaskedTextBox Telef;
        private Label label5;
        private Label label4;
        private MaskedTextBox DtNasc;
        private MaskedTextBox CPF;
        private Label label3;
        private Label label2;
        private TextBox Nome;
        private Label label1;
        private TextBox Matricula;
        private Button button2;
    }
}