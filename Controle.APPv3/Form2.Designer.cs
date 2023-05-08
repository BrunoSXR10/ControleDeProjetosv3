namespace Controle.APPv3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            nomeGerente = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            status = new TextBox();
            label8 = new Label();
            label6 = new Label();
            resumo = new TextBox();
            nomeProjeto = new TextBox();
            cadastrar = new Button();
            TelaIncial = new Button();
            dataInicio = new DateTimePicker();
            dataFim = new DateTimePicker();
            editarProjetos = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(36, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 4;
            label2.Text = "Nome do projeto";
            // 
            // nomeGerente
            // 
            nomeGerente.BackColor = SystemColors.ControlLight;
            nomeGerente.Location = new Point(483, 80);
            nomeGerente.Margin = new Padding(4, 5, 4, 5);
            nomeGerente.MaxLength = 100;
            nomeGerente.Name = "nomeGerente";
            nomeGerente.Size = new Size(371, 31);
            nomeGerente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(483, 31);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 7;
            label4.Text = "Nome do gerente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(36, 143);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 10;
            label7.Text = "Data Inicio";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(483, 286);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 15;
            label5.Text = "Status do projeto";
            label5.Click += label5_Click;
            // 
            // status
            // 
            status.BackColor = SystemColors.ControlLight;
            status.Location = new Point(483, 316);
            status.Margin = new Padding(4, 5, 4, 5);
            status.MaxLength = 20;
            status.Name = "status";
            status.Size = new Size(371, 31);
            status.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(483, 143);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 17;
            label8.Text = "Data Final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(36, 276);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 19;
            label6.Text = "Resumo";
            // 
            // resumo
            // 
            resumo.BackColor = SystemColors.ControlLight;
            resumo.Location = new Point(36, 306);
            resumo.Margin = new Padding(4, 5, 4, 5);
            resumo.MaxLength = 500;
            resumo.Multiline = true;
            resumo.Name = "resumo";
            resumo.Size = new Size(374, 205);
            resumo.TabIndex = 20;
            // 
            // nomeProjeto
            // 
            nomeProjeto.BackColor = SystemColors.ControlLight;
            nomeProjeto.Location = new Point(36, 80);
            nomeProjeto.Margin = new Padding(4, 5, 4, 5);
            nomeProjeto.MaxLength = 100;
            nomeProjeto.Name = "nomeProjeto";
            nomeProjeto.Size = new Size(363, 31);
            nomeProjeto.TabIndex = 22;
            // 
            // cadastrar
            // 
            cadastrar.BackColor = SystemColors.ButtonFace;
            cadastrar.Location = new Point(36, 558);
            cadastrar.Margin = new Padding(4, 5, 4, 5);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(250, 69);
            cadastrar.TabIndex = 23;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.Click += cadastrar_Click;
            // 
            // TelaIncial
            // 
            TelaIncial.BackColor = Color.RoyalBlue;
            TelaIncial.Location = new Point(913, 31);
            TelaIncial.Margin = new Padding(4, 5, 4, 5);
            TelaIncial.Name = "TelaIncial";
            TelaIncial.Size = new Size(149, 58);
            TelaIncial.TabIndex = 26;
            TelaIncial.Text = "Tela Inicial";
            TelaIncial.UseVisualStyleBackColor = false;
            TelaIncial.Click += TelaIncial_Click;
            // 
            // dataInicio
            // 
            dataInicio.Location = new Point(36, 185);
            dataInicio.Margin = new Padding(4, 5, 4, 5);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(374, 31);
            dataInicio.TabIndex = 28;
            dataInicio.ValueChanged += dataInicio_ValueChanged;
            // 
            // dataFim
            // 
            dataFim.Location = new Point(483, 185);
            dataFim.Margin = new Padding(4, 5, 4, 5);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(371, 31);
            dataFim.TabIndex = 29;
            // 
            // editarProjetos
            // 
            editarProjetos.BackColor = SystemColors.ButtonFace;
            editarProjetos.Location = new Point(483, 558);
            editarProjetos.Margin = new Padding(4, 5, 4, 5);
            editarProjetos.Name = "editarProjetos";
            editarProjetos.Size = new Size(277, 69);
            editarProjetos.TabIndex = 30;
            editarProjetos.Text = "Editar Projetos";
            editarProjetos.UseVisualStyleBackColor = false;
            editarProjetos.Click += editarProjetos_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 34, 117);
            ClientSize = new Size(1143, 750);
            Controls.Add(editarProjetos);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Controls.Add(TelaIncial);
            Controls.Add(cadastrar);
            Controls.Add(nomeProjeto);
            Controls.Add(resumo);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(status);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(nomeGerente);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox nomeGerente;
        private Label label4;
        private Label label7;
        private Label label5;
        private TextBox status;
        private Label label8;
        private Label label6;
        private TextBox resumo;
        private TextBox nomeProjeto;
        private Button cadastrar;
        private Button TelaIncial;
        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private Button editarProjetos;
    }
}