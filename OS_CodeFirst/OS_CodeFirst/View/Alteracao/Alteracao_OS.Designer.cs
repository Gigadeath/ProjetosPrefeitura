namespace OS_CodeFirst.View
{
    partial class Alteracao_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alteracao_OS));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSolicitacao = new System.Windows.Forms.TextBox();
            this.mtxtEntregue = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtPrev = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.cmbResp = new System.Windows.Forms.ComboBox();
            this.mtxtDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.mtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.mtxtPA = new System.Windows.Forms.MaskedTextBox();
            this.mtxtOS = new System.Windows.Forms.MaskedTextBox();
            this.lblPA = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.cmbSistema = new System.Windows.Forms.ComboBox();
            this.sistemaSet = new OS_CodeFirst.BD.SistemaSet();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaTableAdapter = new OS_CodeFirst.BD.SistemaSetTableAdapters.sistemaTableAdapter();
            this.ordemservicoDataSet = new OS_CodeFirst.BD.ordemservicoDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSetTableAdapters.funcionarioTableAdapter();
            this.ordemservicoDataSet1 = new OS_CodeFirst.BD.ordemservicoDataSet1();
            this.prioridadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prioridadeTableAdapter = new OS_CodeFirst.BD.ordemservicoDataSet1TableAdapters.prioridadeTableAdapter();
            this.tipoServicoDataSet = new OS_CodeFirst.BD.TipoServicoDataSet();
            this.tiposervicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposervicoTableAdapter = new OS_CodeFirst.BD.TipoServicoDataSetTableAdapters.tiposervicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposervicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(558, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.Text = "Alterar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(558, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Items.AddRange(new object[] {
            "Garantia",
            "Manutenção em Sistema já Existente"});
            this.cmbServico.Location = new System.Drawing.Point(72, 186);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(100, 21);
            this.cmbServico.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Descrição:";
            // 
            // txtSolicitacao
            // 
            this.txtSolicitacao.Location = new System.Drawing.Point(13, 238);
            this.txtSolicitacao.Multiline = true;
            this.txtSolicitacao.Name = "txtSolicitacao";
            this.txtSolicitacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolicitacao.Size = new System.Drawing.Size(526, 81);
            this.txtSolicitacao.TabIndex = 82;
            // 
            // mtxtEntregue
            // 
            this.mtxtEntregue.Location = new System.Drawing.Point(487, 182);
            this.mtxtEntregue.Mask = "00/00/0000";
            this.mtxtEntregue.Name = "mtxtEntregue";
            this.mtxtEntregue.Size = new System.Drawing.Size(121, 20);
            this.mtxtEntregue.TabIndex = 81;
            this.mtxtEntregue.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Data Ent.:";
            // 
            // mtxtPrev
            // 
            this.mtxtPrev.Location = new System.Drawing.Point(281, 186);
            this.mtxtPrev.Mask = "00/00/0000";
            this.mtxtPrev.Name = "mtxtPrev";
            this.mtxtPrev.Size = new System.Drawing.Size(121, 20);
            this.mtxtPrev.TabIndex = 79;
            this.mtxtPrev.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Data Prev.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Serviço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Item Cont.:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(487, 135);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(121, 20);
            this.txtItem.TabIndex = 75;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.tiposervicoBindingSource;
            this.cmbTipo.DisplayMember = "Nome";
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(281, 135);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 74;
            this.cmbTipo.ValueMember = "Id";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.DataSource = this.prioridadeBindingSource;
            this.cmbPrioridade.DisplayMember = "Nivel";
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Location = new System.Drawing.Point(72, 135);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(100, 21);
            this.cmbPrioridade.TabIndex = 73;
            this.cmbPrioridade.ValueMember = "Id";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(13, 138);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(57, 13);
            this.lblPrioridade.TabIndex = 72;
            this.lblPrioridade.Text = "Prioridade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tipo:";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(443, 95);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(38, 13);
            this.lblResp.TabIndex = 70;
            this.lblResp.Text = "Resp.:";
            // 
            // cmbResp
            // 
            this.cmbResp.DataSource = this.funcionarioBindingSource;
            this.cmbResp.DisplayMember = "Nome";
            this.cmbResp.FormattingEnabled = true;
            this.cmbResp.Location = new System.Drawing.Point(487, 90);
            this.cmbResp.Name = "cmbResp";
            this.cmbResp.Size = new System.Drawing.Size(121, 21);
            this.cmbResp.TabIndex = 69;
            this.cmbResp.ValueMember = "Id";
            // 
            // mtxtDataEmissao
            // 
            this.mtxtDataEmissao.Location = new System.Drawing.Point(281, 92);
            this.mtxtDataEmissao.Mask = "00/00/0000";
            this.mtxtDataEmissao.Name = "mtxtDataEmissao";
            this.mtxtDataEmissao.Size = new System.Drawing.Size(121, 20);
            this.mtxtDataEmissao.TabIndex = 68;
            this.mtxtDataEmissao.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(188, 95);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(75, 13);
            this.lblDataEmissao.TabIndex = 67;
            this.lblDataEmissao.Text = "Data Emissao:";
            // 
            // mtxtTC
            // 
            this.mtxtTC.Location = new System.Drawing.Point(72, 95);
            this.mtxtTC.Mask = "000/SME/0000";
            this.mtxtTC.Name = "mtxtTC";
            this.mtxtTC.ReadOnly = true;
            this.mtxtTC.Size = new System.Drawing.Size(100, 20);
            this.mtxtTC.TabIndex = 66;
            this.mtxtTC.Text = "1332014";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(25, 95);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(30, 13);
            this.lblTC.TabIndex = 65;
            this.lblTC.Text = "T.C.:";
            // 
            // mtxtPA
            // 
            this.mtxtPA.Location = new System.Drawing.Point(487, 34);
            this.mtxtPA.Mask = "0000,0000/0000000-0";
            this.mtxtPA.Name = "mtxtPA";
            this.mtxtPA.ReadOnly = true;
            this.mtxtPA.Size = new System.Drawing.Size(120, 20);
            this.mtxtPA.TabIndex = 64;
            this.mtxtPA.Text = "6016201600158033";
            // 
            // mtxtOS
            // 
            this.mtxtOS.Location = new System.Drawing.Point(72, 35);
            this.mtxtOS.Mask = "000-0000/0000";
            this.mtxtOS.Name = "mtxtOS";
            this.mtxtOS.ReadOnly = true;
            this.mtxtOS.Size = new System.Drawing.Size(100, 20);
            this.mtxtOS.TabIndex = 63;
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(451, 37);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(30, 13);
            this.lblPA.TabIndex = 62;
            this.lblPA.Text = "P.A.:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(15, 37);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(40, 13);
            this.lblOS.TabIndex = 61;
            this.lblOS.Text = "OS N°:";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(216, 37);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(47, 13);
            this.lblSistema.TabIndex = 59;
            this.lblSistema.Text = "Sistema:";
            // 
            // cmbSistema
            // 
            this.cmbSistema.DataSource = this.sistemaBindingSource;
            this.cmbSistema.DisplayMember = "Nome";
            this.cmbSistema.Enabled = false;
            this.cmbSistema.FormattingEnabled = true;
            this.cmbSistema.Location = new System.Drawing.Point(281, 34);
            this.cmbSistema.Name = "cmbSistema";
            this.cmbSistema.Size = new System.Drawing.Size(121, 21);
            this.cmbSistema.TabIndex = 60;
            this.cmbSistema.ValueMember = "Id";
            // 
            // sistemaSet
            // 
            this.sistemaSet.DataSetName = "SistemaSet";
            this.sistemaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaBindingSource
            // 
            this.sistemaBindingSource.DataMember = "sistema";
            this.sistemaBindingSource.DataSource = this.sistemaSet;
            // 
            // sistemaTableAdapter
            // 
            this.sistemaTableAdapter.ClearBeforeFill = true;
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
            // ordemservicoDataSet1
            // 
            this.ordemservicoDataSet1.DataSetName = "ordemservicoDataSet1";
            this.ordemservicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prioridadeBindingSource
            // 
            this.prioridadeBindingSource.DataMember = "prioridade";
            this.prioridadeBindingSource.DataSource = this.ordemservicoDataSet1;
            // 
            // prioridadeTableAdapter
            // 
            this.prioridadeTableAdapter.ClearBeforeFill = true;
            // 
            // tipoServicoDataSet
            // 
            this.tipoServicoDataSet.DataSetName = "TipoServicoDataSet";
            this.tipoServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposervicoBindingSource
            // 
            this.tiposervicoBindingSource.DataMember = "tiposervico";
            this.tiposervicoBindingSource.DataSource = this.tipoServicoDataSet;
            // 
            // tiposervicoTableAdapter
            // 
            this.tiposervicoTableAdapter.ClearBeforeFill = true;
            // 
            // Alteracao_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 331);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSolicitacao);
            this.Controls.Add(this.mtxtEntregue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtPrev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.cmbResp);
            this.Controls.Add(this.mtxtDataEmissao);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.mtxtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.mtxtPA);
            this.Controls.Add(this.mtxtOS);
            this.Controls.Add(this.lblPA);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.cmbSistema);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alteracao_OS";
            this.Text = "Alteração da Ordem de Serviço";
            this.Load += new System.EventHandler(this.Alteracao_OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioridadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposervicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSolicitacao;
        private System.Windows.Forms.MaskedTextBox mtxtEntregue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtPrev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.ComboBox cmbResp;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmissao;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.MaskedTextBox mtxtTC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.MaskedTextBox mtxtPA;
        private System.Windows.Forms.MaskedTextBox mtxtOS;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.ComboBox cmbSistema;
        private BD.SistemaSet sistemaSet;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private BD.SistemaSetTableAdapters.sistemaTableAdapter sistemaTableAdapter;
        private BD.ordemservicoDataSet ordemservicoDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BD.ordemservicoDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private BD.ordemservicoDataSet1 ordemservicoDataSet1;
        private System.Windows.Forms.BindingSource prioridadeBindingSource;
        private BD.ordemservicoDataSet1TableAdapters.prioridadeTableAdapter prioridadeTableAdapter;
        private BD.TipoServicoDataSet tipoServicoDataSet;
        private System.Windows.Forms.BindingSource tiposervicoBindingSource;
        private BD.TipoServicoDataSetTableAdapters.tiposervicoTableAdapter tiposervicoTableAdapter;
    }
}