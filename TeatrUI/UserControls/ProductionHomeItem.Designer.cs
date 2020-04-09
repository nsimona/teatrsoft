namespace TeatrUI.UserControls
{
    partial class ProductionHomeItem
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
            this.posterField = new System.Windows.Forms.PictureBox();
            this.titleField = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posterField)).BeginInit();
            this.SuspendLayout();
            // 
            // posterField
            // 
            this.posterField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posterField.Location = new System.Drawing.Point(7, 25);
            this.posterField.Name = "posterField";
            this.posterField.Size = new System.Drawing.Size(110, 140);
            this.posterField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterField.TabIndex = 0;
            this.posterField.TabStop = false;
            this.posterField.Click += new System.EventHandler(this.posterField_Click);
            // 
            // titleField
            // 
            this.titleField.AutoEllipsis = true;
            this.titleField.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.titleField.Location = new System.Drawing.Point(3, 168);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(114, 43);
            this.titleField.TabIndex = 1;
            this.titleField.Text = "Title\r\n1";
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Location = new System.Drawing.Point(3, 0);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(60, 22);
            this.sceneField.TabIndex = 2;
            this.sceneField.Text = "Scene";
            // 
            // timeField
            // 
            this.timeField.AutoSize = true;
            this.timeField.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.timeField.Location = new System.Drawing.Point(3, 211);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(44, 20);
            this.timeField.TabIndex = 3;
            this.timeField.Text = "19:00\r\n";
            // 
            // ProductionHomeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.posterField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductionHomeItem";
            this.Size = new System.Drawing.Size(125, 236);
            ((System.ComponentModel.ISupportInitialize)(this.posterField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox posterField;
        private System.Windows.Forms.Label titleField;
        private System.Windows.Forms.Label sceneField;
        private System.Windows.Forms.Label timeField;
    }
}
