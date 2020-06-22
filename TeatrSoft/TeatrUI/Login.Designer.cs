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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.Label();
            this.teatrSoftLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.mailField = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.errorInfo = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::TeatrUI.Properties.Resources.bg;
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Controls.Add(this.description);
            this.sidePanel.Controls.Add(this.teatrSoftLabel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(340, 636);
            this.sidePanel.TabIndex = 0;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(23, 319);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(294, 71);
            this.description.TabIndex = 11;
            this.description.Text = "свободен софтуер за театър,\r\nпродажба на билети \r\nи още много\r\n";
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
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.mailLabel.Location = new System.Drawing.Point(388, 297);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(67, 22);
            this.mailLabel.TabIndex = 13;
            this.mailLabel.Text = "Имейл";
            this.mailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(392, 458);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(123, 38);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "ВХОД";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
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
            // mailField
            // 
            this.mailField.BackColor = System.Drawing.Color.White;
            this.mailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.mailField.Location = new System.Drawing.Point(392, 322);
            this.mailField.MaxLength = 200;
            this.mailField.Multiline = true;
            this.mailField.Name = "mailField";
            this.mailField.Size = new System.Drawing.Size(408, 30);
            this.mailField.TabIndex = 10;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.Transparent;
            this.customerName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.customerName.Location = new System.Drawing.Point(547, 206);
            this.customerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(192, 18);
            this.customerName.TabIndex = 9;
            this.customerName.Text = "МАЛЪК ГРАДСКИ ТЕАТЪР";
            this.customerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Montserrat", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(180)))));
            this.logo.Location = new System.Drawing.Point(438, 125);
            this.logo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(316, 81);
            this.logo.TabIndex = 8;
            this.logo.Text = "teatr.soft";
            this.logo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorInfo
            // 
            this.errorInfo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.errorInfo.Location = new System.Drawing.Point(388, 514);
            this.errorInfo.Name = "errorInfo";
            this.errorInfo.Size = new System.Drawing.Size(412, 85);
            this.errorInfo.TabIndex = 81;
            this.errorInfo.Text = "Грешен имейл или парола\r\n\r\nЗабраввена парола? \r\nСвържете се с Вашия администратор" +
    "";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.errorInfo);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.mailField);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label teatrSoftLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox mailField;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label errorInfo;
    }
}