namespace TeatrUI.UserControls
{
    partial class PersonItemControl
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.personPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.personPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(10, 180);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 45);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Анастасия Лютова";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(10, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "актьор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TeatrUI.Properties.Resources.editPerson;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 66;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // personPic
            // 
            this.personPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personPic.Location = new System.Drawing.Point(10, 11);
            this.personPic.Name = "personPic";
            this.personPic.Size = new System.Drawing.Size(125, 160);
            this.personPic.TabIndex = 0;
            this.personPic.TabStop = false;
            // 
            // PersonItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.personPic);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonItemControl";
            this.Size = new System.Drawing.Size(147, 254);
            ((System.ComponentModel.ISupportInitialize)(this.personPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox personPic;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
