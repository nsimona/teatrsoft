namespace TeatrUI.UserControls
{
    partial class ProductionFormAddedDate
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
            this.dateField = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateField
            // 
            this.dateField.AutoSize = true;
            this.dateField.Location = new System.Drawing.Point(5, 4);
            this.dateField.Margin = new System.Windows.Forms.Padding(5);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(103, 22);
            this.dateField.TabIndex = 0;
            this.dateField.Text = "06/04/2020";
            // 
            // timeField
            // 
            this.timeField.AutoSize = true;
            this.timeField.Location = new System.Drawing.Point(118, 4);
            this.timeField.Margin = new System.Windows.Forms.Padding(5);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(103, 22);
            this.timeField.TabIndex = 1;
            this.timeField.Text = "10:27:00 AM";
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Location = new System.Drawing.Point(243, 4);
            this.sceneField.Margin = new System.Windows.Forms.Padding(5);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(138, 22);
            this.sceneField.TabIndex = 76;
            this.sceneField.Text = "Камерна сцена";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.White;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Image = global::TeatrUI.Properties.Resources.addGreen;
            this.delBtn.Location = new System.Drawing.Point(471, 2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(34, 24);
            this.delBtn.TabIndex = 74;
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // ProductionFormAddedDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.dateField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductionFormAddedDate";
            this.Size = new System.Drawing.Size(515, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Label timeField;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label sceneField;
    }
}
