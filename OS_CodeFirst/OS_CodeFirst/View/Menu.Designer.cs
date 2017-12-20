namespace OS_CodeFirst
{
    partial class FrmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroAlteraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prioridadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoXFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prioridadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusDaOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaProdamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreAjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOS = new System.Windows.Forms.Panel();
            this.StatusDaOs = new OS_CodeFirst.BD.OS__Ativas_Atrasadas();
            this.oS__Ativas_Atrasadas = new OS_CodeFirst.BD.OS__Ativas_Atrasadas();
            this.consulta_UltimoStatusTableAdapter = new OS_CodeFirst.BD.OS__Ativas_AtrasadasTableAdapters.Consulta_UltimoStatusTableAdapter();
            this.OsAtivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemservicoDataSet1 = new OS_CodeFirst.BD.ordemservicoDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDaOs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oS__Ativas_Atrasadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsAtivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlteraçãoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.geraçãoToolStripMenuItem,
            this.sobreAjudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroAlteraçãoToolStripMenuItem
            // 
            this.cadastroAlteraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemDeServicoToolStripMenuItem,
            this.prioridadeToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.tipoDeServiçoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.vinculosToolStripMenuItem});
            this.cadastroAlteraçãoToolStripMenuItem.Name = "cadastroAlteraçãoToolStripMenuItem";
            this.cadastroAlteraçãoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroAlteraçãoToolStripMenuItem.Text = "Cadastro";
            this.cadastroAlteraçãoToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlteraçãoToolStripMenuItem_Click);
            // 
            // ordemDeServicoToolStripMenuItem
            // 
            this.ordemDeServicoToolStripMenuItem.Name = "ordemDeServicoToolStripMenuItem";
            this.ordemDeServicoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ordemDeServicoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServicoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServicoToolStripMenuItem_Click);
            // 
            // prioridadeToolStripMenuItem
            // 
            this.prioridadeToolStripMenuItem.Name = "prioridadeToolStripMenuItem";
            this.prioridadeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.prioridadeToolStripMenuItem.Text = "Prioridade";
            this.prioridadeToolStripMenuItem.Click += new System.EventHandler(this.prioridadeToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // tipoDeServiçoToolStripMenuItem
            // 
            this.tipoDeServiçoToolStripMenuItem.Name = "tipoDeServiçoToolStripMenuItem";
            this.tipoDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tipoDeServiçoToolStripMenuItem.Text = "Tipo de Serviço";
            this.tipoDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeServiçoToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // vinculosToolStripMenuItem
            // 
            this.vinculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoXFuncionarioToolStripMenuItem});
            this.vinculosToolStripMenuItem.Name = "vinculosToolStripMenuItem";
            this.vinculosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vinculosToolStripMenuItem.Text = "Vinculos";
            // 
            // departamentoXFuncionarioToolStripMenuItem
            // 
            this.departamentoXFuncionarioToolStripMenuItem.Name = "departamentoXFuncionarioToolStripMenuItem";
            this.departamentoXFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.departamentoXFuncionarioToolStripMenuItem.Text = "Departamento X Funcionario";
            this.departamentoXFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.departamentoXFuncionarioToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oSToolStripMenuItem,
            this.prioridadeToolStripMenuItem1,
            this.sistemaToolStripMenuItem1,
            this.funcionariosToolStripMenuItem1,
            this.statusToolStripMenuItem1,
            this.tipoDeServiçoToolStripMenuItem1,
            this.statusDaOSToolStripMenuItem,
            this.entregaProdamToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.consultaToolStripMenuItem.Text = "Consulta/Alteracao";
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.oSToolStripMenuItem.Text = "Ordem de Serviço";
            this.oSToolStripMenuItem.Click += new System.EventHandler(this.oSToolStripMenuItem_Click);
            // 
            // prioridadeToolStripMenuItem1
            // 
            this.prioridadeToolStripMenuItem1.Name = "prioridadeToolStripMenuItem1";
            this.prioridadeToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.prioridadeToolStripMenuItem1.Text = "Prioridade";
            this.prioridadeToolStripMenuItem1.Click += new System.EventHandler(this.prioridadeToolStripMenuItem1_Click);
            // 
            // sistemaToolStripMenuItem1
            // 
            this.sistemaToolStripMenuItem1.Name = "sistemaToolStripMenuItem1";
            this.sistemaToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.sistemaToolStripMenuItem1.Text = "Sistema";
            this.sistemaToolStripMenuItem1.Click += new System.EventHandler(this.sistemaToolStripMenuItem1_Click);
            // 
            // funcionariosToolStripMenuItem1
            // 
            this.funcionariosToolStripMenuItem1.Name = "funcionariosToolStripMenuItem1";
            this.funcionariosToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.funcionariosToolStripMenuItem1.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem1.Click += new System.EventHandler(this.funcionariosToolStripMenuItem1_Click);
            // 
            // statusToolStripMenuItem1
            // 
            this.statusToolStripMenuItem1.Name = "statusToolStripMenuItem1";
            this.statusToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.statusToolStripMenuItem1.Text = "Status";
            this.statusToolStripMenuItem1.Click += new System.EventHandler(this.statusToolStripMenuItem1_Click);
            // 
            // tipoDeServiçoToolStripMenuItem1
            // 
            this.tipoDeServiçoToolStripMenuItem1.Name = "tipoDeServiçoToolStripMenuItem1";
            this.tipoDeServiçoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.tipoDeServiçoToolStripMenuItem1.Text = "Tipo de Serviço";
            this.tipoDeServiçoToolStripMenuItem1.Click += new System.EventHandler(this.tipoDeServiçoToolStripMenuItem1_Click);
            // 
            // statusDaOSToolStripMenuItem
            // 
            this.statusDaOSToolStripMenuItem.Name = "statusDaOSToolStripMenuItem";
            this.statusDaOSToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.statusDaOSToolStripMenuItem.Text = "Status da OS";
            this.statusDaOSToolStripMenuItem.Click += new System.EventHandler(this.statusDaOSToolStripMenuItem_Click);
            // 
            // entregaProdamToolStripMenuItem
            // 
            this.entregaProdamToolStripMenuItem.Name = "entregaProdamToolStripMenuItem";
            this.entregaProdamToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.entregaProdamToolStripMenuItem.Text = "Entrega Prodam";
            this.entregaProdamToolStripMenuItem.Click += new System.EventHandler(this.entregaProdamToolStripMenuItem_Click);
            // 
            // geraçãoToolStripMenuItem
            // 
            this.geraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oSToolStripMenuItem1});
            this.geraçãoToolStripMenuItem.Name = "geraçãoToolStripMenuItem";
            this.geraçãoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.geraçãoToolStripMenuItem.Text = "Geração";
            this.geraçãoToolStripMenuItem.Click += new System.EventHandler(this.geraçãoToolStripMenuItem_Click);
            // 
            // oSToolStripMenuItem1
            // 
            this.oSToolStripMenuItem1.Name = "oSToolStripMenuItem1";
            this.oSToolStripMenuItem1.Size = new System.Drawing.Size(89, 22);
            this.oSToolStripMenuItem1.Text = "OS";
            this.oSToolStripMenuItem1.Click += new System.EventHandler(this.oSToolStripMenuItem1_Click);
            // 
            // sobreAjudaToolStripMenuItem
            // 
            this.sobreAjudaToolStripMenuItem.Name = "sobreAjudaToolStripMenuItem";
            this.sobreAjudaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sobreAjudaToolStripMenuItem.Text = "Sobre/Ajuda";
            this.sobreAjudaToolStripMenuItem.Click += new System.EventHandler(this.sobreAjudaToolStripMenuItem_Click);
            // 
            // pnlOS
            // 
            this.pnlOS.AutoScroll = true;
            this.pnlOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOS.Location = new System.Drawing.Point(548, 62);
            this.pnlOS.Name = "pnlOS";
            this.pnlOS.Size = new System.Drawing.Size(200, 324);
            this.pnlOS.TabIndex = 1;
            this.pnlOS.AutoSizeChanged += new System.EventHandler(this.pnlOS_AutoSizeChanged);
            // 
            // StatusDaOs
            // 
            this.StatusDaOs.DataSetName = "OS__Ativas_Atrasadas";
            this.StatusDaOs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oS__Ativas_Atrasadas
            // 
            this.oS__Ativas_Atrasadas.DataSetName = "OS__Ativas_Atrasadas";
            this.oS__Ativas_Atrasadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta_UltimoStatusTableAdapter
            // 
            this.consulta_UltimoStatusTableAdapter.ClearBeforeFill = true;
            // 
            // OsAtivasBindingSource
            // 
            this.OsAtivasBindingSource.DataMember = "Consulta_UltimoStatus";
            this.OsAtivasBindingSource.DataSource = this.StatusDaOs;
            // 
            // ordemservicoDataSet1
            // 
            this.ordemservicoDataSet1.DataSetName = "ordemservicoDataSet";
            this.ordemservicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 388);
            this.Controls.Add(this.pnlOS);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInicial";
            this.Sizable = false;
            this.Text = "Sistema de Gerenciamento de Ordens de Serviço";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDaOs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oS__Ativas_Atrasadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsAtivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlteraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prioridadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prioridadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreAjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeServiçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusDaOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaProdamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlOS;
        private BD.OS__Ativas_Atrasadas StatusDaOs;
        private BD.OS__Ativas_Atrasadas oS__Ativas_Atrasadas;
        private BD.OS__Ativas_AtrasadasTableAdapters.Consulta_UltimoStatusTableAdapter consulta_UltimoStatusTableAdapter;
        private System.Windows.Forms.BindingSource OsAtivasBindingSource;
        private BD.ordemservicoDataSet ordemservicoDataSet1;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoXFuncionarioToolStripMenuItem;
    }
}

