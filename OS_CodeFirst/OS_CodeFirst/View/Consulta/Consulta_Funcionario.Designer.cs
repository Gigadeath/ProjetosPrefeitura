using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_Funcionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Funcionario));
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemservicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemservicoDataSet = new OS_CodeFirst.BD.ordemservicoDataSet();
            this.lblRF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.mtxtRF = new System.Windows.Forms.MaskedTextBox();
            this.funcionarioTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSetTableAdapters.funcionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.AllowUserToOrderColumns = true;
            this.dgvFuncionario.AutoGenerateColumns = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Setor});
            this.dgvFuncionario.DataSource = this.funcionarioBindingSource;
            this.dgvFuncionario.Location = new System.Drawing.Point(15, 149);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(641, 217);
            this.dgvFuncionario.TabIndex = 0;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvFuncionario.DoubleClick += new System.EventHandler(this.dgvFuncionario_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RF";
            this.dataGridViewTextBoxColumn2.HeaderText = "RF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Setor
            // 
            this.Setor.DataPropertyName = "Setor";
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.ordemservicoDataSetBindingSource;
            // 
            // ordemservicoDataSetBindingSource
            // 
            this.ordemservicoDataSetBindingSource.DataSource = this.ordemservicoDataSet;
            this.ordemservicoDataSetBindingSource.Position = 0;
            this.ordemservicoDataSetBindingSource.CurrentChanged += new System.EventHandler(this.ordemservicoDataSetBindingSource_CurrentChanged);
            // 
            // ordemservicoDataSet
            // 
            this.ordemservicoDataSet.DataSetName = "ordemservicoDataSet";
            this.ordemservicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRF
            // 
            this.lblRF.AutoSize = true;
            this.lblRF.Location = new System.Drawing.Point(22, 97);
            this.lblRF.Name = "lblRF";
            this.lblRF.Size = new System.Drawing.Size(30, 13);
            this.lblRF.TabIndex = 2;
            this.lblRF.Text = "R.F.:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(300, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(248, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(525, 94);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(100, 20);
            this.txtSetor.TabIndex = 5;
            this.txtSetor.Text = "SME/CODAE/";
            this.txtSetor.TextChanged += new System.EventHandler(this.txtSetor_TextChanged);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(469, 97);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(35, 13);
            this.lblSetor.TabIndex = 6;
            this.lblSetor.Text = "Setor:";
            // 
            // mtxtRF
            // 
            this.mtxtRF.Location = new System.Drawing.Point(58, 94);
            this.mtxtRF.Mask = "000,000-0";
            this.mtxtRF.Name = "mtxtRF";
            this.mtxtRF.Size = new System.Drawing.Size(100, 20);
            this.mtxtRF.TabIndex = 7;
            this.mtxtRF.TextChanged += new System.EventHandler(this.mtxtRF_TextChanged);
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // Consulta_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 384);
            this.Controls.Add(this.mtxtRF);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblRF);
            this.Controls.Add(this.dgvFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consulta_Funcionario";
            this.Sizable = false;
            this.Text = "Consulta/Alteração de Funcionarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Label lblRF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.MaskedTextBox mtxtRF;
#pragma warning disable CS0169 // O campo "Consulta_Funcionario.idDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_Funcionario.idDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_Funcionario.rFDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn rFDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_Funcionario.rFDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_Funcionario.nomeDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_Funcionario.nomeDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_Funcionario.setorDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_Funcionario.setorDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.BindingSource ordemservicoDataSetBindingSource;
        private ordemservicoDataSet ordemservicoDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BD.ordemservicoDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
#pragma warning disable CS0169 // O campo "Consulta_Funcionario.dataGridViewTextBoxColumn4" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
#pragma warning restore CS0169 // O campo "Consulta_Funcionario.dataGridViewTextBoxColumn4" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
    }
}