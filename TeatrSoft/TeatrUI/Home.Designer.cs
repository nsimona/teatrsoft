namespace TeatrUI
{
    partial class Home
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
            this.todayLabel = new System.Windows.Forms.Label();
            this.todayField = new System.Windows.Forms.Label();
            this.tomorrowField = new System.Windows.Forms.Label();
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.pageTitle = new System.Windows.Forms.Label();
            this.todayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tomorrowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.todayLabel.Location = new System.Drawing.Point(1, 101);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(59, 22);
            this.todayLabel.TabIndex = 4;
            this.todayLabel.Text = "ДНЕС";
            // 
            // todayField
            // 
            this.todayField.AutoSize = true;
            this.todayField.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.todayField.Location = new System.Drawing.Point(1, 127);
            this.todayField.Name = "todayField";
            this.todayField.Size = new System.Drawing.Size(0, 22);
            this.todayField.TabIndex = 5;
            // 
            // tomorrowField
            // 
            this.tomorrowField.AutoSize = true;
            this.tomorrowField.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomorrowField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.tomorrowField.Location = new System.Drawing.Point(1, 409);
            this.tomorrowField.Name = "tomorrowField";
            this.tomorrowField.Size = new System.Drawing.Size(0, 22);
            this.tomorrowField.TabIndex = 7;
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.AutoSize = true;
            this.tomorrowLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomorrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.tomorrowLabel.Location = new System.Drawing.Point(1, 383);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(55, 22);
            this.tomorrowLabel.TabIndex = 6;
            this.tomorrowLabel.Text = "УТРЕ";
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 7);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(484, 29);
            this.pageTitle.TabIndex = 14;
            this.pageTitle.Text = "МАЛЪК ГРАДСКИ ТЕАТЪР \"ЗАД КАНАЛА\"";
            // 
            // todayPanel
            // 
            this.todayPanel.Location = new System.Drawing.Point(139, 99);
            this.todayPanel.Name = "todayPanel";
            this.todayPanel.Size = new System.Drawing.Size(451, 264);
            this.todayPanel.TabIndex = 0;
            // 
            // tomorrowPanel
            // 
            this.tomorrowPanel.Location = new System.Drawing.Point(140, 383);
            this.tomorrowPanel.Name = "tomorrowPanel";
            this.tomorrowPanel.Size = new System.Drawing.Size(450, 260);
            this.tomorrowPanel.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.tomorrowPanel);
            this.Controls.Add(this.todayPanel);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.tomorrowField);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.todayField);
            this.Controls.Add(this.todayLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label todayField;
        private System.Windows.Forms.Label tomorrowField;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.FlowLayoutPanel todayPanel;
        private System.Windows.Forms.FlowLayoutPanel tomorrowPanel;
    }
}