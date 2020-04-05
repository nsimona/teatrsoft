namespace TeatrUI.UserControls
{
    partial class MainProductionItem
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
            this.PosterField = new System.Windows.Forms.PictureBox();
            this.titleField = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosterField)).BeginInit();
            this.SuspendLayout();
            // 
            // PosterField
            // 
            this.PosterField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PosterField.Location = new System.Drawing.Point(7, 25);
            this.PosterField.Name = "PosterField";
            this.PosterField.Size = new System.Drawing.Size(110, 140);
            this.PosterField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterField.TabIndex = 0;
            this.PosterField.TabStop = false;
            this.PosterField.Click += new System.EventHandler(this.PosterImg_Click);
            // 
            // titleField
            // 
            this.titleField.AutoSize = true;
            this.titleField.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.titleField.Location = new System.Drawing.Point(3, 177);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(34, 16);
            this.titleField.TabIndex = 1;
            this.titleField.Text = "Title\r\n";
            this.titleField.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Location = new System.Drawing.Point(3, 0);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(55, 22);
            this.sceneField.TabIndex = 2;
            this.sceneField.Text = "Scene";
            this.sceneField.Click += new System.EventHandler(this.sceneLabel_Click);
            // 
            // MainProductionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.PosterField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainProductionItem";
            this.Size = new System.Drawing.Size(125, 236);
            this.Load += new System.EventHandler(this.productionItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosterField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterField;
        private System.Windows.Forms.Label titleField;
        private System.Windows.Forms.Label sceneField;
    }
}
