namespace TeatrUI.UserControls
{
    partial class ExportItemControl
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
            this.dateField = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            this.seatsField = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dateField
            // 
            this.dateField.AutoEllipsis = true;
            this.dateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dateField.Location = new System.Drawing.Point(3, 6);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(96, 50);
            this.dateField.TabIndex = 99;
            this.dateField.Text = "01.03.20 19:00";
            // 
            // nameField
            // 
            this.nameField.AutoEllipsis = true;
            this.nameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.nameField.Location = new System.Drawing.Point(118, 6);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(151, 50);
            this.nameField.TabIndex = 100;
            this.nameField.Text = "Ромео и Жулиета и Ромео и Жулиета";
            // 
            // sceneField
            // 
            this.sceneField.AutoEllipsis = true;
            this.sceneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sceneField.Location = new System.Drawing.Point(287, 6);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(109, 50);
            this.sceneField.TabIndex = 101;
            this.sceneField.Text = "Голяма сцена";
            // 
            // seatsField
            // 
            this.seatsField.AutoEllipsis = true;
            this.seatsField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.seatsField.Location = new System.Drawing.Point(413, 6);
            this.seatsField.Name = "seatsField";
            this.seatsField.Size = new System.Drawing.Size(88, 50);
            this.seatsField.TabIndex = 102;
            this.seatsField.Text = "250/800";
            // 
            // totalField
            // 
            this.totalField.AutoEllipsis = true;
            this.totalField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.totalField.Location = new System.Drawing.Point(497, 6);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(83, 50);
            this.totalField.TabIndex = 103;
            this.totalField.Text = "10,000";
            this.totalField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 2);
            this.panel1.TabIndex = 104;
            // 
            // ExportItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.seatsField);
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.dateField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExportItemControl";
            this.Size = new System.Drawing.Size(580, 63);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Label sceneField;
        private System.Windows.Forms.Label seatsField;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.Panel panel1;
    }
}
