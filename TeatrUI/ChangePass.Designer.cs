namespace TeatrUI.UserControls
{
    partial class ChangePass
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
            this.userCardControl1 = new TeatrUI.UserControls.UserCardControl();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.newPassRepeatTextBox = new System.Windows.Forms.TextBox();
            this.repeatPassLabel = new System.Windows.Forms.Label();
            this.backButtonControl1 = new TeatrUI.UserControls.BackButtonControl();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.White;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 75);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(246, 24);
            this.pageTitle.TabIndex = 15;
            this.pageTitle.Text = "ПРОМЯНА НА ПАРОЛА";
            // 
            // userCardControl1
            // 
            this.userCardControl1.BackColor = System.Drawing.Color.White;
            this.userCardControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardControl1.Location = new System.Drawing.Point(5, 121);
            this.userCardControl1.Margin = new System.Windows.Forms.Padding(5);
            this.userCardControl1.Name = "userCardControl1";
            this.userCardControl1.Size = new System.Drawing.Size(288, 125);
            this.userCardControl1.TabIndex = 16;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(0, 407);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 49;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(0, 295);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(300, 27);
            this.newPassTextBox.TabIndex = 48;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.newPassLabel.Location = new System.Drawing.Point(1, 267);
            this.newPassLabel.Margin = new System.Windows.Forms.Padding(3);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(102, 18);
            this.newPassLabel.TabIndex = 47;
            this.newPassLabel.Text = "Нова парола";
            // 
            // newPassRepeatTextBox
            // 
            this.newPassRepeatTextBox.Location = new System.Drawing.Point(0, 358);
            this.newPassRepeatTextBox.Name = "newPassRepeatTextBox";
            this.newPassRepeatTextBox.Size = new System.Drawing.Size(300, 27);
            this.newPassRepeatTextBox.TabIndex = 51;
            // 
            // repeatPassLabel
            // 
            this.repeatPassLabel.AutoSize = true;
            this.repeatPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.repeatPassLabel.Location = new System.Drawing.Point(1, 330);
            this.repeatPassLabel.Margin = new System.Windows.Forms.Padding(3);
            this.repeatPassLabel.Name = "repeatPassLabel";
            this.repeatPassLabel.Size = new System.Drawing.Size(165, 18);
            this.repeatPassLabel.TabIndex = 50;
            this.repeatPassLabel.Text = "Повтори нова парола";
            // 
            // backButtonControl1
            // 
            this.backButtonControl1.BackColor = System.Drawing.Color.White;
            this.backButtonControl1.Location = new System.Drawing.Point(0, 10);
            this.backButtonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButtonControl1.Name = "backButtonControl1";
            this.backButtonControl1.Size = new System.Drawing.Size(135, 36);
            this.backButtonControl1.TabIndex = 52;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.backButtonControl1);
            this.Controls.Add(this.newPassRepeatTextBox);
            this.Controls.Add(this.repeatPassLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.userCardControl1);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private UserCardControl userCardControl1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.TextBox newPassRepeatTextBox;
        private System.Windows.Forms.Label repeatPassLabel;
        private BackButtonControl backButtonControl1;
    }
}