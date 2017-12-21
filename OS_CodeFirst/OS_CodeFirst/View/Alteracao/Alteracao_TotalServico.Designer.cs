namespace OS_CodeFirst.View
{
    partial class Alteracao_TotalServico
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataLimite = new System.Windows.Forms.Label();
            this.mbtnAlterar = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.mtxtDataLimite = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHoras = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas:";
            // 
            // lblDataLimite
            // 
            this.lblDataLimite.AutoSize = true;
            this.lblDataLimite.Location = new System.Drawing.Point(41, 124);
            this.lblDataLimite.Name = "lblDataLimite";
            this.lblDataLimite.Size = new System.Drawing.Size(63, 13);
            this.lblDataLimite.TabIndex = 1;
            this.lblDataLimite.Text = "Data Limite:";
            // 
            // mbtnAlterar
            // 
            this.mbtnAlterar.AutoSize = true;
            this.mbtnAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAlterar.Depth = 0;
            this.mbtnAlterar.Icon = null;
            this.mbtnAlterar.Location = new System.Drawing.Point(44, 162);
            this.mbtnAlterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAlterar.Name = "mbtnAlterar";
            this.mbtnAlterar.Primary = false;
            this.mbtnAlterar.Size = new System.Drawing.Size(80, 36);
            this.mbtnAlterar.TabIndex = 2;
            this.mbtnAlterar.Text = "alterar";
            this.mbtnAlterar.UseVisualStyleBackColor = true;
            this.mbtnAlterar.Click += new System.EventHandler(this.mbtnAlterar_Click);
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.AutoSize = true;
            this.mbtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancelar.Depth = 0;
            this.mbtnCancelar.Icon = null;
            this.mbtnCancelar.Location = new System.Drawing.Point(178, 162);
            this.mbtnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Primary = false;
            this.mbtnCancelar.Size = new System.Drawing.Size(91, 36);
            this.mbtnCancelar.TabIndex = 3;
            this.mbtnCancelar.Text = "Cancelar";
            this.mbtnCancelar.UseVisualStyleBackColor = true;
            // 
            // mtxtDataLimite
            // 
            this.mtxtDataLimite.Location = new System.Drawing.Point(110, 121);
            this.mtxtDataLimite.Mask = "00/00/0000";
            this.mtxtDataLimite.Name = "mtxtDataLimite";
            this.mtxtDataLimite.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataLimite.TabIndex = 5;
            this.mtxtDataLimite.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHoras
            // 
            this.mtxtHoras.Location = new System.Drawing.Point(110, 80);
            this.mtxtHoras.Mask = "00000";
            this.mtxtHoras.Name = "mtxtHoras";
            this.mtxtHoras.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoras.TabIndex = 6;
            this.mtxtHoras.ValidatingType = typeof(System.DateTime);
            // 
            // Alteracao_TotalServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 213);
            this.Controls.Add(this.mtxtHoras);
            this.Controls.Add(this.mtxtDataLimite);
            this.Controls.Add(this.mbtnCancelar);
            this.Controls.Add(this.mbtnAlterar);
            this.Controls.Add(this.lblDataLimite);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Alteracao_TotalServico";
            this.Sizable = false;
            this.Text = "Alteracao do Total do Servico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataLimite;
        private MaterialSkin.Controls.MaterialFlatButton mbtnAlterar;
        private MaterialSkin.Controls.MaterialFlatButton mbtnCancelar;
        private System.Windows.Forms.MaskedTextBox mtxtDataLimite;
        private System.Windows.Forms.MaskedTextBox mtxtHoras;
    }
}