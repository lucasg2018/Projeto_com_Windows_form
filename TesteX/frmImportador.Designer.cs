namespace TesteX
{
    partial class FrmImportador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportador));
            this.progressBarImportar = new System.Windows.Forms.ProgressBar();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIconAviso = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // progressBarImportar
            // 
            this.progressBarImportar.Location = new System.Drawing.Point(93, 49);
            this.progressBarImportar.Name = "progressBarImportar";
            this.progressBarImportar.Size = new System.Drawing.Size(295, 47);
            this.progressBarImportar.TabIndex = 0;
            // 
            // buttonImportar
            // 
            this.buttonImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportar.Location = new System.Drawing.Point(93, 131);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(295, 34);
            this.buttonImportar.TabIndex = 1;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique no botão importar para atualizar os dados";
            // 
            // notifyIconAviso
            // 
            this.notifyIconAviso.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconAviso.Icon")));
            this.notifyIconAviso.Text = "notifyIcon1";
            this.notifyIconAviso.Visible = true;
            // 
            // FrmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.progressBarImportar);
            this.Name = "FrmImportador";
            this.Text = "frmImportador";
            this.Load += new System.EventHandler(this.FrmImportador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarImportar;
        private System.Windows.Forms.Button buttonImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIconAviso;
    }
}