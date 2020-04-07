namespace TeatrUI.UserControls
{
    partial class ProductionFormAddedActor
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
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.AutoEllipsis = true;
            this.nameField.Location = new System.Drawing.Point(3, 2);
            this.nameField.Margin = new System.Windows.Forms.Padding(5);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(242, 22);
            this.nameField.TabIndex = 78;
            this.nameField.Text = "Костадин Костадинов";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.White;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Image = global::TeatrUI.Properties.Resources.del;
            this.delBtn.Location = new System.Drawing.Point(253, 1);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(34, 24);
            this.delBtn.TabIndex = 77;
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // ProductionFormAddedActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.delBtn);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductionFormAddedActor";
            this.Size = new System.Drawing.Size(290, 28);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label nameField;
    }
}
