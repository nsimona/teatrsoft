namespace TeatrUI
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.logo = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.RichTextBox();
            this.version = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Montserrat", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.logo.Location = new System.Drawing.Point(14, 64);
            this.logo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(316, 81);
            this.logo.TabIndex = 9;
            this.logo.Text = "teatr.soft";
            this.logo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.Color.White;
            this.infoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoText.Font = new System.Drawing.Font("Montserrat", 8.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoText.Location = new System.Drawing.Point(28, 161);
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(534, 394);
            this.infoText.TabIndex = 10;
            this.infoText.Text = resources.GetString("infoText.Text");
            this.infoText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.version.Location = new System.Drawing.Point(20, 571);
            this.version.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(122, 48);
            this.version.TabIndex = 11;
            this.version.Text = "v1.0.0";
            this.version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.year.Location = new System.Drawing.Point(452, 571);
            this.year.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(110, 48);
            this.year.TabIndex = 12;
            this.year.Text = "2020";
            this.year.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.year);
            this.Controls.Add(this.version);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.RichTextBox infoText;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label year;
    }
}