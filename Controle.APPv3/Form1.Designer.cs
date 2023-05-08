namespace Controle.APPv3
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
            butaoListarProjetos = new Button();
            label1 = new Label();
            listarProjetos = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // butaoListarProjetos
            // 
            butaoListarProjetos.BackColor = Color.DarkGray;
            butaoListarProjetos.FlatAppearance.BorderSize = 0;
            butaoListarProjetos.FlatStyle = FlatStyle.Flat;
            butaoListarProjetos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            butaoListarProjetos.ForeColor = SystemColors.ControlText;
            butaoListarProjetos.Location = new Point(36, 111);
            butaoListarProjetos.Margin = new Padding(4, 5, 4, 5);
            butaoListarProjetos.Name = "butaoListarProjetos";
            butaoListarProjetos.Size = new Size(307, 128);
            butaoListarProjetos.TabIndex = 0;
            butaoListarProjetos.Text = "Cadastro de Projetos";
            butaoListarProjetos.UseVisualStyleBackColor = false;
            butaoListarProjetos.Click += button1_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(46, 12, 54);
            label1.Font = new Font("Courier New", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(240, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(572, 46);
            label1.TabIndex = 2;
            label1.Text = "Cadastrador de projetos";
            label1.Click += label1_Click;
            // 
            // listarProjetos
            // 
            listarProjetos.BackColor = Color.DarkGray;
            listarProjetos.FlatAppearance.BorderColor = Color.Navy;
            listarProjetos.FlatAppearance.BorderSize = 0;
            listarProjetos.FlatStyle = FlatStyle.Flat;
            listarProjetos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listarProjetos.ForeColor = SystemColors.ActiveCaptionText;
            listarProjetos.Location = new Point(40, 316);
            listarProjetos.Margin = new Padding(4, 5, 4, 5);
            listarProjetos.Name = "listarProjetos";
            listarProjetos.Size = new Size(303, 120);
            listarProjetos.TabIndex = 3;
            listarProjetos.Text = "Listar Projetos";
            listarProjetos.UseVisualStyleBackColor = false;
            listarProjetos.Click += listarProjetos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(626, 284);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 18, 54);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 132);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 18, 54);
            panel2.Controls.Add(listarProjetos);
            panel2.Controls.Add(butaoListarProjetos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 618);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(88, 34, 117);
            ClientSize = new Size(1143, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(41, 44, 51, 41);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrador de Projetos";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button butaoListarProjetos;
        private Label label1;
        private Button listarProjetos;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}