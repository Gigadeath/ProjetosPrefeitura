namespace OS_CodeFirst.View
{
    partial class Geracao_Aceite
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
            this.MbtnGerar = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbOS = new System.Windows.Forms.ComboBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.oS__Ativas_Atrasadas = new OS_CodeFirst.BD.OS__Ativas_Atrasadas();
            this.consultaUltimoStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consulta_UltimoStatusTableAdapter = new OS_CodeFirst.BD.OS__Ativas_AtrasadasTableAdapters.Consulta_UltimoStatusTableAdapter();
            this.consulta_Aceite = new OS_CodeFirst.BD.Consulta_Aceite();
            this.aceiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aceiteTableAdapter = new OS_CodeFirst.BD.Consulta_AceiteTableAdapters.AceiteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oS__Ativas_Atrasadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUltimoStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta_Aceite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MbtnGerar
            // 
            this.MbtnGerar.AutoSize = true;
            this.MbtnGerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbtnGerar.Depth = 0;
            this.MbtnGerar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MbtnGerar.Icon = null;
            this.MbtnGerar.Location = new System.Drawing.Point(111, 203);
            this.MbtnGerar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MbtnGerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.MbtnGerar.Name = "MbtnGerar";
            this.MbtnGerar.Primary = false;
            this.MbtnGerar.Size = new System.Drawing.Size(64, 36);
            this.MbtnGerar.TabIndex = 7;
            this.MbtnGerar.Text = "Gerar";
            this.MbtnGerar.UseVisualStyleBackColor = true;
            this.MbtnGerar.Click += new System.EventHandler(this.MbtnGerar_Click);
            // 
            // cmbOS
            // 
            this.cmbOS.DataSource = this.aceiteBindingSource;
            this.cmbOS.DisplayMember = "OSN";
            this.cmbOS.FormattingEnabled = true;
            this.cmbOS.Location = new System.Drawing.Point(141, 130);
            this.cmbOS.Name = "cmbOS";
            this.cmbOS.Size = new System.Drawing.Size(121, 21);
            this.cmbOS.TabIndex = 6;
            this.cmbOS.ValueMember = "Id";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(34, 133);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(80, 13);
            this.lblOS.TabIndex = 5;
            this.lblOS.Text = "Numero da OS:";
            // 
            // oS__Ativas_Atrasadas
            // 
            this.oS__Ativas_Atrasadas.DataSetName = "OS__Ativas_Atrasadas";
            this.oS__Ativas_Atrasadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaUltimoStatusBindingSource
            // 
            this.consultaUltimoStatusBindingSource.DataMember = "Consulta_UltimoStatus";
            this.consultaUltimoStatusBindingSource.DataSource = this.oS__Ativas_Atrasadas;
            // 
            // consulta_UltimoStatusTableAdapter
            // 
            this.consulta_UltimoStatusTableAdapter.ClearBeforeFill = true;
            // 
            // consulta_Aceite
            // 
            this.consulta_Aceite.DataSetName = "Consulta_Aceite";
            this.consulta_Aceite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aceiteBindingSource
            // 
            this.aceiteBindingSource.DataMember = "Aceite";
            this.aceiteBindingSource.DataSource = this.consulta_Aceite;
            // 
            // aceiteTableAdapter
            // 
            this.aceiteTableAdapter.ClearBeforeFill = true;
            // 
            // Geracao_Aceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.MbtnGerar);
            this.Controls.Add(this.cmbOS);
            this.Controls.Add(this.lblOS);
            this.MaximizeBox = false;
            this.Name = "Geracao_Aceite";
            this.Sizable = false;
            this.Text = "Geracao de Aceite";
            this.Load += new System.EventHandler(this.Geracao_Aceite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oS__Ativas_Atrasadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUltimoStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta_Aceite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton MbtnGerar;
        private System.Windows.Forms.ComboBox cmbOS;
        private System.Windows.Forms.Label lblOS;
        private BD.OS__Ativas_Atrasadas oS__Ativas_Atrasadas;
        private System.Windows.Forms.BindingSource consultaUltimoStatusBindingSource;
        private BD.OS__Ativas_AtrasadasTableAdapters.Consulta_UltimoStatusTableAdapter consulta_UltimoStatusTableAdapter;
        private BD.Consulta_Aceite consulta_Aceite;
        private System.Windows.Forms.BindingSource aceiteBindingSource;
        private BD.Consulta_AceiteTableAdapters.AceiteTableAdapter aceiteTableAdapter;
    }
}