namespace TeatrUI.UserControls
{
    partial class ProductionDateTicketControl
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.Label();
            this.ticketsBtn = new System.Windows.Forms.Button();
            this.minusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(3, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "24.02.20";
            // 
            // timeField
            // 
            this.timeField.AutoSize = true;
            this.timeField.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeField.Location = new System.Drawing.Point(81, 4);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(50, 21);
            this.timeField.TabIndex = 1;
            this.timeField.Text = "24:30";
            // 
            // ticketsBtn
            // 
            this.ticketsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.ticketsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketsBtn.FlatAppearance.BorderSize = 0;
            this.ticketsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsBtn.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketsBtn.ForeColor = System.Drawing.Color.White;
            this.ticketsBtn.Location = new System.Drawing.Point(130, 0);
            this.ticketsBtn.Name = "ticketsBtn";
            this.ticketsBtn.Size = new System.Drawing.Size(85, 29);
            this.ticketsBtn.TabIndex = 2;
            this.ticketsBtn.Text = "БИЛЕТИ";
            this.ticketsBtn.UseVisualStyleBackColor = false;
            this.ticketsBtn.Click += new System.EventHandler(this.ticketsBtn_Click);
            // 
            // minusLabel
            // 
            this.minusLabel.AutoSize = true;
            this.minusLabel.BackColor = System.Drawing.Color.Transparent;
            this.minusLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusLabel.Location = new System.Drawing.Point(72, 4);
            this.minusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(16, 21);
            this.minusLabel.TabIndex = 0;
            this.minusLabel.Text = "-";
            // 
            // ProductionDateTicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ticketsBtn);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.minusLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductionDateTicketControl";
            this.Size = new System.Drawing.Size(218, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeField;
        private System.Windows.Forms.Button ticketsBtn;
        private System.Windows.Forms.Label minusLabel;
    }
}
