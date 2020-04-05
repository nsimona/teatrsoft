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
            this.headingLabel = new System.Windows.Forms.Label();
            this.editPhotoBtn = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.newPassRepeat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.White;
            this.headingLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.headingLabel.Location = new System.Drawing.Point(0, 10);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(117, 29);
            this.headingLabel.TabIndex = 16;
            this.headingLabel.Text = "ПРОФИЛ";
            // 
            // editPhotoBtn
            // 
            this.editPhotoBtn.FlatAppearance.BorderSize = 0;
            this.editPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPhotoBtn.Image = global::TeatrUI.Properties.Resources.edituser;
            this.editPhotoBtn.Location = new System.Drawing.Point(88, 177);
            this.editPhotoBtn.Name = "editPhotoBtn";
            this.editPhotoBtn.Size = new System.Drawing.Size(42, 40);
            this.editPhotoBtn.TabIndex = 86;
            this.editPhotoBtn.UseVisualStyleBackColor = true;
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(0, 90);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(130, 130);
            this.profilePic.TabIndex = 17;
            this.profilePic.TabStop = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(177, 118);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(300, 27);
            this.name.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(172, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Имейл";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(173, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 87;
            this.label4.Text = "Име";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(177, 177);
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Size = new System.Drawing.Size(300, 27);
            this.mail.TabIndex = 91;
            // 
            // newPassRepeat
            // 
            this.newPassRepeat.Location = new System.Drawing.Point(176, 299);
            this.newPassRepeat.Name = "newPassRepeat";
            this.newPassRepeat.Size = new System.Drawing.Size(300, 27);
            this.newPassRepeat.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(173, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Повтори нова парола";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
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
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(176, 238);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(300, 27);
            this.newPass.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(172, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "Нова парола";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.newPassRepeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editPhotoBtn);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button editPhotoBtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox newPassRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label5;
    }
}