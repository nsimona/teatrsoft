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
            this.placeLabel = new System.Windows.Forms.Label();
            this.seatField = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.BackColor = System.Drawing.Color.Transparent;
            this.placeLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.placeLabel.Location = new System.Drawing.Point(7, 4);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(65, 22);
            this.placeLabel.TabIndex = 0;
            this.placeLabel.Text = "Място:";
            // 
            // seatField
            // 
            this.seatField.AutoSize = true;
            this.seatField.BackColor = System.Drawing.Color.Transparent;
            this.seatField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.seatField.Location = new System.Drawing.Point(7, 28);
            this.seatField.Name = "seatField";
            this.seatField.Size = new System.Drawing.Size(31, 22);
            this.seatField.TabIndex = 1;
            this.seatField.Text = "С8";
            // 
            // priceField
            // 
            this.priceField.AutoSize = true;
            this.priceField.BackColor = System.Drawing.Color.Transparent;
            this.priceField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.priceField.Location = new System.Drawing.Point(206, 28);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(70, 22);
            this.priceField.TabIndex = 2;
            this.priceField.Text = "12,00лв";
            // 
            // ReservedTicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.seatField);
            this.Controls.Add(this.placeLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ReservedTicketControl";
            this.Size = new System.Drawing.Size(280, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label seatField;
        private System.Windows.Forms.Label priceField;
    }
}
