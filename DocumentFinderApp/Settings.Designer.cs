namespace DocumentFinderApp
{
    partial class Settings
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
            this.SettingsHeading = new System.Windows.Forms.Label();
            this.FolderPath1 = new System.Windows.Forms.Label();
            this.InputFolderPath1 = new System.Windows.Forms.TextBox();
            this.FolderPath2 = new System.Windows.Forms.Label();
            this.InputFolderPath2 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsHeading
            // 
            this.SettingsHeading.AutoSize = true;
            this.SettingsHeading.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsHeading.Location = new System.Drawing.Point(11, 11);
            this.SettingsHeading.Name = "SettingsHeading";
            this.SettingsHeading.Size = new System.Drawing.Size(198, 65);
            this.SettingsHeading.TabIndex = 0;
            this.SettingsHeading.Text = "Settings";
            // 
            // FolderPath1
            // 
            this.FolderPath1.AutoSize = true;
            this.FolderPath1.Location = new System.Drawing.Point(16, 92);
            this.FolderPath1.Name = "FolderPath1";
            this.FolderPath1.Size = new System.Drawing.Size(276, 32);
            this.FolderPath1.TabIndex = 1;
            this.FolderPath1.Text = "Folder Path for Windows";
            // 
            // InputFolderPath1
            // 
            this.InputFolderPath1.Location = new System.Drawing.Point(21, 127);
            this.InputFolderPath1.Name = "InputFolderPath1";
            this.InputFolderPath1.Size = new System.Drawing.Size(392, 39);
            this.InputFolderPath1.TabIndex = 2;
            // 
            // FolderPath2
            // 
            this.FolderPath2.AutoSize = true;
            this.FolderPath2.Location = new System.Drawing.Point(16, 192);
            this.FolderPath2.Name = "FolderPath2";
            this.FolderPath2.Size = new System.Drawing.Size(269, 32);
            this.FolderPath2.TabIndex = 3;
            this.FolderPath2.Text = "Foler Path for SAP/UNIX";
            // 
            // InputFolderPath2
            // 
            this.InputFolderPath2.Location = new System.Drawing.Point(22, 227);
            this.InputFolderPath2.Name = "InputFolderPath2";
            this.InputFolderPath2.Size = new System.Drawing.Size(392, 39);
            this.InputFolderPath2.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.Location = new System.Drawing.Point(155, 292);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(137, 42);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(506, 360);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InputFolderPath2);
            this.Controls.Add(this.FolderPath2);
            this.Controls.Add(this.InputFolderPath1);
            this.Controls.Add(this.FolderPath1);
            this.Controls.Add(this.SettingsHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsHeading;
        private System.Windows.Forms.Label FolderPath1;
        private System.Windows.Forms.TextBox InputFolderPath1;
        private System.Windows.Forms.Label FolderPath2;
        private System.Windows.Forms.TextBox InputFolderPath2;
        private System.Windows.Forms.Button SaveButton;
    }
}

