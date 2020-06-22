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
            this.photoField = new System.Windows.Forms.PictureBox();
            this.roleField = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.Label();
            this.changePassBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).BeginInit();
            this.SuspendLayout();
            // 
            // photoField
            // 
            this.photoField.Location = new System.Drawing.Point(6, 20);
            this.photoField.Name = "photoField";
            this.photoField.Size = new System.Drawing.Size(85, 85);
            this.photoField.TabIndex = 0;
            this.photoField.TabStop = false;
            // 
            // roleField
            // 
            this.roleField.AutoSize = true;
            this.roleField.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.roleField.Location = new System.Drawing.Point(111, 42);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(65, 21);
            this.roleField.TabIndex = 9;
            this.roleField.Text = "касиер";
            // 
            // nameField
            // 
            this.nameField.AutoEllipsis = true;
            this.nameField.AutoSize = true;
            this.nameField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(112, 24);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(137, 18);
            this.nameField.TabIndex = 8;
            this.nameField.Text = "ИВАНА ИВАНОВА";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.changePassBtn.Location = new System.Drawing.Point(109, 79);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(135, 26);
            this.changePassBtn.TabIndex = 10;
            this.changePassBtn.Text = "промени парола";
            this.changePassBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // UserCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.photoField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserCardControl";
            this.Size = new System.Drawing.Size(288, 125);
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoField;
        private System.Windows.Forms.Label roleField;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Button changePassBtn;
    }
}
