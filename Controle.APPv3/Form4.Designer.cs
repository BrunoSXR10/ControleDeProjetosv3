namespace Controle.APPv3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            excluirProjetoBotao = new Button();
            nomeProjeto = new Label();
            nomeProjetoTextBox = new TextBox();
            telaInicial = new Button();
            editarProjetoBox = new GroupBox();
            editarProjetoButao = new Button();
            resumo = new TextBox();
            label6 = new Label();
            status = new TextBox();
            label5 = new Label();
            label8 = new Label();
            dataFim = new DateTimePicker();
            dataInicio = new DateTimePicker();
            label7 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            nomeGerente = new TextBox();
            label1 = new Label();
            editarProjetoBox.SuspendLayout();
            SuspendLayout();
            // 
            // excluirProjetoBotao
            // 
            excluirProjetoBotao.BackColor = Color.Red;
            excluirProjetoBotao.FlatAppearance.BorderSize = 0;
            excluirProjetoBotao.FlatStyle = FlatStyle.Flat;
            excluirProjetoBotao.Location = new Point(578, 47);
            excluirProjetoBotao.Margin = new Padding(4, 5, 4, 5);
            excluirProjetoBotao.Name = "excluirProjetoBotao";
            excluirProjetoBotao.Size = new Size(204, 64);
            excluirProjetoBotao.TabIndex = 31;
            excluirProjetoBotao.Text = "Excluir Projeto";
            excluirProjetoBotao.UseVisualStyleBackColor = false;
            excluirProjetoBotao.Click += excluirProjetoBotao_Click;
            // 
            // nomeProjeto
            // 
            nomeProjeto.AutoSize = true;
            nomeProjeto.Location = new Point(45, 41);
            nomeProjeto.Margin = new Padding(4, 0, 4, 0);
            nomeProjeto.Name = "nomeProjeto";
            nomeProjeto.Size = new Size(152, 25);
            nomeProjeto.TabIndex = 32;
            nomeProjeto.Text = "Nome Do Projeto";
            // 
            // nomeProjetoTextBox
            // 
            nomeProjetoTextBox.Location = new Point(45, 80);
            nomeProjetoTextBox.Margin = new Padding(4, 5, 4, 5);
            nomeProjetoTextBox.MaxLength = 100;
            nomeProjetoTextBox.Name = "nomeProjetoTextBox";
            nomeProjetoTextBox.Size = new Size(280, 31);
            nomeProjetoTextBox.TabIndex = 33;
            // 
            // telaInicial
            // 
            telaInicial.BackColor = Color.RoyalBlue;
            telaInicial.FlatAppearance.BorderSize = 0;
            telaInicial.FlatStyle = FlatStyle.Flat;
            telaInicial.Location = new Point(847, 47);
            telaInicial.Margin = new Padding(4, 5, 4, 5);
            telaInicial.Name = "telaInicial";
            telaInicial.Size = new Size(183, 64);
            telaInicial.TabIndex = 34;
            telaInicial.Text = "Tela Inicial";
            telaInicial.UseVisualStyleBackColor = false;
            telaInicial.Click += telaInicial_Click;
            // 
            // editarProjetoBox
            // 
            editarProjetoBox.BackColor = Color.Silver;
            editarProjetoBox.Controls.Add(editarProjetoButao);
            editarProjetoBox.Controls.Add(resumo);
            editarProjetoBox.Controls.Add(label6);
            editarProjetoBox.Controls.Add(status);
            editarProjetoBox.Controls.Add(label5);
            editarProjetoBox.Controls.Add(label8);
            editarProjetoBox.Controls.Add(dataFim);
            editarProjetoBox.Controls.Add(dataInicio);
            editarProjetoBox.Controls.Add(label7);
            editarProjetoBox.Controls.Add(textBox1);
            editarProjetoBox.Controls.Add(label4);
            editarProjetoBox.Controls.Add(nomeGerente);
            editarProjetoBox.Controls.Add(label1);
            editarProjetoBox.Location = new Point(13, 184);
            editarProjetoBox.Margin = new Padding(4, 5, 4, 5);
            editarProjetoBox.Name = "editarProjetoBox";
            editarProjetoBox.Padding = new Padding(4, 5, 4, 5);
            editarProjetoBox.Size = new Size(1109, 482);
            editarProjetoBox.TabIndex = 35;
            editarProjetoBox.TabStop = false;
            editarProjetoBox.Text = "Editar Projeto";
            // 
            // editarProjetoButao
            // 
            editarProjetoButao.BackColor = Color.SeaGreen;
            editarProjetoButao.FlatAppearance.BorderSize = 0;
            editarProjetoButao.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            editarProjetoButao.FlatStyle = FlatStyle.Flat;
            editarProjetoButao.Location = new Point(834, 375);
            editarProjetoButao.Margin = new Padding(4, 5, 4, 5);
            editarProjetoButao.Name = "editarProjetoButao";
            editarProjetoButao.Size = new Size(222, 60);
            editarProjetoButao.TabIndex = 47;
            editarProjetoButao.Text = "Editar Projeto";
            editarProjetoButao.UseVisualStyleBackColor = false;
            editarProjetoButao.Click += editarProjetoButao_Click;
            // 
            // resumo
            // 
            resumo.Location = new Point(43, 293);
            resumo.Margin = new Padding(4, 5, 4, 5);
            resumo.MaxLength = 500;
            resumo.Multiline = true;
            resumo.Name = "resumo";
            resumo.Size = new Size(303, 159);
            resumo.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 263);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 45;
            label6.Text = "Resumo";
            // 
            // status
            // 
            status.Location = new Point(431, 293);
            status.Margin = new Padding(4, 5, 4, 5);
            status.MaxLength = 20;
            status.Name = "status";
            status.Size = new Size(184, 31);
            status.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 263);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 43;
            label5.Text = "Status do projeto";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(431, 143);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 42;
            label8.Text = "Data Final";
            // 
            // dataFim
            // 
            dataFim.Location = new Point(431, 186);
            dataFim.Margin = new Padding(4, 5, 4, 5);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(284, 31);
            dataFim.TabIndex = 41;
            // 
            // dataInicio
            // 
            dataInicio.Location = new Point(32, 186);
            dataInicio.Margin = new Padding(4, 5, 4, 5);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(284, 31);
            dataInicio.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 143);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 39;
            label7.Text = "Data Inicio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 79);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 31);
            textBox1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 38;
            label4.Text = "Nome do gerente";
            // 
            // nomeGerente
            // 
            nomeGerente.Location = new Point(431, 79);
            nomeGerente.Margin = new Padding(4, 5, 4, 5);
            nomeGerente.MaxLength = 100;
            nomeGerente.Name = "nomeGerente";
            nomeGerente.Size = new Size(280, 31);
            nomeGerente.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 36;
            label1.Text = "Nome Do Projeto";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1143, 750);
            Controls.Add(editarProjetoBox);
            Controls.Add(telaInicial);
            Controls.Add(nomeProjeto);
            Controls.Add(nomeProjetoTextBox);
            Controls.Add(excluirProjetoBotao);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Projetos";
            FormClosed += Form4_FormClosed;
            Load += Form4_Load;
            editarProjetoBox.ResumeLayout(false);
            editarProjetoBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button excluirProjetoBotao;
        private Label nomeProjeto;
        private TextBox nomeProjetoTextBox;
        private Button telaInicial;
        private GroupBox editarProjetoBox;
        private Label label1;
        private TextBox nomeGerente;
        private TextBox textBox1;
        private Label label4;
        private Label label7;
        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private Label label8;
        private Label label5;
        private TextBox status;
        private Label label6;
        private TextBox resumo;
        private Button editarProjetoButao;
    }
}