namespace OS_CodeFirst.View
{
    partial class FormProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgress));
            this.pgbInicial = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbInicial
            // 
            this.pgbInicial.Location = new System.Drawing.Point(12, 250);
            this.pgbInicial.Name = "pgbInicial";
            this.pgbInicial.Size = new System.Drawing.Size(450, 23);
            this.pgbInicial.TabIndex = 0;
            this.pgbInicial.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OS_CodeFirst.Properties.Resources.LogoOS;
            this.pictureBox1.ErrorImage = global::OS_CodeFirst.Properties.Resources.LogoOS;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::OS_CodeFirst.Properties.Resources.LogoOS;
            this.pictureBox1.Location = new System.Drawing.Point(25, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 176);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 285);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pgbInicial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.Sizable = false;
            this.Text = "Bem-vindo ao OS Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbInicial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}