using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_Prioridade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Prioridade));
            this.dgvPrioridade = new System.Windows.Forms.DataGridView();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtPrioridade = new System.Windows.Forms.TextBox();
            this.ordemservicoDataSet1 = new OS_CodeFirst.BD.ordemservicoDataSet1();
            this.prioridadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prioridadeTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSet1TableAdapters.prioridadeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrioridade
            // 
            this.dgvPrioridade.AllowUserToDeleteRows = false;
            this.dgvPrioridade.AutoGenerateColumns = false;
            this.dgvPrioridade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrioridade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nivelDataGridViewTextBoxColumn});
            this.dgvPrioridade.DataSource = this.prioridadeBindingSource;
            this.dgvPrioridade.Location = new System.Drawing.Point(12, 93);
            this.dgvPrioridade.Name = "dgvPrioridade";
            this.dgvPrioridade.Size = new System.Drawing.Size(641, 209);
            this.dgvPrioridade.TabIndex = 0;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(48, 35);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(57, 13);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Prioridade:";
            // 
            // txtPrioridade
            // 
            this.txtPrioridade.Location = new System.Drawing.Point(111, 32);
            this.txtPrioridade.Name = "txtPrioridade";
            this.txtPrioridade.Size = new System.Drawing.Size(505, 20);
            this.txtPrioridade.TabIndex = 2;
            this.txtPrioridade.TextChanged += new System.EventHandler(this.txtPrioridade_TextChanged);
            // 
            // ordemservicoDataSet1
            // 
            this.ordemservicoDataSet1.DataSetName = "ordemservicoDataSet1";
            this.ordemservicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prioridadeBindingSource
            // 
            this.prioridadeBindingSource.DataMember = "prioridade";
            this.prioridadeBindingSource.DataSource = this.ordemservicoDataSet1;
            // 
            // prioridadeTableAdapter
            // 
            this.prioridadeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            // 
            // Consulta_Prioridade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
            this.Controls.Add(this.txtPrioridade);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.dgvPrioridade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_Prioridade";
            this.Text = "Consulta/Alteração da Prioridade";
            this.Load += new System.EventHandler(this.Consulta_Prioridade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrioridade;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtPrioridade;
        private ordemservicoDataSet1 ordemservicoDataSet1;
        private System.Windows.Forms.BindingSource prioridadeBindingSource;
        private BD.ordemservicoDataSet1TableAdapters.prioridadeTableAdapter prioridadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
    }
}