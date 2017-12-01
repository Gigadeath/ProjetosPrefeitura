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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrevistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntregueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtDataEmis = new System.Windows.Forms.MaskedTextBox();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.lblPrevista = new System.Windows.Forms.Label();
            this.mtxtPrevista = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEntregue = new System.Windows.Forms.MaskedTextBox();
            this.lblEntregue = new System.Windows.Forms.Label();
            this.mtxtOS = new System.Windows.Forms.MaskedTextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatusOS
            // 
            this.dgvStatusOS.AllowUserToAddRows = false;
            this.dgvStatusOS.AllowUserToDeleteRows = false;
            this.dgvStatusOS.AutoGenerateColumns = false;
            this.dgvStatusOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.OS_Id,
            this.Status_Id,
            this.oSNDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.dataPrevistaDataGridViewTextBoxColumn,
            this.dataEntregueDataGridViewTextBoxColumn});
            this.dgvStatusOS.DataSource = this.statusOSBindingSource;
            this.dgvStatusOS.Location = new System.Drawing.Point(12, 114);
            this.dgvStatusOS.Name = "dgvStatusOS";
            this.dgvStatusOS.ReadOnly = true;
            this.dgvStatusOS.Size = new System.Drawing.Size(641, 188);
            this.dgvStatusOS.TabIndex = 0;
            this.dgvStatusOS.DoubleClick += new System.EventHandler(this.dgvStatusOS_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // OS_Id
            // 
            this.OS_Id.DataPropertyName = "OS_Id";
            this.OS_Id.HeaderText = "OS_Id";
            this.OS_Id.Name = "OS_Id";
            this.OS_Id.ReadOnly = true;
            this.OS_Id.Visible = false;
            // 
            // Status_Id
            // 
            this.Status_Id.DataPropertyName = "Status_Id";
            this.Status_Id.HeaderText = "Status_Id";
            this.Status_Id.Name = "Status_Id";
            this.Status_Id.ReadOnly = true;
            this.Status_Id.Visible = false;
            // 
            // oSNDataGridViewTextBoxColumn
            // 
            this.oSNDataGridViewTextBoxColumn.DataPropertyName = "OSN";
            this.oSNDataGridViewTextBoxColumn.HeaderText = "OSN";
            this.oSNDataGridViewTextBoxColumn.Name = "oSNDataGridViewTextBoxColumn";
            this.oSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // statusOSBindingSource
            // 
            this.statusOSBindingSource.DataMember = "statusOS";
            // 
            // statusOSSet
            // 
            // 
            // mtxtDataEmis
            // 
            this.mtxtDataEmis.Location = new System.Drawing.Point(108, 30);
            this.mtxtDataEmis.Mask = "00/00/0000";
            this.mtxtDataEmis.Name = "mtxtDataEmis";
            this.mtxtDataEmis.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataEmis.TabIndex = 1;
            this.mtxtDataEmis.TextChanged += new System.EventHandler(this.mtxtEmissao_TextChanged);
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(12, 33);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(90, 13);
            this.lblEmissao.TabIndex = 2;
            this.lblEmissao.Text = "Data de Emissão:";
            // 
            // lblPrevista
            // 
            this.lblPrevista.AutoSize = true;
            this.lblPrevista.Location = new System.Drawing.Point(239, 33);
            this.lblPrevista.Name = "lblPrevista";
            this.lblPrevista.Size = new System.Drawing.Size(74, 13);
            this.lblPrevista.TabIndex = 3;
            this.lblPrevista.Text = "Data Prevista:";
            // 
            // mtxtPrevista
            // 
            this.mtxtPrevista.Location = new System.Drawing.Point(319, 30);
            this.mtxtPrevista.Mask = "00/00/0000";
            this.mtxtPrevista.Name = "mtxtPrevista";
            this.mtxtPrevista.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrevista.TabIndex = 4;
            this.mtxtPrevista.ValidatingType = typeof(System.DateTime);
            this.mtxtPrevista.TextChanged += new System.EventHandler(this.mtxtPrevista_TextChanged);
            // 
            // mtxtEntregue
            // 
            this.mtxtEntregue.Location = new System.Drawing.Point(537, 30);
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
            this.lblEntregue.Location = new System.Drawing.Point(455, 33);
            this.lblEntregue.Name = "lblEntregue";
            this.lblEntregue.Size = new System.Drawing.Size(79, 13);
            this.lblEntregue.TabIndex = 5;
            this.lblEntregue.Text = "Data Entregue:";
            // 
            // mtxtOS
            // 
            this.mtxtOS.Location = new System.Drawing.Point(319, 71);
            this.mtxtOS.Mask = "000-0000/0000";
            this.mtxtOS.Name = "mtxtOS";
            this.mtxtOS.Size = new System.Drawing.Size(100, 20);
            this.mtxtOS.TabIndex = 7;
            this.mtxtOS.TextChanged += new System.EventHandler(this.mtxtOS_TextChanged);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(259, 74);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(25, 13);
            this.lblOS.TabIndex = 8;
            this.lblOS.Text = "OS:";
            // 
            // statusOSTableAdapter
            // 
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
            // Consulta_StatusOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
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
            ((System.ComponentModel.ISupportInitialize)(this.statusOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatusOS;
        private System.Windows.Forms.BindingSource statusOSBindingSource;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmis;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblPrevista;
        private System.Windows.Forms.MaskedTextBox mtxtPrevista;
        private System.Windows.Forms.MaskedTextBox mtxtEntregue;
        private System.Windows.Forms.Label lblEntregue;
        private System.Windows.Forms.MaskedTextBox mtxtOS;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizar;
    }
}