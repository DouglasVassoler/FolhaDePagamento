namespace FolhaDePagamento
{
    partial class Encargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encargos));
            panel1 = new Panel();
            panel2 = new Panel();
            voltarButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cadastroFuncButton = new Button();
            button4 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 660);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            voltarButton.Location = new Point(3, 3);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(44, 32);
            voltarButton.TabIndex = 33;
            voltarButton.Text = "<";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // cadastroFuncButton
            // 
            cadastroFuncButton.BackColor = Color.FromArgb(0, 74, 173);
            cadastroFuncButton.Cursor = Cursors.Hand;
            cadastroFuncButton.FlatStyle = FlatStyle.Flat;
            cadastroFuncButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroFuncButton.ForeColor = Color.White;
            cadastroFuncButton.Location = new Point(282, 18);
            cadastroFuncButton.Name = "cadastroFuncButton";
            cadastroFuncButton.Size = new Size(761, 33);
            cadastroFuncButton.TabIndex = 6;
            cadastroFuncButton.Text = "Encargos";
            cadastroFuncButton.UseVisualStyleBackColor = false;
            cadastroFuncButton.Click += cadastroFuncButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 74, 173);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(580, 57);
            button4.Name = "button4";
            button4.Size = new Size(75, 27);
            button4.TabIndex = 7;
            button4.Text = "IRRF";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 74, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(661, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 8;
            button1.Text = "INSS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Encargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            ClientSize = new Size(1132, 660);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(cadastroFuncButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Encargos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encargos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button cadastroFuncButton;
        private Panel panel2;
        private Button voltarButton;
        private Button button4;
        private Button button1;
    }
}