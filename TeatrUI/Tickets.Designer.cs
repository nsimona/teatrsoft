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
            this.dateLabel = new System.Windows.Forms.Label();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.ticketControl1 = new TeatrUI.UserControls.TicketControl();
            this.ticketControl2 = new TeatrUI.UserControls.TicketControl();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Montserrat", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.dateLabel.Location = new System.Drawing.Point(0, 10);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(193, 52);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "БИЛЕТИ";
            // 
            // saveToFileBtn
            // 
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
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Image = global::TeatrUI.Properties.Resources.print;
            this.printBtn.Location = new System.Drawing.Point(510, 20);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(30, 30);
            this.printBtn.TabIndex = 2;
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // ticketControl1
            // 
            this.ticketControl1.BackColor = System.Drawing.Color.White;
            this.ticketControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketControl1.Location = new System.Drawing.Point(0, 90);
            this.ticketControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ticketControl1.Name = "ticketControl1";
            this.ticketControl1.Size = new System.Drawing.Size(590, 230);
            this.ticketControl1.TabIndex = 4;
            // 
            // ticketControl2
            // 
            this.ticketControl2.BackColor = System.Drawing.Color.White;
            this.ticketControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketControl2.Location = new System.Drawing.Point(0, 320);
            this.ticketControl2.Margin = new System.Windows.Forms.Padding(5);
            this.ticketControl2.Name = "ticketControl2";
            this.ticketControl2.Size = new System.Drawing.Size(590, 230);
            this.ticketControl2.TabIndex = 5;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.ticketControl2);
            this.Controls.Add(this.ticketControl1);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private UserControls.TicketControl ticketControl1;
        private UserControls.TicketControl ticketControl2;
    }
}