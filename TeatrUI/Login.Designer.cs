namespace TeatrUI
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descrLabel = new System.Windows.Forms.Label();
            this.teatrSoftLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.teatherNameLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TeatrUI.Properties.Resources.bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.descrLabel);
            this.panel1.Controls.Add(this.teatrSoftLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 636);
            this.panel1.TabIndex = 0;
            // 
            // descrLabel
            // 
            this.descrLabel.BackColor = System.Drawing.Color.Transparent;
            this.descrLabel.ForeColor = System.Drawing.Color.White;
            this.descrLabel.Location = new System.Drawing.Point(23, 319);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(294, 71);
            this.descrLabel.TabIndex = 11;
            this.descrLabel.Text = "свободен софтуер за театър,\r\nпродажба на билети \r\nи още много\r\n";
            // 
            // teatrSoftLabel
            // 
            this.teatrSoftLabel.AutoSize = true;
            this.teatrSoftLabel.BackColor = System.Drawing.Color.Transparent;
            this.teatrSoftLabel.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teatrSoftLabel.ForeColor = System.Drawing.Color.White;
            this.teatrSoftLabel.Location = new System.Drawing.Point(19, 260);
            this.teatrSoftLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teatrSoftLabel.Name = "teatrSoftLabel";
            this.teatrSoftLabel.Size = new System.Drawing.Size(187, 48);
            this.teatrSoftLabel.TabIndex = 10;
            this.teatrSoftLabel.Text = "teatr.soft";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.passLabel.Location = new System.Drawing.Point(388, 375);
            this.passLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(72, 22);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Парола";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.emailLabel.Location = new System.Drawing.Point(388, 297);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 22);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Имейл";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(392, 458);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(123, 38);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "ВХОД";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.White;
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.passField.Location = new System.Drawing.Point(392, 400);
            this.passField.MaxLength = 200;
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.PasswordChar = '·';
            this.passField.Size = new System.Drawing.Size(408, 30);
            this.passField.TabIndex = 11;
            this.passField.Text = "Парола";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.White;
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.usernameField.Location = new System.Drawing.Point(392, 322);
            this.usernameField.MaxLength = 200;
            this.usernameField.Multiline = true;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(408, 30);
            this.usernameField.TabIndex = 10;
            // 
            // teatherNameLabel
            // 
            this.teatherNameLabel.AutoSize = true;
            this.teatherNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.teatherNameLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teatherNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.teatherNameLabel.Location = new System.Drawing.Point(547, 206);
            this.teatherNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teatherNameLabel.Name = "teatherNameLabel";
            this.teatherNameLabel.Size = new System.Drawing.Size(192, 18);
            this.teatherNameLabel.TabIndex = 9;
            this.teatherNameLabel.Text = "МАЛЪК ГРАДСКИ ТЕАТЪР";
            this.teatherNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Montserrat", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.logoLabel.Location = new System.Drawing.Point(438, 125);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(316, 81);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "teatr.soft";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.teatherNameLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.Label teatrSoftLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label teatherNameLabel;
        private System.Windows.Forms.Label logoLabel;
    }
}