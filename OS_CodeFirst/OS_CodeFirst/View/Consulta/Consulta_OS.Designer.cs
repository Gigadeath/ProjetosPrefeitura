namespace OS_CodeFirst.View
{
    partial class Consulta_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_OS));
            this.lblOS = new System.Windows.Forms.Label();
            this.lblDataemis = new System.Windows.Forms.Label();
            this.mtxtDataEmis = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPrevista = new System.Windows.Forms.MaskedTextBox();
            this.lblDataPrev = new System.Windows.Forms.Label();
            this.mtxtEntregue = new System.Windows.Forms.MaskedTextBox();
            this.lblEntregue = new System.Windows.Forms.Label();
            this.statusOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrevistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntregueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSistema = new System.Windows.Forms.Label();
            this.cmbSistema = new System.Windows.Forms.ComboBox();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtOS = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusOSTableAdapter
            // 
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(29, 19);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(25, 13);
            this.lblOS.TabIndex = 2;
            this.lblOS.Text = "OS:";
            // 
            // lblDataemis
            // 
            this.lblDataemis.AutoSize = true;
            this.lblDataemis.Location = new System.Drawing.Point(237, 19);
            this.lblDataemis.Name = "lblDataemis";
            this.lblDataemis.Size = new System.Drawing.Size(75, 13);
            this.lblDataemis.TabIndex = 4;
            this.lblDataemis.Text = "Data Emissao:";
            // 
            // mtxtDataEmis
            // 
            this.mtxtDataEmis.Location = new System.Drawing.Point(318, 16);
            this.mtxtDataEmis.Mask = "00/00/0000";
            this.mtxtDataEmis.Name = "mtxtDataEmis";
            this.mtxtDataEmis.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataEmis.TabIndex = 5;
            this.mtxtDataEmis.TextChanged += new System.EventHandler(this.mtxtDataEmis_TextChanged);
            // 
            // mtxtPrevista
            // 
            this.mtxtPrevista.Location = new System.Drawing.Point(540, 16);
            this.mtxtPrevista.Mask = "00/00/0000";
            this.mtxtPrevista.Name = "mtxtPrevista";
            this.mtxtPrevista.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrevista.TabIndex = 7;
            this.mtxtPrevista.TextChanged += new System.EventHandler(this.mtxtPrevista_TextChanged);
            // 
            // lblDataPrev
            // 
            this.lblDataPrev.AutoSize = true;
            this.lblDataPrev.Location = new System.Drawing.Point(459, 19);
            this.lblDataPrev.Name = "lblDataPrev";
            this.lblDataPrev.Size = new System.Drawing.Size(74, 13);
            this.lblDataPrev.TabIndex = 6;
            this.lblDataPrev.Text = "Data Prevista:";
            // 
            // mtxtEntregue
            // 
            this.mtxtEntregue.Location = new System.Drawing.Point(318, 59);
            this.mtxtEntregue.Mask = "00/00/0000";
            this.mtxtEntregue.Name = "mtxtEntregue";
            this.mtxtEntregue.Size = new System.Drawing.Size(100, 20);
            this.mtxtEntregue.TabIndex = 9;
            this.mtxtEntregue.TextChanged += new System.EventHandler(this.mtxtEntregue_TextChanged);
            // 
            // lblEntregue
            // 
            this.lblEntregue.AutoSize = true;
            this.lblEntregue.Location = new System.Drawing.Point(237, 62);
            this.lblEntregue.Name = "lblEntregue";
            this.lblEntregue.Size = new System.Drawing.Size(79, 13);
            this.lblEntregue.TabIndex = 8;
            this.lblEntregue.Text = "Data Entregue:";
            // 
            // statusOSSet
            // 
            // 
            // statusOSBindingSource
            // 
            // 
            // statusSet
            // 
            // 
            // statusBindingSource
            // 
            // 
            // statusTableAdapter
            // 
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OS_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "OS_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Status_Id";
            this.dataGridViewTextBoxColumn2.DataSource = this.statusBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Status_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AutoGenerateColumns = false;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sistemaIdDataGridViewTextBoxColumn,
            this.oSNDataGridViewTextBoxColumn,
            this.dataPrevistaDataGridViewTextBoxColumn,
            this.dataEntregueDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.solicitacaoDataGridViewTextBoxColumn});
            this.dgvOS.DataSource = this.osBindingSource;
            this.dgvOS.Location = new System.Drawing.Point(12, 110);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.Size = new System.Drawing.Size(641, 192);
            this.dgvOS.TabIndex = 11;
            this.dgvOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellContentClick);
            this.dgvOS.DoubleClick += new System.EventHandler(this.dgvOS_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // sistemaIdDataGridViewTextBoxColumn
            // 
            this.sistemaIdDataGridViewTextBoxColumn.DataPropertyName = "Sistema_Id";
            this.sistemaIdDataGridViewTextBoxColumn.HeaderText = "Sistema_Id";
            this.sistemaIdDataGridViewTextBoxColumn.Name = "sistemaIdDataGridViewTextBoxColumn";
            this.sistemaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sistemaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // oSNDataGridViewTextBoxColumn
            // 
            this.oSNDataGridViewTextBoxColumn.DataPropertyName = "OSN";
            this.oSNDataGridViewTextBoxColumn.HeaderText = "OSN";
            this.oSNDataGridViewTextBoxColumn.Name = "oSNDataGridViewTextBoxColumn";
            this.oSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPrevistaDataGridViewTextBoxColumn
            // 
            this.dataPrevistaDataGridViewTextBoxColumn.DataPropertyName = "DataPrevista";
            this.dataPrevistaDataGridViewTextBoxColumn.HeaderText = "DataPrevista";
            this.dataPrevistaDataGridViewTextBoxColumn.Name = "dataPrevistaDataGridViewTextBoxColumn";
            this.dataPrevistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntregueDataGridViewTextBoxColumn
            // 
            this.dataEntregueDataGridViewTextBoxColumn.DataPropertyName = "DataEntregue";
            this.dataEntregueDataGridViewTextBoxColumn.HeaderText = "DataEntregue";
            this.dataEntregueDataGridViewTextBoxColumn.Name = "dataEntregueDataGridViewTextBoxColumn";
            this.dataEntregueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitacaoDataGridViewTextBoxColumn
            // 
            this.solicitacaoDataGridViewTextBoxColumn.DataPropertyName = "Solicitacao";
            this.solicitacaoDataGridViewTextBoxColumn.HeaderText = "Solicitacao";
            this.solicitacaoDataGridViewTextBoxColumn.Name = "solicitacaoDataGridViewTextBoxColumn";
            this.solicitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osBindingSource
            // 
            // 
            // oSSet
            // 
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(7, 62);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(47, 13);
            this.lblSistema.TabIndex = 12;
            this.lblSistema.Text = "Sistema:";
            // 
            // cmbSistema
            // 
            this.cmbSistema.DataSource = this.sistemaBindingSource;
            this.cmbSistema.DisplayMember = "Nome";
            this.cmbSistema.FormattingEnabled = true;
            this.cmbSistema.Location = new System.Drawing.Point(60, 54);
            this.cmbSistema.Name = "cmbSistema";
            this.cmbSistema.Size = new System.Drawing.Size(100, 21);
            this.cmbSistema.TabIndex = 13;
            this.cmbSistema.ValueMember = "Id";
            this.cmbSistema.TextChanged += new System.EventHandler(this.cmbSistema_TextChanged);
            // 
            // sistemaBindingSource
            // 
            this.sistemaBindingSource.DataMember = "sistema";
            this.sistemaBindingSource.DataSource = this.sistemaSetBindingSource;
            // 
            // sistemaSetBindingSource
            // 
            // 
            // sistemaSet
            // 
            // 
            // sistemaTableAdapter
            // 
            // mtxtOS
            // 
            this.mtxtOS.Location = new System.Drawing.Point(60, 12);
            this.mtxtOS.Mask = "000-0000/0000";
            this.mtxtOS.Name = "mtxtOS";
            this.mtxtOS.Size = new System.Drawing.Size(100, 20);
            this.mtxtOS.TabIndex = 14;
            this.mtxtOS.TextChanged += new System.EventHandler(this.mtxtOS_TextChanged);
            // 
            // osTableAdapter
            // 
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(554, 81);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Consulta_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.mtxtOS);
            this.Controls.Add(this.cmbSistema);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.dgvOS);
            this.Controls.Add(this.mtxtEntregue);
            this.Controls.Add(this.lblEntregue);
            this.Controls.Add(this.mtxtPrevista);
            this.Controls.Add(this.lblDataPrev);
            this.Controls.Add(this.mtxtDataEmis);
            this.Controls.Add(this.lblDataemis);
            this.Controls.Add(this.lblOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_OS";
            this.Text = "Consulta/Alteração da OS";
            this.Load += new System.EventHandler(this.Consulta_StatusOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn oSIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblDataemis;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmis;
        private System.Windows.Forms.MaskedTextBox mtxtPrevista;
        private System.Windows.Forms.Label lblDataPrev;
        private System.Windows.Forms.MaskedTextBox mtxtEntregue;
        private System.Windows.Forms.Label lblEntregue;
        private System.Windows.Forms.BindingSource statusOSBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.ComboBox cmbSistema;
        private System.Windows.Forms.BindingSource sistemaSetBindingSource;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private System.Windows.Forms.MaskedTextBox mtxtOS;
        private System.Windows.Forms.BindingSource osBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sistemaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizar;
    }
}