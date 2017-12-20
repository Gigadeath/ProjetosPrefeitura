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
            this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSSet = new OS_CodeFirst.BD.OSSet();
            this.osTableAdapter = new OS_CodeFirst.BD.OSSetTableAdapters.osTableAdapter();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.MbtnGerar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(75, 115);
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
            this.cmbOS.Location = new System.Drawing.Point(182, 112);
            this.cmbOS.Name = "cmbOS";
            this.cmbOS.Size = new System.Drawing.Size(121, 21);
            this.cmbOS.TabIndex = 1;
            this.cmbOS.ValueMember = "Id";
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
            // osTableAdapter
            // 
            this.osTableAdapter.ClearBeforeFill = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MbtnGerar
            // 
            this.MbtnGerar.AutoSize = true;
            this.MbtnGerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbtnGerar.Depth = 0;
            this.MbtnGerar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MbtnGerar.Icon = null;
            this.MbtnGerar.Location = new System.Drawing.Point(152, 185);
            this.MbtnGerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MbtnGerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.MbtnGerar.Name = "MbtnGerar";
            this.MbtnGerar.Primary = false;
            this.MbtnGerar.Size = new System.Drawing.Size(64, 36);
            this.MbtnGerar.TabIndex = 4;
            this.MbtnGerar.Text = "Gerar";
            this.MbtnGerar.UseVisualStyleBackColor = true;
            this.MbtnGerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // Geracao_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 279);
            this.Controls.Add(this.MbtnGerar);
            this.Controls.Add(this.cmbOS);
            this.Controls.Add(this.lblOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Geracao_OS";
            this.Sizable = false;
            this.Text = "Geracao_OS";
            this.Load += new System.EventHandler(this.Geracao_OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.ComboBox cmbOS;
        private OSSet oSSet;
        private System.Windows.Forms.BindingSource osBindingSource;
        private BD.OSSetTableAdapters.osTableAdapter osTableAdapter;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialFlatButton MbtnGerar;
    }
}