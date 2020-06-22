namespace TeatrUI
{
    partial class Users
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
            this.createNewTitle = new System.Windows.Forms.Label();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.userCardControl2 = new TeatrUI.UserControls.UserCardControl();
            this.userCardControl1 = new TeatrUI.UserControls.UserCardControl();
            this.saveBtn = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usersPanel.SuspendLayout();
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
            this.pageTitle.Size = new System.Drawing.Size(301, 29);
            this.pageTitle.TabIndex = 14;
            this.pageTitle.Text = "АКТИВНИ ПОТРЕБИТЕЛИ";
            // 
            // createNewTitle
            // 
            this.createNewTitle.AutoSize = true;
            this.createNewTitle.BackColor = System.Drawing.Color.White;
            this.createNewTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.createNewTitle.Location = new System.Drawing.Point(-1, 306);
            this.createNewTitle.Name = "createNewTitle";
            this.createNewTitle.Size = new System.Drawing.Size(415, 29);
            this.createNewTitle.TabIndex = 17;
            this.createNewTitle.Text = "СЪЗДАВАНЕ НА НОВ ПОТРЕБИТЕЛ";
            // 
            // usersPanel
            // 
            this.usersPanel.Controls.Add(this.userCardControl2);
            this.usersPanel.Controls.Add(this.userCardControl1);
            this.usersPanel.Location = new System.Drawing.Point(-1, 61);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(593, 242);
            this.usersPanel.TabIndex = 18;
            // 
            // userCardControl2
            // 
            this.userCardControl2.BackColor = System.Drawing.Color.White;
            this.userCardControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardControl2.Location = new System.Drawing.Point(303, 0);
            this.userCardControl2.Margin = new System.Windows.Forms.Padding(5);
            this.userCardControl2.Name = "userCardControl2";
            this.userCardControl2.Size = new System.Drawing.Size(288, 125);
            this.userCardControl2.TabIndex = 18;
            // 
            // userCardControl1
            // 
            this.userCardControl1.BackColor = System.Drawing.Color.White;
            this.userCardControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardControl1.Location = new System.Drawing.Point(5, 0);
            this.userCardControl1.Margin = new System.Windows.Forms.Padding(5);
            this.userCardControl1.Name = "userCardControl1";
            this.userCardControl1.Size = new System.Drawing.Size(288, 125);
            this.userCardControl1.TabIndex = 17;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(0, 598);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 46;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.White;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(0, 558);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(300, 30);
            this.categoryComboBox.TabIndex = 45;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(0, 497);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(300, 27);
            this.passTextBox.TabIndex = 44;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(0, 436);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(300, 27);
            this.mailTextBox.TabIndex = 43;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(0, 375);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 27);
            this.nameTextBox.TabIndex = 42;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.passLabel.Location = new System.Drawing.Point(0, 469);
            this.passLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(72, 22);
            this.passLabel.TabIndex = 38;
            this.passLabel.Text = "Парола";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mailLabel.Location = new System.Drawing.Point(0, 408);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(3);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(67, 22);
            this.mailLabel.TabIndex = 37;
            this.mailLabel.Text = "Имейл";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.categoryLabel.Location = new System.Drawing.Point(0, 530);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(98, 22);
            this.categoryLabel.TabIndex = 36;
            this.categoryLabel.Text = "Категория";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.nameLabel.Location = new System.Drawing.Point(0, 347);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 22);
            this.nameLabel.TabIndex = 35;
            this.nameLabel.Text = "Име";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createNewTitle);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.usersPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.usersPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label createNewTitle;
        private System.Windows.Forms.Panel usersPanel;
        private UserControls.UserCardControl userCardControl2;
        private UserControls.UserCardControl userCardControl1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}