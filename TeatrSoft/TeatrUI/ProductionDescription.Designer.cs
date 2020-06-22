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
            this.descrLabel = new System.Windows.Forms.Label();
            this.datesLabel = new System.Windows.Forms.Label();
            this.datesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.White;
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Montserrat", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(0, 45);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(328, 583);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.Text = "Descr";
            // 
            // descrLabel
            // 
            this.descrLabel.AutoSize = true;
            this.descrLabel.Location = new System.Drawing.Point(-4, 20);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(96, 22);
            this.descrLabel.TabIndex = 2;
            this.descrLabel.Text = "Описание";
            // 
            // datesLabel
            // 
            this.datesLabel.AutoSize = true;
            this.datesLabel.Location = new System.Drawing.Point(357, 20);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(51, 22);
            this.datesLabel.TabIndex = 3;
            this.datesLabel.Text = "Дати";
            // 
            // datesPanel
            // 
            this.datesPanel.Location = new System.Drawing.Point(353, 45);
            this.datesPanel.Name = "datesPanel";
            this.datesPanel.Size = new System.Drawing.Size(237, 596);
            this.datesPanel.TabIndex = 0;
            // 
            // ProductionDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.datesPanel);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.descrLabel);
            this.Controls.Add(this.descriptionBox);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductionDescription";
            this.Text = "ProductionDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionBox;
        private UserControls.ProductionDateTicketControl productionDateTicketControl1;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.FlowLayoutPanel datesPanel;
    }
}