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
            this.addNewBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.pageTitle = new System.Windows.Forms.Label();
            this.ticketsPanel = new System.Windows.Forms.Panel();
            this.productionDateTicketControl2 = new TeatrUI.UserControls.ProductionDateTicketControl();
            this.productionDateTicketControl1 = new TeatrUI.UserControls.ProductionDateTicketControl();
            this.productionItemControl2 = new TeatrUI.UserControls.ProductionItemControl();
            this.productionsPanel = new System.Windows.Forms.Panel();
            this.ticketsPanel.SuspendLayout();
            this.productionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewBtn
            // 
            this.addNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 10);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(151, 29);
            this.pageTitle.TabIndex = 13;
            this.pageTitle.Text = "СПЕКТАКЛИ";
            // 
            // ticketsPanel
            // 
            this.ticketsPanel.Controls.Add(this.productionDateTicketControl2);
            this.ticketsPanel.Controls.Add(this.productionDateTicketControl1);
            this.ticketsPanel.Location = new System.Drawing.Point(353, 0);
            this.ticketsPanel.Name = "ticketsPanel";
            this.ticketsPanel.Size = new System.Drawing.Size(237, 196);
            this.ticketsPanel.TabIndex = 0;
            // 
            // productionDateTicketControl2
            // 
            this.productionDateTicketControl2.BackColor = System.Drawing.Color.White;
            this.productionDateTicketControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionDateTicketControl2.Location = new System.Drawing.Point(0, 35);
            this.productionDateTicketControl2.Margin = new System.Windows.Forms.Padding(5);
            this.productionDateTicketControl2.Name = "productionDateTicketControl2";
            this.productionDateTicketControl2.Size = new System.Drawing.Size(236, 37);
            this.productionDateTicketControl2.TabIndex = 1;
            // 
            // productionDateTicketControl1
            // 
            this.productionDateTicketControl1.BackColor = System.Drawing.Color.White;
            this.productionDateTicketControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionDateTicketControl1.Location = new System.Drawing.Point(0, 0);
            this.productionDateTicketControl1.Margin = new System.Windows.Forms.Padding(5);
            this.productionDateTicketControl1.Name = "productionDateTicketControl1";
            this.productionDateTicketControl1.Size = new System.Drawing.Size(236, 37);
            this.productionDateTicketControl1.TabIndex = 0;
            // 
            // productionItemControl2
            // 
            this.productionItemControl2.BackColor = System.Drawing.Color.White;
            this.productionItemControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionItemControl2.Location = new System.Drawing.Point(2, 0);
            this.productionItemControl2.Margin = new System.Windows.Forms.Padding(4);
            this.productionItemControl2.Name = "productionItemControl2";
            this.productionItemControl2.Size = new System.Drawing.Size(352, 150);
            this.productionItemControl2.TabIndex = 3;
            this.productionItemControl2.Load += new System.EventHandler(this.productionItemControl2_Load);
            // 
            // productionsPanel
            // 
            this.productionsPanel.BackColor = System.Drawing.Color.White;
            this.productionsPanel.Controls.Add(this.productionItemControl2);
            this.productionsPanel.Controls.Add(this.ticketsPanel);
            this.productionsPanel.Location = new System.Drawing.Point(0, 90);
            this.productionsPanel.Name = "productionsPanel";
            this.productionsPanel.Size = new System.Drawing.Size(593, 196);
            this.productionsPanel.TabIndex = 11;
            // 
            // Productions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.productionsPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Productions";
            this.Text = "Productions";
            this.ticketsPanel.ResumeLayout(false);
            this.productionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Panel ticketsPanel;
        private UserControls.ProductionDateTicketControl productionDateTicketControl2;
        private UserControls.ProductionDateTicketControl productionDateTicketControl1;
        private UserControls.ProductionItemControl productionItemControl2;
        private System.Windows.Forms.Panel productionsPanel;
    }
}