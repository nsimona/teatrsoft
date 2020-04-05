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
            this.logoLabel = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Montserrat", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.logoLabel.Location = new System.Drawing.Point(14, 64);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(316, 81);
            this.logoLabel.TabIndex = 9;
            this.logoLabel.Text = "teatr.soft";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(20, 571);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "v1.0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(452, 571);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "2020";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.logoLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.RichTextBox infoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}