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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSistema = new System.Windows.Forms.Label();
            this.txtSistema = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSistema
            // 
            this.dgvSistema.AllowUserToDeleteRows = false;
            this.dgvSistema.AutoGenerateColumns = false;
            this.dgvSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.Numero_OS});
            this.dgvSistema.DataSource = this.sistemaBindingSource;
            this.dgvSistema.Location = new System.Drawing.Point(12, 101);
            this.dgvSistema.Name = "dgvSistema";
            this.dgvSistema.Size = new System.Drawing.Size(641, 201);
            this.dgvSistema.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // Numero_OS
            // 
            this.Numero_OS.DataPropertyName = "Numero_OS";
            this.Numero_OS.HeaderText = "Numero_OS";
            this.Numero_OS.Name = "Numero_OS";
            // 
            // sistemaBindingSource
            // 
            // 
            // sistemaSet
            // 
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(41, 40);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(47, 13);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Sistema:";
            // 
            // txtSistema
            // 
            this.txtSistema.Location = new System.Drawing.Point(110, 37);
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.Size = new System.Drawing.Size(496, 20);
            this.txtSistema.TabIndex = 2;
            this.txtSistema.TextChanged += new System.EventHandler(this.txtSistema_TextChanged);
            // 
            // sistemaTableAdapter
            // 
            // 
            // Consulta_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
            this.Controls.Add(this.txtSistema);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.dgvSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_Sistema";
            this.Text = "Consulta/Alteração Sistema";
            this.Load += new System.EventHandler(this.Consulta_Sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSistema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_OS;
    }
}