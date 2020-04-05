namespace TeatrUI.UserControls
{
    partial class PersonItemControl
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
            this.nameField = new System.Windows.Forms.Label();
            this.positionField = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.photoField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.Transparent;
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(10, 180);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(125, 45);
            this.nameField.TabIndex = 12;
            this.nameField.Text = "Анастасия Лютова";
            this.nameField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // positionField
            // 
            this.positionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.positionField.Location = new System.Drawing.Point(10, 225);
            this.positionField.Name = "positionField";
            this.positionField.Size = new System.Drawing.Size(125, 22);
            this.positionField.TabIndex = 13;
            this.positionField.Text = "актьор";
            this.positionField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Image = global::TeatrUI.Properties.Resources.editPerson;
            this.editBtn.Location = new System.Drawing.Point(10, 11);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(34, 30);
            this.editBtn.TabIndex = 66;
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // photoField
            // 
            this.photoField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoField.Location = new System.Drawing.Point(10, 11);
            this.photoField.Name = "photoField";
            this.photoField.Size = new System.Drawing.Size(125, 160);
            this.photoField.TabIndex = 0;
            this.photoField.TabStop = false;
            // 
            // PersonItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.positionField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.photoField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PersonItemControl";
            this.Size = new System.Drawing.Size(147, 254);
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photoField;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Label positionField;
        private System.Windows.Forms.Button editBtn;
    }
}
