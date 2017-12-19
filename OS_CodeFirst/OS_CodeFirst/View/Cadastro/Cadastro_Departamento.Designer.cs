namespace OS_CodeFirst.View.Cadastro
{
    partial class Cadastro_Departamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Departamento));
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mbtnCadastrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(99, 83);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(157, 20);
            this.txtDepartamento.TabIndex = 0;
            this.txtDepartamento.Text = "SME/CODAE/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamento:";
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.AutoSize = true;
            this.mbtnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCadastrar.Depth = 0;
            this.mbtnCadastrar.Icon = null;
            this.mbtnCadastrar.Location = new System.Drawing.Point(14, 127);
            this.mbtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.Primary = false;
            this.mbtnCadastrar.Size = new System.Drawing.Size(100, 36);
            this.mbtnCadastrar.TabIndex = 4;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.UseVisualStyleBackColor = true;
            this.mbtnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSize = true;
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.Icon = null;
            this.mbtnCancel.Location = new System.Drawing.Point(177, 127);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Primary = false;
            this.mbtnCancel.Size = new System.Drawing.Size(91, 36);
            this.mbtnCancel.TabIndex = 5;
            this.mbtnCancel.Text = "Cancelar";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // Cadastro_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(291, 175);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_Departamento";
            this.Text = " Cadastro de Setor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton mbtnCadastrar;
        private MaterialSkin.Controls.MaterialFlatButton mbtnCancel;
    }
}