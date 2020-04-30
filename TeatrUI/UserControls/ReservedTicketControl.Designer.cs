namespace TeatrUI.UserControls
{
    partial class ReservedTicketControl
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
            this.seatField = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seatField
            // 
            this.seatField.AutoSize = true;
            this.seatField.BackColor = System.Drawing.Color.Transparent;
            this.seatField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.seatField.Location = new System.Drawing.Point(1, 1);
            this.seatField.Name = "seatField";
            this.seatField.Size = new System.Drawing.Size(32, 22);
            this.seatField.TabIndex = 1;
            this.seatField.Text = "С8";
            // 
            // priceField
            // 
            this.priceField.BackColor = System.Drawing.Color.Transparent;
            this.priceField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.priceField.Location = new System.Drawing.Point(186, 2);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(71, 22);
            this.priceField.TabIndex = 2;
            this.priceField.Text = "12.00";
            this.priceField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReservedTicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.seatField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReservedTicketControl";
            this.Size = new System.Drawing.Size(264, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label seatField;
        private System.Windows.Forms.Label priceField;
    }
}
