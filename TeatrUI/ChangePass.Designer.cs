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
            this.headingLabel = new System.Windows.Forms.Label();
            this.userCardControl1 = new TeatrUI.UserControls.UserCardControl();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPassRepeat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.White;
            this.headingLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.headingLabel.Location = new System.Drawing.Point(0, 40);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(279, 29);
            this.headingLabel.TabIndex = 15;
            this.headingLabel.Text = "ПРОМЯНА НА ПАРОЛА";
            // 
            // userCardControl1
            // 
            this.userCardControl1.BackColor = System.Drawing.Color.White;
            this.userCardControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardControl1.Location = new System.Drawing.Point(5, 86);
            this.userCardControl1.Margin = new System.Windows.Forms.Padding(5);
            this.userCardControl1.Name = "userCardControl1";
            this.userCardControl1.Size = new System.Drawing.Size(288, 125);
            this.userCardControl1.TabIndex = 16;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(0, 377);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 49;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(0, 265);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(300, 27);
            this.newPass.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(1, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Нова парола";
            // 
            // newPassRepeat
            // 
            this.newPassRepeat.Location = new System.Drawing.Point(0, 328);
            this.newPassRepeat.Name = "newPassRepeat";
            this.newPassRepeat.Size = new System.Drawing.Size(300, 27);
            this.newPassRepeat.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(1, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Повтори нова парола";
            // 
            // ChangePass
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
            this.Controls.Add(this.userCardControl1);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private UserCardControl userCardControl1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassRepeat;
        private System.Windows.Forms.Label label1;
    }
}