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
            this.headingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.userCardControl2 = new TeatrUI.UserControls.UserCardControl();
            this.userCardControl1 = new TeatrUI.UserControls.UserCardControl();
            this.saveBtn = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersPanel.SuspendLayout();
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
            this.headingLabel.Size = new System.Drawing.Size(301, 29);
            this.headingLabel.TabIndex = 14;
            this.headingLabel.Text = "АКТИВНИ ПОТРЕБИТЕЛИ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(-1, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "СЪЗДАВАНЕ НА НОВ ПОТРЕБИТЕЛ";
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
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(-2, 598);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 46;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.White;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(0, 558);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(300, 30);
            this.category.TabIndex = 45;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(0, 497);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(300, 27);
            this.pass.TabIndex = 44;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(0, 436);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(300, 27);
            this.mail.TabIndex = 43;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(0, 375);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(300, 27);
            this.name.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(0, 469);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Парола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(0, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Имейл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(0, 530);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(0, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Име";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.category);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.usersPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Users";
            this.Text = "Users";
            this.usersPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel usersPanel;
        private UserControls.UserCardControl userCardControl2;
        private UserControls.UserCardControl userCardControl1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}