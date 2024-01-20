namespace FolhaDePagamento
{
    partial class Menucad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menucad));
            cadastroFuncButton = new Button();
            beneficiosButton = new Button();
            matriculasButton = new Button();
            dadosEmpresaButton = new Button();
            voltarButton = new Button();
            SuspendLayout();
            // 
            // cadastroFuncButton
            // 
            cadastroFuncButton.BackColor = Color.FromArgb(0, 74, 173);
            cadastroFuncButton.Cursor = Cursors.Hand;
            cadastroFuncButton.FlatStyle = FlatStyle.Flat;
            cadastroFuncButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroFuncButton.ForeColor = Color.White;
            cadastroFuncButton.Location = new Point(326, 259);
            cadastroFuncButton.Name = "cadastroFuncButton";
            cadastroFuncButton.Size = new Size(230, 65);
            cadastroFuncButton.TabIndex = 9;
            cadastroFuncButton.Text = "Cadastrar";
            cadastroFuncButton.UseVisualStyleBackColor = false;
            cadastroFuncButton.Click += cadastroFuncButton_Click;
            // 
            // beneficiosButton
            // 
            beneficiosButton.BackColor = Color.FromArgb(0, 74, 173);
            beneficiosButton.Cursor = Cursors.Hand;
            beneficiosButton.FlatStyle = FlatStyle.Flat;
            beneficiosButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            beneficiosButton.ForeColor = Color.White;
            beneficiosButton.Location = new Point(577, 337);
            beneficiosButton.Name = "beneficiosButton";
            beneficiosButton.Size = new Size(230, 65);
            beneficiosButton.TabIndex = 8;
            beneficiosButton.Text = "Consultar";
            beneficiosButton.UseVisualStyleBackColor = false;
            beneficiosButton.Click += beneficiosButton_Click;
            // 
            // matriculasButton
            // 
            matriculasButton.BackColor = Color.FromArgb(0, 74, 173);
            matriculasButton.Cursor = Cursors.Hand;
            matriculasButton.FlatStyle = FlatStyle.Flat;
            matriculasButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            matriculasButton.ForeColor = Color.White;
            matriculasButton.Location = new Point(326, 337);
            matriculasButton.Name = "matriculasButton";
            matriculasButton.Size = new Size(230, 65);
            matriculasButton.TabIndex = 7;
            matriculasButton.Text = "Excluir";
            matriculasButton.UseVisualStyleBackColor = false;
            matriculasButton.Click += matriculasButton_Click;
            // 
            // dadosEmpresaButton
            // 
            dadosEmpresaButton.BackColor = Color.FromArgb(0, 74, 173);
            dadosEmpresaButton.Cursor = Cursors.Hand;
            dadosEmpresaButton.FlatStyle = FlatStyle.Flat;
            dadosEmpresaButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dadosEmpresaButton.ForeColor = Color.White;
            dadosEmpresaButton.Location = new Point(577, 259);
            dadosEmpresaButton.Name = "dadosEmpresaButton";
            dadosEmpresaButton.Size = new Size(230, 65);
            dadosEmpresaButton.TabIndex = 6;
            dadosEmpresaButton.Text = "Alterar";
            dadosEmpresaButton.UseVisualStyleBackColor = false;
            dadosEmpresaButton.Click += dadosEmpresaButton_Click;
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.FromArgb(0, 74, 173);
            voltarButton.Cursor = Cursors.Hand;
            voltarButton.FlatStyle = FlatStyle.Popup;
            voltarButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.ForeColor = Color.White;
            voltarButton.Location = new Point(3, 2);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(44, 32);
            voltarButton.TabIndex = 34;
            voltarButton.Text = "<";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // Menucad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1132, 660);
            Controls.Add(voltarButton);
            Controls.Add(cadastroFuncButton);
            Controls.Add(beneficiosButton);
            Controls.Add(matriculasButton);
            Controls.Add(dadosEmpresaButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menucad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menucad";
            ResumeLayout(false);
        }

        #endregion

        private Button cadastroFuncButton;
        private Button beneficiosButton;
        private Button matriculasButton;
        private Button dadosEmpresaButton;
        private Button voltarButton;
    }
}