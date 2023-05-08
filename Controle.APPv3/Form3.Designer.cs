namespace Controle.APPv3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            telaInicial = new Button();
            dataGridView1 = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeGerenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resumoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            projetoBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projetoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // telaInicial
            // 
            telaInicial.BackColor = Color.RoyalBlue;
            telaInicial.Location = new Point(939, 20);
            telaInicial.Margin = new Padding(4, 5, 4, 5);
            telaInicial.Name = "telaInicial";
            telaInicial.Size = new Size(187, 63);
            telaInicial.TabIndex = 0;
            telaInicial.Text = "Tela Inicial";
            telaInicial.UseVisualStyleBackColor = false;
            telaInicial.Click += telaInicial_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, nomeGerenteDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, resumoDataGridViewTextBoxColumn, dataIDataGridViewTextBoxColumn, dataFDataGridViewTextBoxColumn });
            dataGridView1.DataSource = projetoBindingSource;
            dataGridView1.Location = new Point(49, 106);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(923, 440);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeGerenteDataGridViewTextBoxColumn
            // 
            nomeGerenteDataGridViewTextBoxColumn.DataPropertyName = "NomeGerente";
            nomeGerenteDataGridViewTextBoxColumn.HeaderText = "NomeGerente";
            nomeGerenteDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomeGerenteDataGridViewTextBoxColumn.Name = "nomeGerenteDataGridViewTextBoxColumn";
            nomeGerenteDataGridViewTextBoxColumn.ReadOnly = true;
            nomeGerenteDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // resumoDataGridViewTextBoxColumn
            // 
            resumoDataGridViewTextBoxColumn.DataPropertyName = "Resumo";
            resumoDataGridViewTextBoxColumn.HeaderText = "Resumo";
            resumoDataGridViewTextBoxColumn.MinimumWidth = 8;
            resumoDataGridViewTextBoxColumn.Name = "resumoDataGridViewTextBoxColumn";
            resumoDataGridViewTextBoxColumn.ReadOnly = true;
            resumoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataIDataGridViewTextBoxColumn
            // 
            dataIDataGridViewTextBoxColumn.DataPropertyName = "DataI";
            dataIDataGridViewTextBoxColumn.HeaderText = "DataI";
            dataIDataGridViewTextBoxColumn.MinimumWidth = 8;
            dataIDataGridViewTextBoxColumn.Name = "dataIDataGridViewTextBoxColumn";
            dataIDataGridViewTextBoxColumn.ReadOnly = true;
            dataIDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataFDataGridViewTextBoxColumn
            // 
            dataFDataGridViewTextBoxColumn.DataPropertyName = "DataF";
            dataFDataGridViewTextBoxColumn.HeaderText = "DataF";
            dataFDataGridViewTextBoxColumn.MinimumWidth = 8;
            dataFDataGridViewTextBoxColumn.Name = "dataFDataGridViewTextBoxColumn";
            dataFDataGridViewTextBoxColumn.ReadOnly = true;
            dataFDataGridViewTextBoxColumn.Width = 150;
            // 
            // projetoBindingSource
            // 
            projetoBindingSource.DataSource = typeof(MODEL.Projeto);
            // 
            // button1
            // 
            button1.Location = new Point(463, 613);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(187, 63);
            button1.TabIndex = 2;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 34, 117);
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(telaInicial);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem De Projetos";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)projetoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button telaInicial;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeGerenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resumoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataFDataGridViewTextBoxColumn;
        private BindingSource projetoBindingSource;
        private Button button1;
    }
}