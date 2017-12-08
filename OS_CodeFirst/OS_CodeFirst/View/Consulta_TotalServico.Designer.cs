﻿using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Consulta_TotalServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_TotalServico));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalServicoDataSet = new OS_CodeFirst.BD.TotalServicoDataSet();
            this.lblOSN = new System.Windows.Forms.Label();
            this.lblDataLimite = new System.Windows.Forms.Label();
            this.mtxtOS = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataLimite = new System.Windows.Forms.MaskedTextBox();
            this.totalservicoTableAdapter = new OS_CodeFirst.BD.TotalServicoDataSetTableAdapters.totalservicoTableAdapter();
            this.OSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalServicoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OSN,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.totalservicoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // totalservicoBindingSource
            // 
            this.totalservicoBindingSource.DataMember = "totalservico";
            this.totalservicoBindingSource.DataSource = this.totalServicoDataSet;
            // 
            // totalServicoDataSet
            // 
            this.totalServicoDataSet.DataSetName = "TotalServicoDataSet";
            this.totalServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOSN
            // 
            this.lblOSN.AutoSize = true;
            this.lblOSN.Location = new System.Drawing.Point(82, 43);
            this.lblOSN.Name = "lblOSN";
            this.lblOSN.Size = new System.Drawing.Size(25, 13);
            this.lblOSN.TabIndex = 2;
            this.lblOSN.Text = "OS:";
            // 
            // lblDataLimite
            // 
            this.lblDataLimite.AutoSize = true;
            this.lblDataLimite.Location = new System.Drawing.Point(348, 43);
            this.lblDataLimite.Name = "lblDataLimite";
            this.lblDataLimite.Size = new System.Drawing.Size(63, 13);
            this.lblDataLimite.TabIndex = 4;
            this.lblDataLimite.Text = "Data Limite:";
            // 
            // mtxtOS
            // 
            this.mtxtOS.Location = new System.Drawing.Point(113, 40);
            this.mtxtOS.Mask = "000-0000/0000";
            this.mtxtOS.Name = "mtxtOS";
            this.mtxtOS.Size = new System.Drawing.Size(92, 20);
            this.mtxtOS.TabIndex = 5;
            this.mtxtOS.TextChanged += new System.EventHandler(this.mtxtOS_TextChanged);
            // 
            // mtxtDataLimite
            // 
            this.mtxtDataLimite.Location = new System.Drawing.Point(438, 36);
            this.mtxtDataLimite.Mask = "00/00/0000";
            this.mtxtDataLimite.Name = "mtxtDataLimite";
            this.mtxtDataLimite.Size = new System.Drawing.Size(119, 20);
            this.mtxtDataLimite.TabIndex = 6;
            this.mtxtDataLimite.TextChanged += new System.EventHandler(this.mtxtDataLimite_TextChanged);
            // 
            // totalservicoTableAdapter
            // 
            this.totalservicoTableAdapter.ClearBeforeFill = true;
            // 
            // OSN
            // 
            this.OSN.DataPropertyName = "OSN";
            this.OSN.HeaderText = "OSN";
            this.OSN.Name = "OSN";
            this.OSN.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "totalHoras";
            this.dataGridViewTextBoxColumn2.HeaderText = "totalHoras";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataLimite";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataLimite";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OS_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "OS_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Consulta_TotalServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
            this.Controls.Add(this.mtxtDataLimite);
            this.Controls.Add(this.mtxtOS);
            this.Controls.Add(this.lblDataLimite);
            this.Controls.Add(this.lblOSN);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_TotalServico";
            this.Text = "Total Tipo de Serviço";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalServicoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOSN;
        private System.Windows.Forms.Label lblDataLimite;
        private System.Windows.Forms.MaskedTextBox mtxtOS;
        private System.Windows.Forms.MaskedTextBox mtxtDataLimite;
        private TotalServicoDataSet totalServicoDataSet;
        private System.Windows.Forms.BindingSource totalservicoBindingSource;
        private BD.TotalServicoDataSetTableAdapters.totalservicoTableAdapter totalservicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}