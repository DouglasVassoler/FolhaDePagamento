namespace FolhaDePagamento
{
    partial class holerite2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(holerite2));
            voltarButton = new Button();
            Matricula = new TextBox();
            button1 = new Button();
            Holeri = new Button();
            panel2 = new Panel();
            TDescontos = new Label();
            SalBase = new Label();
            BIRRF = new Label();
            Mesref = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            // Matricula
            // 
            Matricula.Location = new Point(232, 58);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(100, 23);
            Matricula.TabIndex = 93;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 74, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(353, 58);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 90;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Holeri
            // 
            Holeri.BackColor = Color.FromArgb(0, 74, 173);
            Holeri.Cursor = Cursors.Hand;
            Holeri.FlatStyle = FlatStyle.Flat;
            Holeri.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Holeri.ForeColor = Color.White;
            Holeri.Location = new Point(232, 18);
            Holeri.Name = "Holeri";
            Holeri.Size = new Size(872, 33);
            Holeri.TabIndex = 91;
            Holeri.Text = "Holerite";
            Holeri.TextImageRelation = TextImageRelation.TextBeforeImage;
            Holeri.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(voltarButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 666);
            panel2.TabIndex = 89;
            // 
            // TDescontos
            // 
            TDescontos.AutoSize = true;
            TDescontos.BackColor = Color.Transparent;
            TDescontos.Location = new Point(654, 336);
            TDescontos.Name = "TDescontos";
            TDescontos.Size = new Size(0, 15);
            TDescontos.TabIndex = 138;
            // 
            // SalBase
            // 
            SalBase.AutoSize = true;
            SalBase.BackColor = Color.Transparent;
            SalBase.Location = new Point(34, 417);
            SalBase.Name = "SalBase";
            SalBase.Size = new Size(0, 15);
            SalBase.TabIndex = 140;
            // 
            // BIRRF
            // 
            BIRRF.AutoSize = true;
            BIRRF.BackColor = Color.Transparent;
            BIRRF.Location = new Point(654, 417);
            BIRRF.Name = "BIRRF";
            BIRRF.Size = new Size(0, 15);
            BIRRF.TabIndex = 143;
            // 
            // Mesref
            // 
            Mesref.AutoSize = true;
            Mesref.BackColor = Color.Transparent;
            Mesref.Location = new Point(615, 15);
            Mesref.Name = "Mesref";
            Mesref.Size = new Size(0, 15);
            Mesref.TabIndex = 144;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(Mesref);
            panel3.Controls.Add(BIRRF);
            panel3.Controls.Add(SalBase);
            panel3.Controls.Add(TDescontos);
            panel3.Location = new Point(221, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(883, 436);
            panel3.TabIndex = 92;
            // 
            // holerite2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            ClientSize = new Size(1116, 621);
            Controls.Add(Matricula);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(Holeri);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "holerite2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "holerite2";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private TextBox Matricula;
        private Button button1;
        private Button Holeri;
        private Panel panel2;
        private Label TDescontos;
        private Label SalBase;
        private Label BIRRF;
        private Label Mesref;
        private Panel panel3;
    }
}