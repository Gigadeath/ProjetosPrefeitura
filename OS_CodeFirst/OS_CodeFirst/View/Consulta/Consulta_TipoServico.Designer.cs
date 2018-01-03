using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_TipoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_TipoServico));
            this.dgvTipoServ = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposervicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoServicoDataSet = new OS_CodeFirst.BD.TipoServicoDataSet();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.tiposervicoTableAdapter = new OS_CodeFirst.BD.TipoServicoDataSetTableAdapters.tiposervicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposervicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoServ
            // 
            this.dgvTipoServ.AllowUserToDeleteRows = false;
            this.dgvTipoServ.AutoGenerateColumns = false;
            this.dgvTipoServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTipoServ.DataSource = this.tiposervicoBindingSource;
            this.dgvTipoServ.Location = new System.Drawing.Point(18, 146);
            this.dgvTipoServ.Name = "dgvTipoServ";
            this.dgvTipoServ.Size = new System.Drawing.Size(641, 194);
            this.dgvTipoServ.TabIndex = 0;
            this.dgvTipoServ.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoServ_CellDoubleClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tiposervicoBindingSource
            // 
            this.tiposervicoBindingSource.DataMember = "tiposervico";
            this.tiposervicoBindingSource.DataSource = this.tipoServicoDataSet;
            // 
            // tipoServicoDataSet
            // 
            this.tipoServicoDataSet.DataSetName = "TipoServicoDataSet";
            this.tipoServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Location = new System.Drawing.Point(37, 82);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(85, 13);
            this.lblTipoServico.TabIndex = 1;
            this.lblTipoServico.Text = "Tipo de Serviço:";
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(128, 79);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(503, 20);
            this.txtTipoServico.TabIndex = 2;
            this.txtTipoServico.TextChanged += new System.EventHandler(this.txtTipoServico_TextChanged);
            // 
            // tiposervicoTableAdapter
            // 
            this.tiposervicoTableAdapter.ClearBeforeFill = true;
            // 
            // Consulta_TipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 359);
            this.Controls.Add(this.txtTipoServico);
            this.Controls.Add(this.lblTipoServico);
            this.Controls.Add(this.dgvTipoServ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consulta_TipoServico";
            this.Sizable = false;
            this.Text = "Consulta/Alteração do Tipo de Serviço";
            this.Load += new System.EventHandler(this.Consulta_TipoServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposervicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoServ;
#pragma warning disable CS0169 // O campo "Consulta_TipoServico.idDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_TipoServico.idDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_TipoServico.nomeDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_TipoServico.nomeDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.TextBox txtTipoServico;
        private TipoServicoDataSet tipoServicoDataSet;
        private System.Windows.Forms.BindingSource tiposervicoBindingSource;
        private BD.TipoServicoDataSetTableAdapters.tiposervicoTableAdapter tiposervicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}