using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_StatusOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_StatusOS));
            this.dgvStatusOS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemservicoDataSet4 = new OS_CodeFirst.BD.ordemservicoDataSet4();
            this.mtxtDataEmis = new System.Windows.Forms.MaskedTextBox();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.lblPrevista = new System.Windows.Forms.Label();
            this.mtxtPrevista = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEntregue = new System.Windows.Forms.MaskedTextBox();
            this.lblEntregue = new System.Windows.Forms.Label();
            this.mtxtOS = new System.Windows.Forms.MaskedTextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.statusosTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSet4TableAdapters.statusosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatusOS
            // 
            this.dgvStatusOS.AllowUserToAddRows = false;
            this.dgvStatusOS.AllowUserToDeleteRows = false;
            this.dgvStatusOS.AutoGenerateColumns = false;
            this.dgvStatusOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.oSIdDataGridViewTextBoxColumn,
            this.statusIdDataGridViewTextBoxColumn,
            this.OSN,
            this.dataAlteracaoDataGridViewTextBoxColumn,
            this.DataEmissao,
            this.DataPrevista,
            this.DataEntregue,
            this.Status});
            this.dgvStatusOS.DataSource = this.statusosBindingSource;
            this.dgvStatusOS.Location = new System.Drawing.Point(14, 169);
            this.dgvStatusOS.Name = "dgvStatusOS";
            this.dgvStatusOS.ReadOnly = true;
            this.dgvStatusOS.Size = new System.Drawing.Size(641, 188);
            this.dgvStatusOS.TabIndex = 0;
            this.dgvStatusOS.DoubleClick += new System.EventHandler(this.dgvStatusOS_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // oSIdDataGridViewTextBoxColumn
            // 
            this.oSIdDataGridViewTextBoxColumn.DataPropertyName = "OS_Id";
            this.oSIdDataGridViewTextBoxColumn.HeaderText = "OS_Id";
            this.oSIdDataGridViewTextBoxColumn.Name = "oSIdDataGridViewTextBoxColumn";
            this.oSIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            this.statusIdDataGridViewTextBoxColumn.DataPropertyName = "Status_Id";
            this.statusIdDataGridViewTextBoxColumn.HeaderText = "Status_Id";
            this.statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            this.statusIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // OSN
            // 
            this.OSN.DataPropertyName = "OSN";
            this.OSN.HeaderText = "OSN";
            this.OSN.Name = "OSN";
            this.OSN.ReadOnly = true;
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "dataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            this.dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataEmissao
            // 
            this.DataEmissao.DataPropertyName = "DataEmissao";
            this.DataEmissao.HeaderText = "DataEmissao";
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            // 
            // DataPrevista
            // 
            this.DataPrevista.DataPropertyName = "DataPrevista";
            this.DataPrevista.HeaderText = "DataPrevista";
            this.DataPrevista.Name = "DataPrevista";
            this.DataPrevista.ReadOnly = true;
            // 
            // DataEntregue
            // 
            this.DataEntregue.DataPropertyName = "DataEntregue";
            this.DataEntregue.HeaderText = "DataEntregue";
            this.DataEntregue.Name = "DataEntregue";
            this.DataEntregue.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // statusosBindingSource
            // 
            this.statusosBindingSource.DataMember = "statusos";
            this.statusosBindingSource.DataSource = this.ordemservicoDataSet4;
            // 
            // ordemservicoDataSet4
            // 
            this.ordemservicoDataSet4.DataSetName = "ordemservicoDataSet4";
            this.ordemservicoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtxtDataEmis
            // 
            this.mtxtDataEmis.Location = new System.Drawing.Point(110, 85);
            this.mtxtDataEmis.Mask = "00/00/0000";
            this.mtxtDataEmis.Name = "mtxtDataEmis";
            this.mtxtDataEmis.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataEmis.TabIndex = 1;
            this.mtxtDataEmis.TextChanged += new System.EventHandler(this.mtxtEmissao_TextChanged);
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(14, 88);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(90, 13);
            this.lblEmissao.TabIndex = 2;
            this.lblEmissao.Text = "Data de Emissão:";
            // 
            // lblPrevista
            // 
            this.lblPrevista.AutoSize = true;
            this.lblPrevista.Location = new System.Drawing.Point(241, 88);
            this.lblPrevista.Name = "lblPrevista";
            this.lblPrevista.Size = new System.Drawing.Size(74, 13);
            this.lblPrevista.TabIndex = 3;
            this.lblPrevista.Text = "Data Prevista:";
            // 
            // mtxtPrevista
            // 
            this.mtxtPrevista.Location = new System.Drawing.Point(321, 85);
            this.mtxtPrevista.Mask = "00/00/0000";
            this.mtxtPrevista.Name = "mtxtPrevista";
            this.mtxtPrevista.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrevista.TabIndex = 4;
            this.mtxtPrevista.ValidatingType = typeof(System.DateTime);
            this.mtxtPrevista.TextChanged += new System.EventHandler(this.mtxtPrevista_TextChanged);
            // 
            // mtxtEntregue
            // 
            this.mtxtEntregue.Location = new System.Drawing.Point(539, 85);
            this.mtxtEntregue.Mask = "00/00/0000";
            this.mtxtEntregue.Name = "mtxtEntregue";
            this.mtxtEntregue.Size = new System.Drawing.Size(103, 20);
            this.mtxtEntregue.TabIndex = 6;
            this.mtxtEntregue.ValidatingType = typeof(System.DateTime);
            this.mtxtEntregue.TextChanged += new System.EventHandler(this.mtxtEntregue_TextChanged);
            // 
            // lblEntregue
            // 
            this.lblEntregue.AutoSize = true;
            this.lblEntregue.Location = new System.Drawing.Point(457, 88);
            this.lblEntregue.Name = "lblEntregue";
            this.lblEntregue.Size = new System.Drawing.Size(79, 13);
            this.lblEntregue.TabIndex = 5;
            this.lblEntregue.Text = "Data Entregue:";
            // 
            // mtxtOS
            // 
            this.mtxtOS.Location = new System.Drawing.Point(321, 126);
            this.mtxtOS.Mask = "000-0000/0000";
            this.mtxtOS.Name = "mtxtOS";
            this.mtxtOS.Size = new System.Drawing.Size(100, 20);
            this.mtxtOS.TabIndex = 7;
            this.mtxtOS.TextChanged += new System.EventHandler(this.mtxtOS_TextChanged);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(261, 129);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(25, 13);
            this.lblOS.TabIndex = 8;
            this.lblOS.Text = "OS:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(550, 85);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // statusosTableAdapter
            // 
            this.statusosTableAdapter.ClearBeforeFill = true;
            // 
            // Consulta_StatusOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 385);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.mtxtOS);
            this.Controls.Add(this.mtxtEntregue);
            this.Controls.Add(this.lblEntregue);
            this.Controls.Add(this.mtxtPrevista);
            this.Controls.Add(this.lblPrevista);
            this.Controls.Add(this.lblEmissao);
            this.Controls.Add(this.mtxtDataEmis);
            this.Controls.Add(this.dgvStatusOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_StatusOS";
            this.Text = "Consulta / alteração do Status da Ordem de Serviço";
            this.Load += new System.EventHandler(this.Consulta_StatusOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatusOS;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmis;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblPrevista;
        private System.Windows.Forms.MaskedTextBox mtxtPrevista;
        private System.Windows.Forms.MaskedTextBox mtxtEntregue;
        private System.Windows.Forms.Label lblEntregue;
        private System.Windows.Forms.MaskedTextBox mtxtOS;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizar;
        private ordemservicoDataSet4 ordemservicoDataSet4;
        private System.Windows.Forms.BindingSource statusosBindingSource;
        private BD.ordemservicoDataSet4TableAdapters.statusosTableAdapter statusosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntregue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}