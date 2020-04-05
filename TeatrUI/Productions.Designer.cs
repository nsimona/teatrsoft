namespace TeatrUI
{
    partial class Productions
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
            this.productionDateTicketControl2 = new TeatrUI.UserControls.ProductionDateTicketControl();
            this.productionDateTicketControl1 = new TeatrUI.UserControls.ProductionDateTicketControl();
            this.productionItemControl2 = new TeatrUI.UserControls.ProductionItemControl();
            this.productionPanel = new System.Windows.Forms.Panel();
            this.productionSubPanel = new System.Windows.Forms.Panel();
            this.ticketsPanel = new System.Windows.Forms.Panel();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.productionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionDateTicketControl2
            // 
            this.productionDateTicketControl2.BackColor = System.Drawing.Color.White;
            this.productionDateTicketControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionDateTicketControl2.Location = new System.Drawing.Point(354, 153);
            this.productionDateTicketControl2.Margin = new System.Windows.Forms.Padding(5);
            this.productionDateTicketControl2.Name = "productionDateTicketControl2";
            this.productionDateTicketControl2.Size = new System.Drawing.Size(236, 37);
            this.productionDateTicketControl2.TabIndex = 9;
            // 
            // productionDateTicketControl1
            // 
            this.productionDateTicketControl1.BackColor = System.Drawing.Color.White;
            this.productionDateTicketControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionDateTicketControl1.Location = new System.Drawing.Point(354, 110);
            this.productionDateTicketControl1.Margin = new System.Windows.Forms.Padding(5);
            this.productionDateTicketControl1.Name = "productionDateTicketControl1";
            this.productionDateTicketControl1.Size = new System.Drawing.Size(236, 37);
            this.productionDateTicketControl1.TabIndex = 8;
            // 
            // productionItemControl2
            // 
            this.productionItemControl2.BackColor = System.Drawing.Color.White;
            this.productionItemControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionItemControl2.Location = new System.Drawing.Point(0, 110);
            this.productionItemControl2.Margin = new System.Windows.Forms.Padding(4);
            this.productionItemControl2.Name = "productionItemControl2";
            this.productionItemControl2.Size = new System.Drawing.Size(352, 150);
            this.productionItemControl2.TabIndex = 3;
            // 
            // productionPanel
            // 
            this.productionPanel.BackColor = System.Drawing.Color.White;
            this.productionPanel.Controls.Add(this.productionSubPanel);
            this.productionPanel.Controls.Add(this.ticketsPanel);
            this.productionPanel.Location = new System.Drawing.Point(0, 90);
            this.productionPanel.Name = "productionPanel";
            this.productionPanel.Size = new System.Drawing.Size(593, 170);
            this.productionPanel.TabIndex = 11;
            // 
            // productionSubPanel
            // 
            this.productionSubPanel.Location = new System.Drawing.Point(0, 1);
            this.productionSubPanel.Name = "productionSubPanel";
            this.productionSubPanel.Size = new System.Drawing.Size(352, 169);
            this.productionSubPanel.TabIndex = 1;
            // 
            // ticketsPanel
            // 
            this.ticketsPanel.Location = new System.Drawing.Point(353, 0);
            this.ticketsPanel.Name = "ticketsPanel";
            this.ticketsPanel.Size = new System.Drawing.Size(237, 169);
            this.ticketsPanel.TabIndex = 0;
            // 
            // addNewBtn
            // 
            this.addNewBtn.FlatAppearance.BorderSize = 0;
            this.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBtn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewBtn.Image = global::TeatrUI.Properties.Resources.add1;
            this.addNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBtn.Location = new System.Drawing.Point(459, 2);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(131, 45);
            this.addNewBtn.TabIndex = 12;
            this.addNewBtn.Text = "Добавяне на\r\nнова постановка";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.FlatAppearance.BorderSize = 0;
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Image = global::TeatrUI.Properties.Resources.sort;
            this.sortBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.Location = new System.Drawing.Point(312, 2);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(142, 45);
            this.sortBtn.TabIndex = 7;
            this.sortBtn.Text = "Сортиране\r\nпо азбучен ред";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.headingLabel.Location = new System.Drawing.Point(0, 10);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(151, 29);
            this.headingLabel.TabIndex = 13;
            this.headingLabel.Text = "СПЕКТАКЛИ";
            // 
            // Productions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.productionDateTicketControl2);
            this.Controls.Add(this.productionDateTicketControl1);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.productionItemControl2);
            this.Controls.Add(this.productionPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Productions";
            this.Text = "Productions";
            this.productionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.ProductionItemControl productionItemControl2;
        private System.Windows.Forms.Button sortBtn;
        private UserControls.ProductionDateTicketControl productionDateTicketControl1;
        private UserControls.ProductionDateTicketControl productionDateTicketControl2;
        private System.Windows.Forms.Panel productionPanel;
        private System.Windows.Forms.Panel productionSubPanel;
        private System.Windows.Forms.Panel ticketsPanel;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Label headingLabel;
    }
}