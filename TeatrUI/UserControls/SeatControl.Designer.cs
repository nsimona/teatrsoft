namespace TeatrUI.UserControls
{
    partial class SeatControl
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
            this.components = new System.ComponentModel.Container();
            this.seatBox = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // seatBox
            // 
            this.seatBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.seatBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seatBox.FlatAppearance.BorderSize = 0;
            this.seatBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatBox.Location = new System.Drawing.Point(0, 0);
            this.seatBox.Margin = new System.Windows.Forms.Padding(5);
            this.seatBox.Name = "seatBox";
            this.seatBox.Size = new System.Drawing.Size(18, 18);
            this.seatBox.TabIndex = 0;
            this.tooltip.SetToolTip(this.seatBox, "123");
            this.seatBox.UseVisualStyleBackColor = false;
            this.seatBox.Click += new System.EventHandler(this.seatBox_Click);
            // 
            // tooltip
            // 
            this.tooltip.ToolTipTitle = "Ред | Място";
            // 
            // SeatControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.seatBox);
            this.Name = "SeatControl";
            this.Size = new System.Drawing.Size(18, 18);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seatBox;
        private System.Windows.Forms.ToolTip tooltip;
    }
}
