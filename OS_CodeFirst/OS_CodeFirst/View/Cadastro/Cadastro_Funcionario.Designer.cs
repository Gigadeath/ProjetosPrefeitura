namespace OS_CodeFirst.View
{
    partial class Cadastro_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Funcionario));
            this.lblRF = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtRF = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblRF
            // 
            this.lblRF.AutoSize = true;
            this.lblRF.Location = new System.Drawing.Point(28, 91);
            this.lblRF.Name = "lblRF";
            this.lblRF.Size = new System.Drawing.Size(24, 13);
            this.lblRF.TabIndex = 1;
            this.lblRF.Text = "RF:";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(14, 131);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFunc.TabIndex = 2;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 3;
            // 
            // mtxtRF
            // 
            this.mtxtRF.Location = new System.Drawing.Point(58, 91);
            this.mtxtRF.Mask = "000,000-0";
            this.mtxtRF.Name = "mtxtRF";
            this.mtxtRF.Size = new System.Drawing.Size(59, 20);
            this.mtxtRF.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(58, 167);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(100, 36);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(197, 167);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 218);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtxtRF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.lblRF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro_Funcionario";
            this.Sizable = false;
            this.Text = "Cadastro de Funcionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRF;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtRF;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}