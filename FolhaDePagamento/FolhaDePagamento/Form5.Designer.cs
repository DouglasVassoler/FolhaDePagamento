namespace FolhaDePagamento
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            folhaDePagamentoButton = new Button();
            dadosEmpresaButton = new Button();
            matriculasButton = new Button();
            beneficiosButton = new Button();
            fecharButton5 = new Button();
            cadastroFuncButton = new Button();
            SuspendLayout();
            // 
            // folhaDePagamentoButton
            // 
            folhaDePagamentoButton.BackColor = Color.FromArgb(0, 74, 173);
            folhaDePagamentoButton.Cursor = Cursors.Hand;
            folhaDePagamentoButton.FlatStyle = FlatStyle.Flat;
            folhaDePagamentoButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            folhaDePagamentoButton.ForeColor = Color.White;
            folhaDePagamentoButton.Location = new Point(579, 337);
            folhaDePagamentoButton.Name = "folhaDePagamentoButton";
            folhaDePagamentoButton.Size = new Size(230, 65);
            folhaDePagamentoButton.TabIndex = 0;
            folhaDePagamentoButton.Text = "Folha de Pagamento ";
            folhaDePagamentoButton.UseVisualStyleBackColor = false;
            folhaDePagamentoButton.Click += folhaDePagamentoButton_Click;
            // 
            // dadosEmpresaButton
            // 
            dadosEmpresaButton.BackColor = Color.FromArgb(0, 74, 173);
            dadosEmpresaButton.Cursor = Cursors.Hand;
            dadosEmpresaButton.FlatStyle = FlatStyle.Flat;
            dadosEmpresaButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dadosEmpresaButton.ForeColor = Color.White;
            dadosEmpresaButton.Location = new Point(579, 259);
            dadosEmpresaButton.Name = "dadosEmpresaButton";
            dadosEmpresaButton.Size = new Size(230, 65);
            dadosEmpresaButton.TabIndex = 1;
            dadosEmpresaButton.Text = "Dados da Empresa";
            dadosEmpresaButton.UseVisualStyleBackColor = false;
            dadosEmpresaButton.Click += dadosEmpresaButton_Click;
            // 
            // matriculasButton
            // 
            matriculasButton.BackColor = Color.FromArgb(0, 74, 173);
            matriculasButton.Cursor = Cursors.Hand;
            matriculasButton.FlatStyle = FlatStyle.Flat;
            matriculasButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            matriculasButton.ForeColor = Color.White;
            matriculasButton.Location = new Point(328, 337);
            matriculasButton.Name = "matriculasButton";
            matriculasButton.Size = new Size(230, 65);
            matriculasButton.TabIndex = 2;
            matriculasButton.Text = "Impostos e encargos";
            matriculasButton.UseVisualStyleBackColor = false;
            matriculasButton.Click += matriculasButton_Click;
            // 
            // beneficiosButton
            // 
            beneficiosButton.BackColor = Color.FromArgb(0, 74, 173);
            beneficiosButton.Cursor = Cursors.Hand;
            beneficiosButton.FlatStyle = FlatStyle.Flat;
            beneficiosButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            beneficiosButton.ForeColor = Color.White;
            beneficiosButton.Location = new Point(456, 408);
            beneficiosButton.Name = "beneficiosButton";
            beneficiosButton.Size = new Size(230, 65);
            beneficiosButton.TabIndex = 3;
            beneficiosButton.Text = "Holerites";
            beneficiosButton.UseVisualStyleBackColor = false;
            beneficiosButton.Click += beneficiosButton_Click;
            // 
            // fecharButton5
            // 
            fecharButton5.BackColor = Color.Transparent;
            fecharButton5.Cursor = Cursors.Hand;
            fecharButton5.FlatStyle = FlatStyle.Flat;
            fecharButton5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fecharButton5.ForeColor = Color.FromArgb(0, 74, 173);
            fecharButton5.Location = new Point(467, 564);
            fecharButton5.Name = "fecharButton5";
            fecharButton5.Size = new Size(204, 57);
            fecharButton5.TabIndex = 4;
            fecharButton5.Text = "Fechar";
            fecharButton5.UseVisualStyleBackColor = false;
            fecharButton5.Click += fecharButton5_Click_1;
            // 
            // cadastroFuncButton
            // 
            cadastroFuncButton.BackColor = Color.FromArgb(0, 74, 173);
            cadastroFuncButton.Cursor = Cursors.Hand;
            cadastroFuncButton.FlatStyle = FlatStyle.Flat;
            cadastroFuncButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroFuncButton.ForeColor = Color.White;
            cadastroFuncButton.Location = new Point(328, 259);
            cadastroFuncButton.Name = "cadastroFuncButton";
            cadastroFuncButton.Size = new Size(230, 65);
            cadastroFuncButton.TabIndex = 5;
            cadastroFuncButton.Text = "Cadastro de Funcionário";
            cadastroFuncButton.UseVisualStyleBackColor = false;
            cadastroFuncButton.Click += cadastroFuncButton_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1132, 660);
            Controls.Add(cadastroFuncButton);
            Controls.Add(fecharButton5);
            Controls.Add(beneficiosButton);
            Controls.Add(matriculasButton);
            Controls.Add(dadosEmpresaButton);
            Controls.Add(folhaDePagamentoButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button folhaDePagamentoButton;
        private Button dadosEmpresaButton;
        private Button matriculasButton;
        private Button beneficiosButton;
        private Button fecharButton5;
        private Button cadastroFuncButton;
    }
}