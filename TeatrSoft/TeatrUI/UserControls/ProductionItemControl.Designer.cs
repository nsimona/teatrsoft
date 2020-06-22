namespace TeatrUI.UserControls
{
    partial class ProductionItemControl
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
            this.titleField = new System.Windows.Forms.Label();
            this.durationField = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.Label();
            this.directorField = new System.Windows.Forms.Label();
            this.posterField = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.activateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posterField)).BeginInit();
            this.SuspendLayout();
            // 
            // titleField
            // 
            this.titleField.AutoEllipsis = true;
            this.titleField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleField.Location = new System.Drawing.Point(121, 3);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(214, 73);
            this.titleField.TabIndex = 2;
            this.titleField.Text = "Зорба";
            // 
            // durationField
            // 
            this.durationField.AutoSize = true;
            this.durationField.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.durationField.Location = new System.Drawing.Point(121, 122);
            this.durationField.Name = "durationField";
            this.durationField.Size = new System.Drawing.Size(62, 21);
            this.durationField.TabIndex = 3;
            this.durationField.Text = "96 min";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(122, 87);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(49, 16);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Автор:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorLabel.Location = new System.Drawing.Point(122, 104);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(75, 16);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Режисьор:";
            // 
            // authorField
            // 
            this.authorField.AutoEllipsis = true;
            this.authorField.AutoSize = true;
            this.authorField.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorField.Location = new System.Drawing.Point(169, 87);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(98, 16);
            this.authorField.TabIndex = 7;
            this.authorField.Text = "Кирил Иванов";
            // 
            // directorField
            // 
            this.directorField.AutoSize = true;
            this.directorField.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorField.Location = new System.Drawing.Point(196, 104);
            this.directorField.Name = "directorField";
            this.directorField.Size = new System.Drawing.Size(90, 16);
            this.directorField.TabIndex = 8;
            this.directorField.Text = "Иван Иванов";
            // 
            // posterField
            // 
            this.posterField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posterField.Location = new System.Drawing.Point(3, 3);
            this.posterField.Name = "posterField";
            this.posterField.Size = new System.Drawing.Size(110, 140);
            this.posterField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterField.TabIndex = 1;
            this.posterField.TabStop = false;
            this.posterField.Click += new System.EventHandler(this.posterField_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Image = global::TeatrUI.Properties.Resources.editPerson;
            this.editBtn.Location = new System.Drawing.Point(78, 108);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(30, 30);
            this.editBtn.TabIndex = 67;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // activateBtn
            // 
            this.activateBtn.BackColor = System.Drawing.Color.Transparent;
            this.activateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateBtn.FlatAppearance.BorderSize = 0;
            this.activateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.activateBtn.Image = global::TeatrUI.Properties.Resources.add1;
            this.activateBtn.Location = new System.Drawing.Point(78, 108);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(30, 30);
            this.activateBtn.TabIndex = 68;
            this.activateBtn.UseVisualStyleBackColor = false;
            this.activateBtn.Visible = false;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // ProductionItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.directorField);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.durationField);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.posterField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.Name = "ProductionItemControl";
            this.Size = new System.Drawing.Size(338, 150);
            ((System.ComponentModel.ISupportInitialize)(this.posterField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox posterField;
        private System.Windows.Forms.Label titleField;
        private System.Windows.Forms.Label durationField;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label authorField;
        private System.Windows.Forms.Label directorField;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button activateBtn;
    }
}
