namespace TeatrUI
{
    partial class ProductionDescription
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
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.productionDateTicketControl1 = new TeatrUI.UserControls.ProductionDateTicketControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Montserrat", 9.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(0, 45);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(352, 583);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.Text = "Descr";
            // 
            // productionDateTicketControl1
            // 
            this.productionDateTicketControl1.BackColor = System.Drawing.Color.White;
            this.productionDateTicketControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionDateTicketControl1.Location = new System.Drawing.Point(355, 45);
            this.productionDateTicketControl1.Margin = new System.Windows.Forms.Padding(0);
            this.productionDateTicketControl1.Name = "productionDateTicketControl1";
            this.productionDateTicketControl1.Size = new System.Drawing.Size(236, 37);
            this.productionDateTicketControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дати";
            // 
            // ProductionDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productionDateTicketControl1);
            this.Controls.Add(this.descriptionBox);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ProductionDescription";
            this.Text = "ProductionDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionBox;
        private UserControls.ProductionDateTicketControl productionDateTicketControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}