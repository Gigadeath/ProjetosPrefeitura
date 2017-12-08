using OS_CodeFirst.BD;

namespace OS_CodeFirst.View
{
    partial class Geracao_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geracao_OS));
            this.lblOS = new System.Windows.Forms.Label();
            this.cmbOS = new System.Windows.Forms.ComboBox();
            this.oSSet = new OS_CodeFirst.BD.OSSet();
            this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osTableAdapter = new OS_CodeFirst.BD.OSSetTableAdapters.osTableAdapter();
            this.btn_Gerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oSSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(184, 59);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(80, 13);
            this.lblOS.TabIndex = 0;
            this.lblOS.Text = "Numero da OS:";
            // 
            // cmbOS
            // 
            this.cmbOS.DataSource = this.osBindingSource;
            this.cmbOS.DisplayMember = "OSN";
            this.cmbOS.FormattingEnabled = true;
            this.cmbOS.Location = new System.Drawing.Point(291, 56);
            this.cmbOS.Name = "cmbOS";
            this.cmbOS.Size = new System.Drawing.Size(121, 21);
            this.cmbOS.TabIndex = 1;
            this.cmbOS.ValueMember = "Id";
            // 
            // oSSet
            // 
            this.oSSet.DataSetName = "OSSet";
            this.oSSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osBindingSource
            // 
            this.osBindingSource.DataMember = "os";
            this.osBindingSource.DataSource = this.oSSet;
            // 
            // osTableAdapter
            // 
            this.osTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Location = new System.Drawing.Point(110, 170);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(457, 110);
            this.btn_Gerar.TabIndex = 2;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // Geracao_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
            this.Controls.Add(this.btn_Gerar);
            this.Controls.Add(this.cmbOS);
            this.Controls.Add(this.lblOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Geracao_OS";
            this.Text = "Geracao_OS";
            this.Load += new System.EventHandler(this.Geracao_OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oSSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.ComboBox cmbOS;
        private OSSet oSSet;
        private System.Windows.Forms.BindingSource osBindingSource;
        private BD.OSSetTableAdapters.osTableAdapter osTableAdapter;
        private System.Windows.Forms.Button btn_Gerar;
    }
}