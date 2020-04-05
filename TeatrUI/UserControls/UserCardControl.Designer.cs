namespace TeatrUI.UserControls
{
    partial class UserCardControl
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
            this.userPic = new System.Windows.Forms.PictureBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // userPic
            // 
            this.userPic.Location = new System.Drawing.Point(6, 20);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(85, 85);
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.roleLabel.Location = new System.Drawing.Point(111, 42);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(65, 21);
            this.roleLabel.TabIndex = 9;
            this.roleLabel.Text = "касиер";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(112, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 18);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "ИВАНА ИВАНОВА";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.button1.Location = new System.Drawing.Point(109, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "промени парола";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userPic);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserCardControl";
            this.Size = new System.Drawing.Size(288, 125);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button button1;
    }
}
