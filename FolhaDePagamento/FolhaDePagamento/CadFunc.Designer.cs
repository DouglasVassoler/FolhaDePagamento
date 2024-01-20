namespace FolhaDePagamento
{
    partial class CadFunc
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFunc));
            panel1 = new Panel();
            voltarButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            imageList1 = new ImageList(components);
            label11 = new Label();
            label12 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label13 = new Label();
            label14 = new Label();
            Matricula = new TextBox();
            Empresa = new TextBox();
            CNPJ = new MaskedTextBox();
            Nome = new TextBox();
            dtNasc = new MaskedTextBox();
            Telefone = new MaskedTextBox();
            Endereco = new TextBox();
            Criar = new Button();
            Cargo = new TextBox();
            CPF = new MaskedTextBox();
            CEP = new MaskedTextBox();
            NUM = new TextBox();
            Bairro = new TextBox();
            Email = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(voltarButton);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 663);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 2;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(232, 177);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 4;
            label2.Text = "Nome completo *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(679, 177);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 5;
            label3.Text = "CPF *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(891, 177);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(74, 21);
            label4.TabIndex = 8;
            label4.Text = "Dt. nasc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(785, 177);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(232, 259);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 12;
            label6.Text = "Endereço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(799, 259);
            label7.Name = "label7";
            label7.Size = new Size(26, 21);
            label7.TabIndex = 14;
            label7.Text = "nº";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(843, 259);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 15;
            label8.Text = "cep";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(949, 259);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 18;
            label9.Text = "Bairro";
            label9.Click += label9_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(232, 496);
            label10.Name = "label10";
            label10.Size = new Size(60, 21);
            label10.TabIndex = 20;
            label10.Text = "Cargo";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(232, 337);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 22;
            label11.Text = "E-mail";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(978, 177);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(46, 21);
            label12.TabIndex = 23;
            label12.Text = "Sexo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(978, 221);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(102, 24);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(978, 200);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 24);
            radioButton2.TabIndex = 25;
            radioButton2.TabStop = true;
            radioButton2.Text = "Feminino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(232, 113);
            label13.Name = "label13";
            label13.Size = new Size(77, 21);
            label13.TabIndex = 27;
            label13.Text = "Empresa";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(511, 113);
            label14.Name = "label14";
            label14.Size = new Size(52, 21);
            label14.TabIndex = 29;
            label14.Text = "CNPJ";
            // 
            // Matricula
            // 
            Matricula.Location = new Point(232, 53);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(100, 23);
            Matricula.TabIndex = 32;
            Matricula.TextChanged += Matricula_TextChanged;
            // 
            // Empresa
            // 
            Empresa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Empresa.Location = new Point(232, 137);
            Empresa.Name = "Empresa";
            Empresa.Size = new Size(255, 23);
            Empresa.TabIndex = 33;
            Empresa.TextChanged += Empresa_TextChanged;
            // 
            // CNPJ
            // 
            CNPJ.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CNPJ.Location = new Point(511, 137);
            CNPJ.Mask = "00,000,000/0000-00";
            CNPJ.Name = "CNPJ";
            CNPJ.Size = new Size(131, 23);
            CNPJ.TabIndex = 34;
            CNPJ.MaskInputRejected += CNPJ_MaskInputRejected;
            // 
            // Nome
            // 
            Nome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.Location = new Point(232, 202);
            Nome.Name = "Nome";
            Nome.Size = new Size(441, 23);
            Nome.TabIndex = 35;
            Nome.TextChanged += Nome_TextChanged;
            // 
            // dtNasc
            // 
            dtNasc.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtNasc.Location = new Point(897, 202);
            dtNasc.Mask = "00/00/0000";
            dtNasc.Name = "dtNasc";
            dtNasc.Size = new Size(75, 23);
            dtNasc.TabIndex = 40;
            dtNasc.ValidatingType = typeof(DateTime);
            dtNasc.MaskInputRejected += dtNasc_MaskInputRejected;
            // 
            // Telefone
            // 
            Telefone.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Telefone.Location = new Point(785, 202);
            Telefone.Mask = "(00) 0 0000-0000";
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(106, 23);
            Telefone.TabIndex = 39;
            Telefone.MaskInputRejected += Telefone_MaskInputRejected;
            // 
            // Endereco
            // 
            Endereco.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Endereco.Location = new Point(232, 283);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(561, 23);
            Endereco.TabIndex = 41;
            Endereco.TextChanged += Endereco_TextChanged;
            // 
            // Criar
            // 
            Criar.BackColor = Color.FromArgb(0, 74, 173);
            Criar.Cursor = Cursors.Hand;
            Criar.FlatStyle = FlatStyle.Popup;
            Criar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Criar.ForeColor = Color.White;
            Criar.Location = new Point(1032, 1);
            Criar.Name = "Criar";
            Criar.Size = new Size(70, 32);
            Criar.TabIndex = 45;
            Criar.Text = "Criar";
            Criar.UseVisualStyleBackColor = false;
            Criar.Click += Criar_Click;
            // 
            // Cargo
            // 
            Cargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.Location = new Point(232, 520);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(206, 23);
            Cargo.TabIndex = 46;
            Cargo.TextChanged += Cargo_TextChanged;
            // 
            // CPF
            // 
            CPF.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CPF.Location = new Point(681, 202);
            CPF.Mask = "000,000,000-00";
            CPF.Name = "CPF";
            CPF.Size = new Size(98, 23);
            CPF.TabIndex = 47;
            CPF.MaskInputRejected += CPF_MaskInputRejected;
            // 
            // CEP
            // 
            CEP.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CEP.Location = new Point(843, 283);
            CEP.Mask = "00000-000";
            CEP.Name = "CEP";
            CEP.Size = new Size(100, 23);
            CEP.TabIndex = 48;
            CEP.MaskInputRejected += CEP_MaskInputRejected_1;
            // 
            // NUM
            // 
            NUM.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NUM.Location = new Point(799, 283);
            NUM.Name = "NUM";
            NUM.Size = new Size(38, 23);
            NUM.TabIndex = 49;
            NUM.TextChanged += NUM_TextChanged_1;
            // 
            // Bairro
            // 
            Bairro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bairro.Location = new Point(949, 283);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(134, 23);
            Bairro.TabIndex = 50;
            Bairro.TextChanged += Bairro_TextChanged_1;
            // 
            // Email
            // 
            Email.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(232, 360);
            Email.Name = "Email";
            Email.Size = new Size(255, 23);
            Email.TabIndex = 51;
            Email.TextChanged += Email_TextChanged;
            // 
            // CadFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            ClientSize = new Size(1132, 660);
            Controls.Add(Email);
            Controls.Add(Bairro);
            Controls.Add(NUM);
            Controls.Add(CEP);
            Controls.Add(CPF);
            Controls.Add(Cargo);
            Controls.Add(Criar);
            Controls.Add(Endereco);
            Controls.Add(dtNasc);
            Controls.Add(Telefone);
            Controls.Add(Nome);
            Controls.Add(CNPJ);
            Controls.Add(Empresa);
            Controls.Add(Matricula);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadFunc";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private MaskedTextBox dtNasc;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ImageList imageList1;
        private Label label11;
        private Label label12;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label13;
        private Label label14;
        private Button voltarButton;
        private TextBox Matricula;
        private TextBox Empresa;
        private MaskedTextBox CNPJ;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox7;
        private TextBox Nome;
        private MaskedTextBox Telefone;
        private TextBox Endereco;
        private Button Criar;
        private TextBox Cargo;
        private MaskedTextBox CPF;
        private MaskedTextBox CEP;
        private TextBox NUM;
        private TextBox Bairro;
        private TextBox Email;
    }
}