namespace RhoSimuController
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFolter = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnFolter
            // 
            this.btnFolter.Image = global::RhoSimuController.Properties.Resources.Folder_64;
            this.btnFolter.Location = new System.Drawing.Point(160, 0);
            this.btnFolter.Name = "btnFolter";
            this.btnFolter.Size = new System.Drawing.Size(80, 80);
            this.btnFolter.TabIndex = 2;
            this.btnFolter.UseVisualStyleBackColor = true;
            this.btnFolter.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnKill
            // 
            this.btnKill.Image = global::RhoSimuController.Properties.Resources.Close_64;
            this.btnKill.Location = new System.Drawing.Point(80, 0);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(80, 80);
            this.btnKill.TabIndex = 1;
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = global::RhoSimuController.Properties.Resources.Success_64;
            this.btnRun.Location = new System.Drawing.Point(0, 0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 80);
            this.btnRun.TabIndex = 0;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(234, 81);
            this.Controls.Add(this.btnFolter);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 120);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "Rho RC";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnFolter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

