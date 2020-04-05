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
            this.PosterImg = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sceneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // PosterImg
            // 
            this.PosterImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PosterImg.Location = new System.Drawing.Point(7, 25);
            this.PosterImg.Name = "PosterImg";
            this.PosterImg.Size = new System.Drawing.Size(110, 140);
            this.PosterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterImg.TabIndex = 0;
            this.PosterImg.TabStop = false;
            this.PosterImg.Click += new System.EventHandler(this.PosterImg_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(3, 177);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title\r\n";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // sceneLabel
            // 
            this.sceneLabel.AutoSize = true;
            this.sceneLabel.Location = new System.Drawing.Point(3, 0);
            this.sceneLabel.Name = "sceneLabel";
            this.sceneLabel.Size = new System.Drawing.Size(60, 22);
            this.sceneLabel.TabIndex = 2;
            this.sceneLabel.Text = "Scene";
            this.sceneLabel.Click += new System.EventHandler(this.sceneLabel_Click);
            // 
            // MainProductionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sceneLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.PosterImg);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainProductionItem";
            this.Size = new System.Drawing.Size(125, 236);
            this.Load += new System.EventHandler(this.productionItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PosterImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterImg;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label sceneLabel;
    }
}
