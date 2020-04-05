namespace TeatrUI.UserControls
{
    partial class FooterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.nameLabel.Location = new System.Drawing.Point(3, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(206, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "МАЛЪК ГРАДСКИ ТЕАТЪР";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.currentTimeLabel.Location = new System.Drawing.Point(517, 9);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(100, 20);
            this.currentTimeLabel.TabIndex = 1;
            this.currentTimeLabel.Text = "21/21/20 19:14";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FooterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FooterControl";
            this.Size = new System.Drawing.Size(620, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label currentTimeLabel;
    }
}
