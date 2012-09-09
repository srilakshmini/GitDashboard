namespace GitDashBoard
{
    partial class CloneRepo
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
            this.txtRepoDirectory = new System.Windows.Forms.TextBox();
            this.txtRemoteRepoURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repo Directory";
            // 
            // txtRepoDirectory
            // 
            this.txtRepoDirectory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtRepoDirectory.Location = new System.Drawing.Point(163, 49);
            this.txtRepoDirectory.Name = "txtRepoDirectory";
            this.txtRepoDirectory.Size = new System.Drawing.Size(332, 27);
            this.txtRepoDirectory.TabIndex = 1;
            // 
            // txtRemoteRepoURL
            // 
            this.txtRemoteRepoURL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtRemoteRepoURL.Location = new System.Drawing.Point(163, 90);
            this.txtRemoteRepoURL.Name = "txtRemoteRepoURL";
            this.txtRemoteRepoURL.Size = new System.Drawing.Size(332, 27);
            this.txtRemoteRepoURL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remote Repo URL";
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtConsole.Location = new System.Drawing.Point(16, 159);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(479, 143);
            this.txtConsole.TabIndex = 4;
            // 
            // btnClone
            // 
            this.btnClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClone.Location = new System.Drawing.Point(216, 316);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 33);
            this.btnClone.TabIndex = 5;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // bg
            // 
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            this.bg.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_ProgressChanged);
            this.bg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_RunWorkerCompleted);
            // 
            // CloneRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 360);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtRemoteRepoURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRepoDirectory);
            this.Controls.Add(this.label1);
            this.Name = "CloneRepo";
            this.Text = "CloneRepo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepoDirectory;
        private System.Windows.Forms.TextBox txtRemoteRepoURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnClone;
        private System.ComponentModel.BackgroundWorker bg;
    }
}