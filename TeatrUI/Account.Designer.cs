namespace TeatrUI
{
    partial class Account
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageTitle = new System.Windows.Forms.Label();
            this.editPhotoBtn = new System.Windows.Forms.Button();
            this.photoField = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.newPassRepeatTextBox = new System.Windows.Forms.TextBox();
            this.repeatNewPassLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.White;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 10);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(117, 29);
            this.pageTitle.TabIndex = 16;
            this.pageTitle.Text = "ПРОФИЛ";
            // 
            // editPhotoBtn
            // 
            this.editPhotoBtn.BackColor = System.Drawing.Color.Transparent;
            this.editPhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPhotoBtn.FlatAppearance.BorderSize = 0;
            this.editPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPhotoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editPhotoBtn.Image = global::TeatrUI.Properties.Resources.edituser;
            this.editPhotoBtn.Location = new System.Drawing.Point(88, 180);
            this.editPhotoBtn.Name = "editPhotoBtn";
            this.editPhotoBtn.Size = new System.Drawing.Size(42, 40);
            this.editPhotoBtn.TabIndex = 86;
            this.editPhotoBtn.UseVisualStyleBackColor = false;
            this.editPhotoBtn.Click += new System.EventHandler(this.editPhotoBtn_Click);
            // 
            // photoField
            // 
            this.photoField.BackColor = System.Drawing.Color.Silver;
            this.photoField.Location = new System.Drawing.Point(0, 90);
            this.photoField.Name = "photoField";
            this.photoField.Size = new System.Drawing.Size(130, 130);
            this.photoField.TabIndex = 17;
            this.photoField.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(177, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 27);
            this.nameTextBox.TabIndex = 89;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mailLabel.Location = new System.Drawing.Point(172, 151);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(3);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(67, 22);
            this.mailLabel.TabIndex = 88;
            this.mailLabel.Text = "Имейл";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.nameLabel.Location = new System.Drawing.Point(173, 90);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 22);
            this.nameLabel.TabIndex = 87;
            this.nameLabel.Text = "Име";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(177, 177);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.ReadOnly = true;
            this.mailTextBox.Size = new System.Drawing.Size(300, 27);
            this.mailTextBox.TabIndex = 91;
            // 
            // newPassRepeatTextBox
            // 
            this.newPassRepeatTextBox.Location = new System.Drawing.Point(176, 299);
            this.newPassRepeatTextBox.Name = "newPassRepeatTextBox";
            this.newPassRepeatTextBox.Size = new System.Drawing.Size(300, 27);
            this.newPassRepeatTextBox.TabIndex = 96;
            // 
            // repeatNewPassLabel
            // 
            this.repeatNewPassLabel.AutoSize = true;
            this.repeatNewPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.repeatNewPassLabel.Location = new System.Drawing.Point(173, 271);
            this.repeatNewPassLabel.Margin = new System.Windows.Forms.Padding(3);
            this.repeatNewPassLabel.Name = "repeatNewPassLabel";
            this.repeatNewPassLabel.Size = new System.Drawing.Size(191, 22);
            this.repeatNewPassLabel.TabIndex = 95;
            this.repeatNewPassLabel.Text = "Повтори нова парола";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(176, 353);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 94;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(176, 238);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(300, 27);
            this.newPassTextBox.TabIndex = 93;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.newPassLabel.Location = new System.Drawing.Point(172, 210);
            this.newPassLabel.Margin = new System.Windows.Forms.Padding(3);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(116, 22);
            this.newPassLabel.TabIndex = 92;
            this.newPassLabel.Text = "Нова парола";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.newPassRepeatTextBox);
            this.Controls.Add(this.repeatNewPassLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.editPhotoBtn);
            this.Controls.Add(this.photoField);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.PictureBox photoField;
        private System.Windows.Forms.Button editPhotoBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox newPassRepeatTextBox;
        private System.Windows.Forms.Label repeatNewPassLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label newPassLabel;
    }
}