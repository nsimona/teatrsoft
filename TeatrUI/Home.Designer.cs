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
            this.headingLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.todayDate = new System.Windows.Forms.Label();
            this.tomorrowData = new System.Windows.Forms.Label();
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.todayPanel = new System.Windows.Forms.Panel();
            this.mainProductionItem1 = new TeatrUI.UserControls.MainProductionItem();
            this.tomorrowPanel = new System.Windows.Forms.Panel();
            this.mainProductionItem2 = new TeatrUI.UserControls.MainProductionItem();
            this.todayPanel.SuspendLayout();
            this.tomorrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.headingLabel.Location = new System.Drawing.Point(0, 10);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(484, 29);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "МАЛЪК ГРАДСКИ ТЕАТЪР \"ЗАД КАНАЛА\"";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.todayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.todayLabel.Location = new System.Drawing.Point(1, 92);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(51, 20);
            this.todayLabel.TabIndex = 4;
            this.todayLabel.Text = "ДНЕС";
            // 
            // todayDate
            // 
            this.todayDate.AutoSize = true;
            this.todayDate.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.todayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.todayDate.Location = new System.Drawing.Point(1, 115);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(84, 20);
            this.todayDate.TabIndex = 5;
            this.todayDate.Text = "12.02.2200";
            // 
            // tomorrowData
            // 
            this.tomorrowData.AutoSize = true;
            this.tomorrowData.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.tomorrowData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.tomorrowData.Location = new System.Drawing.Point(1, 395);
            this.tomorrowData.Name = "tomorrowData";
            this.tomorrowData.Size = new System.Drawing.Size(84, 20);
            this.tomorrowData.TabIndex = 7;
            this.tomorrowData.Text = "12.02.2200";
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.AutoSize = true;
            this.tomorrowLabel.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.tomorrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.tomorrowLabel.Location = new System.Drawing.Point(1, 372);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(47, 20);
            this.tomorrowLabel.TabIndex = 6;
            this.tomorrowLabel.Text = "УТРЕ";
            // 
            // todayPanel
            // 
            this.todayPanel.Controls.Add(this.mainProductionItem1);
            this.todayPanel.Location = new System.Drawing.Point(125, 90);
            this.todayPanel.Name = "todayPanel";
            this.todayPanel.Size = new System.Drawing.Size(466, 240);
            this.todayPanel.TabIndex = 9;
            // 
            // mainProductionItem1
            // 
            this.mainProductionItem1.BackColor = System.Drawing.Color.White;
            this.mainProductionItem1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainProductionItem1.Location = new System.Drawing.Point(1, 2);
            this.mainProductionItem1.Margin = new System.Windows.Forms.Padding(5);
            this.mainProductionItem1.Name = "mainProductionItem1";
            this.mainProductionItem1.Size = new System.Drawing.Size(125, 236);
            this.mainProductionItem1.TabIndex = 0;
            // 
            // tomorrowPanel
            // 
            this.tomorrowPanel.Controls.Add(this.mainProductionItem2);
            this.tomorrowPanel.Location = new System.Drawing.Point(126, 372);
            this.tomorrowPanel.Name = "tomorrowPanel";
            this.tomorrowPanel.Size = new System.Drawing.Size(465, 236);
            this.tomorrowPanel.TabIndex = 10;
            // 
            // mainProductionItem2
            // 
            this.mainProductionItem2.BackColor = System.Drawing.Color.White;
            this.mainProductionItem2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainProductionItem2.Location = new System.Drawing.Point(1, 18);
            this.mainProductionItem2.Margin = new System.Windows.Forms.Padding(5);
            this.mainProductionItem2.Name = "mainProductionItem2";
            this.mainProductionItem2.Size = new System.Drawing.Size(125, 236);
            this.mainProductionItem2.TabIndex = 1;
            this.mainProductionItem2.Load += new System.EventHandler(this.mainProductionItem2_Load);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.tomorrowPanel);
            this.Controls.Add(this.todayPanel);
            this.Controls.Add(this.tomorrowData);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "Home";
            this.todayPanel.ResumeLayout(false);
            this.tomorrowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label todayDate;
        private System.Windows.Forms.Label tomorrowData;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Panel todayPanel;
        private System.Windows.Forms.Panel tomorrowPanel;
        private UserControls.MainProductionItem mainProductionItem1;
        private UserControls.MainProductionItem mainProductionItem2;
    }
}