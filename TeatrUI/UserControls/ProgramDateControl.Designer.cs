namespace TeatrUI.UserControls
{
    partial class ProgramDateControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 44);
            this.panel1.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.dateLabel.Location = new System.Drawing.Point(21, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(98, 22);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "03.03.2020";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.dayLabel.Location = new System.Drawing.Point(21, 22);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(84, 22);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "Вторник";
            this.dayLabel.Click += new System.EventHandler(this.dayLabel_Click);
            // 
            // ProgramDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProgramDateControl";
            this.Size = new System.Drawing.Size(211, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dayLabel;
    }
}
