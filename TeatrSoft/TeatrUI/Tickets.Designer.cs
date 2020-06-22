namespace TeatrUI
{
    partial class Tickets
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
            this.pageTitle = new System.Windows.Forms.Label();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.ticketsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 10);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(193, 52);
            this.pageTitle.TabIndex = 1;
            this.pageTitle.Text = "БИЛЕТИ";
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveToFileBtn.FlatAppearance.BorderSize = 0;
            this.saveToFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToFileBtn.Image = global::TeatrUI.Properties.Resources.save;
            this.saveToFileBtn.Location = new System.Drawing.Point(546, 20);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(30, 30);
            this.saveToFileBtn.TabIndex = 3;
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Image = global::TeatrUI.Properties.Resources.print;
            this.printBtn.Location = new System.Drawing.Point(510, 20);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(30, 30);
            this.printBtn.TabIndex = 2;
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // ticketsPanel
            // 
            this.ticketsPanel.AutoScroll = true;
            this.ticketsPanel.Location = new System.Drawing.Point(-1, 105);
            this.ticketsPanel.Name = "ticketsPanel";
            this.ticketsPanel.Size = new System.Drawing.Size(591, 534);
            this.ticketsPanel.TabIndex = 4;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.ticketsPanel);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.FlowLayoutPanel ticketsPanel;
    }
}