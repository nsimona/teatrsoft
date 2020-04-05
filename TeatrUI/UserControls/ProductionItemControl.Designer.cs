namespace TeatrUI.UserControls
{
    partial class ProductionItemControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.directorNameLabel = new System.Windows.Forms.Label();
            this.PosterImg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PosterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(121, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(62, 22);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Зорба";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.durationLabel.Location = new System.Drawing.Point(121, 122);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(62, 21);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "96 min";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(122, 87);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(49, 16);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Автор:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorLabel.Location = new System.Drawing.Point(122, 104);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(75, 16);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Режисьор:";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorNameLabel.Location = new System.Drawing.Point(169, 87);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(98, 16);
            this.authorNameLabel.TabIndex = 7;
            this.authorNameLabel.Text = "Кирил Иванов";
            // 
            // directorNameLabel
            // 
            this.directorNameLabel.AutoSize = true;
            this.directorNameLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorNameLabel.Location = new System.Drawing.Point(196, 104);
            this.directorNameLabel.Name = "directorNameLabel";
            this.directorNameLabel.Size = new System.Drawing.Size(90, 16);
            this.directorNameLabel.TabIndex = 8;
            this.directorNameLabel.Text = "Иван Иванов";
            // 
            // PosterImg
            // 
            this.PosterImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PosterImg.Location = new System.Drawing.Point(3, 3);
            this.PosterImg.Name = "PosterImg";
            this.PosterImg.Size = new System.Drawing.Size(110, 140);
            this.PosterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterImg.TabIndex = 1;
            this.PosterImg.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TeatrUI.Properties.Resources.editPerson;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ProductionItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.directorNameLabel);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.PosterImg);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionItemControl";
            this.Size = new System.Drawing.Size(338, 150);
            ((System.ComponentModel.ISupportInitialize)(this.PosterImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterImg;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label directorNameLabel;
        private System.Windows.Forms.Button button1;
    }
}
