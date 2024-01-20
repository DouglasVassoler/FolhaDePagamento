namespace FolhaDePagamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fecharLinkLabel1 = new LinkLabel();
            loginButton1 = new Button();
            tituloLabel1 = new Label();
            checkBox1 = new CheckBox();
            esqueciSenhaLinkLabel1 = new LinkLabel();
            textBoxSenha1 = new TextBox();
            senhaLabel1 = new Label();
            textBoxEmail1 = new TextBox();
            usuarioLabel1 = new Label();
            SuspendLayout();
            // 
            // fecharLinkLabel1
            // 
            fecharLinkLabel1.AutoSize = true;
            fecharLinkLabel1.Font = new Font("Century Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            fecharLinkLabel1.LinkColor = Color.FromArgb(29, 97, 189);
            fecharLinkLabel1.Location = new Point(249, 559);
            fecharLinkLabel1.Name = "fecharLinkLabel1";
            fecharLinkLabel1.Size = new Size(90, 27);
            fecharLinkLabel1.TabIndex = 11;
            fecharLinkLabel1.TabStop = true;
            fecharLinkLabel1.Text = "Fechar";
            fecharLinkLabel1.LinkClicked += fecharLinkLabel1_LinkClicked;
            // 
            // loginButton1
            // 
            loginButton1.BackColor = Color.FromArgb(29, 97, 189);
            loginButton1.Cursor = Cursors.Hand;
            loginButton1.FlatStyle = FlatStyle.Flat;
            loginButton1.Font = new Font("Century Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton1.ForeColor = Color.White;
            loginButton1.Location = new Point(197, 492);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new Size(193, 47);
            loginButton1.TabIndex = 10;
            loginButton1.Text = "Entrar";
            loginButton1.UseVisualStyleBackColor = false;
            loginButton1.Click += loginButton1_Click;
            // 
            // tituloLabel1
            // 
            tituloLabel1.AutoSize = true;
            tituloLabel1.BackColor = Color.Transparent;
            tituloLabel1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            tituloLabel1.ForeColor = Color.Black;
            tituloLabel1.Location = new Point(160, 141);
            tituloLabel1.Name = "tituloLabel1";
            tituloLabel1.Size = new Size(291, 36);
            tituloLabel1.TabIndex = 0;
            tituloLabel1.Text = "Seja Bem-Vindo(a)!";
            tituloLabel1.Click += tituloLabel1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(330, 402);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Mostrar senha";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // esqueciSenhaLinkLabel1
            // 
            esqueciSenhaLinkLabel1.AutoSize = true;
            esqueciSenhaLinkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            esqueciSenhaLinkLabel1.LinkColor = Color.FromArgb(29, 97, 189);
            esqueciSenhaLinkLabel1.Location = new Point(119, 403);
            esqueciSenhaLinkLabel1.Name = "esqueciSenhaLinkLabel1";
            esqueciSenhaLinkLabel1.Size = new Size(135, 21);
            esqueciSenhaLinkLabel1.TabIndex = 6;
            esqueciSenhaLinkLabel1.TabStop = true;
            esqueciSenhaLinkLabel1.Text = "Esqueci a senha";
            esqueciSenhaLinkLabel1.LinkClicked += esqueciSenhaLinkLabel1_LinkClicked;
            // 
            // textBoxSenha1
            // 
            textBoxSenha1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha1.Location = new Point(119, 368);
            textBoxSenha1.Multiline = true;
            textBoxSenha1.Name = "textBoxSenha1";
            textBoxSenha1.PasswordChar = '*';
            textBoxSenha1.Size = new Size(359, 28);
            textBoxSenha1.TabIndex = 9;
            // 
            // senhaLabel1
            // 
            senhaLabel1.AutoSize = true;
            senhaLabel1.BackColor = Color.Transparent;
            senhaLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel1.ForeColor = Color.Black;
            senhaLabel1.Location = new Point(119, 338);
            senhaLabel1.Name = "senhaLabel1";
            senhaLabel1.Size = new Size(79, 24);
            senhaLabel1.TabIndex = 8;
            senhaLabel1.Text = "Senha:";
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail1.Location = new Point(119, 271);
            textBoxEmail1.Multiline = true;
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(359, 28);
            textBoxEmail1.TabIndex = 3;
            textBoxEmail1.TextChanged += textBoxEmail1_TextChanged;
            // 
            // usuarioLabel1
            // 
            usuarioLabel1.AutoSize = true;
            usuarioLabel1.BackColor = Color.Transparent;
            usuarioLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            usuarioLabel1.ForeColor = Color.Black;
            usuarioLabel1.Location = new Point(119, 241);
            usuarioLabel1.Name = "usuarioLabel1";
            usuarioLabel1.Size = new Size(76, 24);
            usuarioLabel1.TabIndex = 2;
            usuarioLabel1.Text = "E-mail:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(598, 674);
            Controls.Add(fecharLinkLabel1);
            Controls.Add(loginButton1);
            Controls.Add(textBoxSenha1);
            Controls.Add(senhaLabel1);
            Controls.Add(esqueciSenhaLinkLabel1);
            Controls.Add(textBoxEmail1);
            Controls.Add(usuarioLabel1);
            Controls.Add(tituloLabel1);
            Controls.Add(checkBox1);
            Cursor = Cursors.Default;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel fecharLinkLabel1;
        private Button loginButton1;
        private Label tituloLabel1;
        private CheckBox checkBox1;
        private LinkLabel esqueciSenhaLinkLabel1;
        private TextBox textBoxSenha1;
        private Label senhaLabel1;
        private TextBox textBoxEmail1;
        private Label usuarioLabel1;
    }
}