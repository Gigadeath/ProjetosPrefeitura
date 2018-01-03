using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Status));
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemservicoDataSet3 = new OS_CodeFirst.BD.ordemservicoDataSet3();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.statusTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSet3TableAdapters.statusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToDeleteRows = false;
            this.dgvStatus.AutoGenerateColumns = false;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvStatus.DataSource = this.statusBindingSource;
            this.dgvStatus.Location = new System.Drawing.Point(15, 128);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.Size = new System.Drawing.Size(613, 225);
            this.dgvStatus.TabIndex = 0;
            this.dgvStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.ordemservicoDataSet3;
            // 
            // ordemservicoDataSet3
            // 
            this.ordemservicoDataSet3.DataSetName = "ordemservicoDataSet3";
            this.ordemservicoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(96, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(172, 77);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(338, 20);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // Consulta_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 368);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consulta_Status";
            this.Sizable = false;
            this.Text = "Consulta/Alteração de Status";
            this.Load += new System.EventHandler(this.Consulta_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatus;
#pragma warning disable CS0169 // O campo "Consulta_Status.idDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_Status.idDataGridViewTextBoxColumn" nunca é usado
#pragma warning disable CS0169 // O campo "Consulta_Status.nomeDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // O campo "Consulta_Status.nomeDataGridViewTextBoxColumn" nunca é usado
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private ordemservicoDataSet3 ordemservicoDataSet3;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private BD.ordemservicoDataSet3TableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}