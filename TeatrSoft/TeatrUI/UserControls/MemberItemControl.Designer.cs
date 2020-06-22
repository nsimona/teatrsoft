namespace TeatrUI.UserControls
{
    partial class MemberItemControl
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
            this.activateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.AutoEllipsis = true;
            this.nameField.BackColor = System.Drawing.Color.Transparent;
            this.nameField.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(0, 169);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(125, 45);
            this.nameField.TabIndex = 12;
            this.nameField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // positionField
            // 
            this.positionField.AutoEllipsis = true;
            this.positionField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.positionField.Location = new System.Drawing.Point(0, 214);
            this.positionField.Name = "positionField";
            this.positionField.Size = new System.Drawing.Size(125, 38);
            this.positionField.TabIndex = 13;
            this.positionField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editBtn.Image = global::TeatrUI.Properties.Resources.editPerson;
            this.editBtn.Location = new System.Drawing.Point(92, 127);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(30, 30);
            this.editBtn.TabIndex = 66;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // photoField
            // 
            this.photoField.BackColor = System.Drawing.Color.Black;
            this.photoField.Cursor = System.Windows.Forms.Cursors.Default;
            this.photoField.Location = new System.Drawing.Point(0, 0);
            this.photoField.Name = "photoField";
            this.photoField.Size = new System.Drawing.Size(125, 160);
            this.photoField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoField.TabIndex = 0;
            this.photoField.TabStop = false;
            // 
            // activateBtn
            // 
            this.activateBtn.BackColor = System.Drawing.Color.Transparent;
            this.activateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateBtn.FlatAppearance.BorderSize = 0;
            this.activateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.activateBtn.Image = global::TeatrUI.Properties.Resources.add1;
            this.activateBtn.Location = new System.Drawing.Point(92, 127);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(30, 30);
            this.activateBtn.TabIndex = 67;
            this.activateBtn.UseVisualStyleBackColor = false;
            this.activateBtn.Visible = false;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // MemberItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.positionField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.photoField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MemberItemControl";
            this.Size = new System.Drawing.Size(125, 252);
            ((System.ComponentModel.ISupportInitialize)(this.photoField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photoField;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Label positionField;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button activateBtn;
    }
}
