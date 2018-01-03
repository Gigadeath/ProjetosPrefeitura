using OS_CodeFirst.BD;

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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sistema_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSSet = new OS_CodeFirst.BD.OSSet();
            this.lblSistema = new System.Windows.Forms.Label();
            this.cmbSistema = new System.Windows.Forms.ComboBox();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaSet = new OS_CodeFirst.BD.SistemaSet();
            this.mtxtOS = new System.Windows.Forms.MaskedTextBox();
            this.sistemaTableAdapter = new OS_CodeFirst.BD.SistemaSetTableAdapters.sistemaTableAdapter();
            this.osTableAdapter = new OS_CodeFirst.BD.OSSetTableAdapters.osTableAdapter();
            this.btnGerar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(24, 79);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(25, 13);
            this.lblOS.TabIndex = 2;
            this.lblOS.Text = "OS:";
            // 
            // lblDataemis
            // 
            this.lblDataemis.AutoSize = true;
            this.lblDataemis.Location = new System.Drawing.Point(232, 79);
            this.lblDataemis.Name = "lblDataemis";
            this.lblDataemis.Size = new System.Drawing.Size(75, 13);
            this.lblDataemis.TabIndex = 4;
            this.lblDataemis.Text = "Data Emissao:";
            // 
            // mtxtDataEmis
            // 
            this.mtxtDataEmis.Location = new System.Drawing.Point(313, 76);
            this.mtxtDataEmis.Mask = "00/00/0000";
            this.mtxtDataEmis.Name = "mtxtDataEmis";
            this.mtxtDataEmis.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataEmis.TabIndex = 5;
            this.mtxtDataEmis.TextChanged += new System.EventHandler(this.mtxtDataEmis_TextChanged);
            // 
            // mtxtPrevista
            // 
            this.mtxtPrevista.Location = new System.Drawing.Point(535, 76);
            this.mtxtPrevista.Mask = "00/00/0000";
            this.mtxtPrevista.Name = "mtxtPrevista";
            this.mtxtPrevista.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrevista.TabIndex = 7;
            this.mtxtPrevista.TextChanged += new System.EventHandler(this.mtxtPrevista_TextChanged);
            // 
            // lblDataPrev
            // 
            this.lblDataPrev.AutoSize = true;
            this.lblDataPrev.Location = new System.Drawing.Point(454, 79);
            this.lblDataPrev.Name = "lblDataPrev";
            this.lblDataPrev.Size = new System.Drawing.Size(74, 13);
            this.lblDataPrev.TabIndex = 6;
            this.lblDataPrev.Text = "Data Prevista:";
            // 
            // mtxtEntregue
            // 
            this.mtxtEntregue.Location = new System.Drawing.Point(313, 119);
            this.mtxtEntregue.Mask = "00/00/0000";
            this.mtxtEntregue.Name = "mtxtEntregue";
            this.mtxtEntregue.Size = new System.Drawing.Size(100, 20);
            this.mtxtEntregue.TabIndex = 9;
            this.mtxtEntregue.TextChanged += new System.EventHandler(this.mtxtEntregue_TextChanged);
            // 
            // lblEntregue
            // 
            this.lblEntregue.AutoSize = true;
            this.lblEntregue.Location = new System.Drawing.Point(232, 122);
            this.lblEntregue.Name = "lblEntregue";
            this.lblEntregue.Size = new System.Drawing.Size(79, 13);
            this.lblEntregue.TabIndex = 8;
            this.lblEntregue.Text = "Data Entregue:";
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Status_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AutoGenerateColumns = false;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Sistema_Id,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvOS.DataSource = this.osBindingSource;
            this.dgvOS.Location = new System.Drawing.Point(7, 170);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.Size = new System.Drawing.Size(641, 192);
            this.dgvOS.TabIndex = 11;
            this.dgvOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellContentClick);
            this.dgvOS.DoubleClick += new System.EventHandler(this.dgvOS_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Sistema_Id
            // 
            this.Sistema_Id.DataPropertyName = "Sistema_Id";
            this.Sistema_Id.HeaderText = "Sistema_Id";
            this.Sistema_Id.Name = "Sistema_Id";
            this.Sistema_Id.ReadOnly = true;
            this.Sistema_Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OSN";
            this.dataGridViewTextBoxColumn3.HeaderText = "OSN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataEmissao";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataEmissao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataPrevista";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataPrevista";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataEntregue";
            this.dataGridViewTextBoxColumn6.HeaderText = "DataEntregue";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // osBindingSource
            // 
            this.osBindingSource.DataMember = "os";
            this.osBindingSource.DataSource = this.oSSet;
            // 
            // oSSet
            // 
            this.oSSet.DataSetName = "OSSet";
            this.oSSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(2, 122);
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
            this.cmbSistema.Location = new System.Drawing.Point(55, 114);
            this.cmbSistema.Name = "cmbSistema";
            this.cmbSistema.Size = new System.Drawing.Size(100, 21);
            this.cmbSistema.TabIndex = 13;
            this.cmbSistema.ValueMember = "Id";
            this.cmbSistema.TextChanged += new System.EventHandler(this.cmbSistema_TextChanged);
            // 
            // sistemaBindingSource
            // 
            this.sistemaBindingSource.DataMember = "sistema";
            this.sistemaBindingSource.DataSource = this.sistemaSet;
            // 
            // sistemaSet
            // 
            this.sistemaSet.DataSetName = "SistemaSet";
            this.sistemaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtxtOS
            // 
            this.mtxtOS.Location = new System.Drawing.Point(55, 72);
            this.mtxtOS.Mask = "000-0000/0000";
            this.mtxtOS.Name = "mtxtOS";
            this.mtxtOS.Size = new System.Drawing.Size(100, 20);
            this.mtxtOS.TabIndex = 14;
            this.mtxtOS.TextChanged += new System.EventHandler(this.mtxtOS_TextChanged);
            // 
            // sistemaTableAdapter
            // 
            this.sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // osTableAdapter
            // 
            this.osTableAdapter.ClearBeforeFill = true;
            // 
            // btnGerar
            // 
            this.btnGerar.AutoSize = true;
            this.btnGerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGerar.Depth = 0;
            this.btnGerar.Icon = null;
            this.btnGerar.Location = new System.Drawing.Point(464, 128);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Primary = false;
            this.btnGerar.Size = new System.Drawing.Size(64, 36);
            this.btnGerar.TabIndex = 17;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.Icon = null;
            this.btnAtualizar.Location = new System.Drawing.Point(554, 128);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Primary = false;
            this.btnAtualizar.Size = new System.Drawing.Size(94, 36);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Consulta_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 374);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnGerar);
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
            this.MaximizeBox = false;
            this.Name = "Consulta_OS";
            this.Sizable = false;
            this.Text = "Consulta/Alteração da OS";
            this.Load += new System.EventHandler(this.Consulta_StatusOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
#pragma warning disable CS0169 // O campo "Consulta_OS.oSIdDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn oSIdDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.oSIdDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_OS.statusIdDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.statusIdDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblDataemis;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmis;
        private System.Windows.Forms.MaskedTextBox mtxtPrevista;
        private System.Windows.Forms.Label lblDataPrev;
        private System.Windows.Forms.MaskedTextBox mtxtEntregue;
        private System.Windows.Forms.Label lblEntregue;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.ComboBox cmbSistema;
        private System.Windows.Forms.MaskedTextBox mtxtOS;
#pragma warning disable CS0169 // O campo "Consulta_OS.sistemaIdDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn sistemaIdDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.sistemaIdDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_OS.oSNDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn oSNDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.oSNDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_OS.dataPrevistaDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevistaDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.dataPrevistaDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_OS.dataEntregueDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregueDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.dataEntregueDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_OS.dataEmissaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.dataEmissaoDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_OS.solicitacaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitacaoDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_OS.solicitacaoDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn Sistema_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private SistemaSet sistemaSet;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private BD.SistemaSetTableAdapters.sistemaTableAdapter sistemaTableAdapter;
        private OSSet oSSet;
        private System.Windows.Forms.BindingSource osBindingSource;
        private BD.OSSetTableAdapters.osTableAdapter osTableAdapter;
        private MaterialSkin.Controls.MaterialFlatButton btnGerar;
        private MaterialSkin.Controls.MaterialFlatButton btnAtualizar;
    }
}