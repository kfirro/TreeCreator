namespace TreeCreatorApp
{
    partial class TreeCreator
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
            this.console = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtPackageDir = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblProductionPackage = new System.Windows.Forms.Label();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.lblDestDirectory = new System.Windows.Forms.Label();
            this.txtDestinationDir = new System.Windows.Forms.TextBox();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.console.Location = new System.Drawing.Point(12, 144);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(986, 595);
            this.console.TabIndex = 0;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGo.Location = new System.Drawing.Point(928, 44);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(70, 30);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 111);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(56, 18);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output:";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // txtPackageDir
            // 
            this.txtPackageDir.Location = new System.Drawing.Point(53, 50);
            this.txtPackageDir.Name = "txtPackageDir";
            this.txtPackageDir.Size = new System.Drawing.Size(150, 20);
            this.txtPackageDir.TabIndex = 3;
            this.txtPackageDir.TextChanged += new System.EventHandler(this.txtPackageDir_TextChanged);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.Location = new System.Drawing.Point(35, 32);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(184, 15);
            this.lblPackage.TabIndex = 4;
            this.lblPackage.Text = "Deployment Package\'s Directory";
            this.lblPackage.Click += new System.EventHandler(this.lblPackage_Click);
            // 
            // lblProductionPackage
            // 
            this.lblProductionPackage.AutoSize = true;
            this.lblProductionPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionPackage.Location = new System.Drawing.Point(251, 32);
            this.lblProductionPackage.Name = "lblProductionPackage";
            this.lblProductionPackage.Size = new System.Drawing.Size(146, 15);
            this.lblProductionPackage.TabIndex = 6;
            this.lblProductionPackage.Text = "Current Working Directory";
            this.lblProductionPackage.Click += new System.EventHandler(this.lblProductionPackage_Click);
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Location = new System.Drawing.Point(250, 50);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(150, 20);
            this.txtWorkingDir.TabIndex = 5;
            this.txtWorkingDir.TextChanged += new System.EventHandler(this.txtWorkingDir_TextChanged);
            // 
            // lblDestDirectory
            // 
            this.lblDestDirectory.AutoSize = true;
            this.lblDestDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestDirectory.Location = new System.Drawing.Point(441, 32);
            this.lblDestDirectory.Name = "lblDestDirectory";
            this.lblDestDirectory.Size = new System.Drawing.Size(129, 15);
            this.lblDestDirectory.TabIndex = 8;
            this.lblDestDirectory.Text = "Destination\'s Directory";
            this.lblDestDirectory.Click += new System.EventHandler(this.lblDestDirectory_Click);
            // 
            // txtDestinationDir
            // 
            this.txtDestinationDir.Location = new System.Drawing.Point(433, 50);
            this.txtDestinationDir.Name = "txtDestinationDir";
            this.txtDestinationDir.Size = new System.Drawing.Size(150, 20);
            this.txtDestinationDir.TabIndex = 7;
            this.txtDestinationDir.TextChanged += new System.EventHandler(this.txtDestinationDir_TextChanged);
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClearConsole.Location = new System.Drawing.Point(84, 110);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(75, 23);
            this.btnClearConsole.TabIndex = 9;
            this.btnClearConsole.Text = "Clear Output";
            this.btnClearConsole.UseVisualStyleBackColor = false;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSimulate.Location = new System.Drawing.Point(639, 44);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(70, 30);
            this.btnSimulate.TabIndex = 10;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = false;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // TreeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1051, 769);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.lblDestDirectory);
            this.Controls.Add(this.txtDestinationDir);
            this.Controls.Add(this.lblProductionPackage);
            this.Controls.Add(this.txtWorkingDir);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.txtPackageDir);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.console);
            this.Name = "TreeCreator";
            this.Text = "Tree Creator";
            this.Load += new System.EventHandler(this.TreeCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtPackageDir;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblProductionPackage;
        private System.Windows.Forms.TextBox txtWorkingDir;
        private System.Windows.Forms.Label lblDestDirectory;
        private System.Windows.Forms.TextBox txtDestinationDir;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Button btnSimulate;
    }
}

