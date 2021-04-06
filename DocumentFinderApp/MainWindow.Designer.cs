namespace DocumentFinderApp
{
    partial class MainWindow
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenSetttingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.Location = new System.Drawing.Point(219, 130);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(141, 47);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 47);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Job Name";
            // 
            // OpenSetttingsButton
            // 
            this.OpenSetttingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenSetttingsButton.BackColor = System.Drawing.Color.Black;
            this.OpenSetttingsButton.FlatAppearance.BorderSize = 0;
            this.OpenSetttingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSetttingsButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSetttingsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenSetttingsButton.Image = global::DocumentFinderApp.Properties.Resources.gear_small;
            this.OpenSetttingsButton.Location = new System.Drawing.Point(545, 34);
            this.OpenSetttingsButton.Name = "OpenSetttingsButton";
            this.OpenSetttingsButton.Size = new System.Drawing.Size(31, 31);
            this.OpenSetttingsButton.TabIndex = 0;
            this.OpenSetttingsButton.UseVisualStyleBackColor = false;
            this.OpenSetttingsButton.Click += new System.EventHandler(this.OpenSetttingsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OpenSetttingsButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MainWindow";
            this.Text = "Turbo Doc Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenSetttingsButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}