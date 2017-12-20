using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Sistema));
            this.dgvSistema = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaSet = new OS_CodeFirst.BD.SistemaSet();
            this.lblSistema = new System.Windows.Forms.Label();
            this.txtSistema = new System.Windows.Forms.TextBox();
            this.sistemaTableAdapter = new OS_CodeFirst.BD.SistemaSetTableAdapters.sistemaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSistema
            // 
            this.dgvSistema.AllowUserToDeleteRows = false;
            this.dgvSistema.AutoGenerateColumns = false;
            this.dgvSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.numeroOSDataGridViewTextBoxColumn});
            this.dgvSistema.DataSource = this.sistemaBindingSource;
            this.dgvSistema.Location = new System.Drawing.Point(8, 152);
            this.dgvSistema.Name = "dgvSistema";
            this.dgvSistema.Size = new System.Drawing.Size(641, 201);
            this.dgvSistema.TabIndex = 0;
            this.dgvSistema.DoubleClick += new System.EventHandler(this.dgvSistema_DoubleClick);
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
            // numeroOSDataGridViewTextBoxColumn
            // 
            this.numeroOSDataGridViewTextBoxColumn.DataPropertyName = "Numero_OS";
            this.numeroOSDataGridViewTextBoxColumn.HeaderText = "Numero_OS";
            this.numeroOSDataGridViewTextBoxColumn.Name = "numeroOSDataGridViewTextBoxColumn";
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
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(37, 91);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(47, 13);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Sistema:";
            // 
            // txtSistema
            // 
            this.txtSistema.Location = new System.Drawing.Point(106, 88);
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.Size = new System.Drawing.Size(496, 20);
            this.txtSistema.TabIndex = 2;
            this.txtSistema.TextChanged += new System.EventHandler(this.txtSistema_TextChanged);
            // 
            // sistemaTableAdapter
            // 
            this.sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // Consulta_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 376);
            this.Controls.Add(this.txtSistema);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.dgvSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Consulta_Sistema";
            this.Sizable = false;
            this.Text = "Consulta/Alteração Sistema";
            this.Load += new System.EventHandler(this.Consulta_Sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSistema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private SistemaSet sistemaSet;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private BD.SistemaSetTableAdapters.sistemaTableAdapter sistemaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOSDataGridViewTextBoxColumn;
    }
}