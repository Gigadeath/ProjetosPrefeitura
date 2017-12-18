namespace OS_CodeFirst.View.Cadastro
{
    partial class Cadastro_DepxFun
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
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ordemservicoDataSet = new OS_CodeFirst.BD.ordemservicoDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSetTableAdapters.funcionarioTableAdapter();
            this.departamentoDataSet = new OS_CodeFirst.DepartamentoDataSet();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new OS_CodeFirst.DepartamentoDataSetTableAdapters.departamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DataSource = this.funcionarioBindingSource;
            this.cmbFuncionario.DisplayMember = "Nome";
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(116, 58);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncionario.TabIndex = 0;
            this.cmbFuncionario.ValueMember = "Id";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(29, 61);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 1;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departamento:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.DataSource = this.departamentoBindingSource;
            this.cmbSetor.DisplayMember = "Setor";
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(116, 132);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(121, 21);
            this.cmbSetor.TabIndex = 3;
            this.cmbSetor.ValueMember = "Id";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 187);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ordemservicoDataSet
            // 
            this.ordemservicoDataSet.DataSetName = "ordemservicoDataSet";
            this.ordemservicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.ordemservicoDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoDataSet
            // 
            this.departamentoDataSet.DataSetName = "DepartamentoDataSet";
            this.departamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "departamento";
            this.departamentoBindingSource.DataSource = this.departamentoDataSet;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // Cadastro_DepxFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 262);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.cmbFuncionario);
            this.Name = "Cadastro_DepxFun";
            this.Text = "DepxFun";
            this.Load += new System.EventHandler(this.Cadastro_DepxFun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private BD.ordemservicoDataSet ordemservicoDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BD.ordemservicoDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private DepartamentoDataSet departamentoDataSet;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DepartamentoDataSetTableAdapters.departamentoTableAdapter departamentoTableAdapter;
    }
}