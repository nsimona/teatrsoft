namespace TeatrUI
{
    partial class StaffList
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
            this.addNew = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.pageTitle = new System.Windows.Forms.Label();
            this.personItemControl1 = new TeatrUI.UserControls.PersonItemControl();
            this.staffPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addNew
            // 
            this.addNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNew.FlatAppearance.BorderSize = 0;
            this.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNew.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNew.Image = global::TeatrUI.Properties.Resources.add1;
            this.addNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNew.Location = new System.Drawing.Point(447, 0);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(131, 45);
            this.addNew.TabIndex = 14;
            this.addNew.Text = "Добавяне на\r\nнов служител";
            this.addNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortBtn.FlatAppearance.BorderSize = 0;
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Image = global::TeatrUI.Properties.Resources.sort;
            this.sortBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.Location = new System.Drawing.Point(289, 0);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(142, 45);
            this.sortBtn.TabIndex = 13;
            this.sortBtn.Text = "Сортиране\r\nпо азбучен ред";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 8);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(233, 24);
            this.pageTitle.TabIndex = 17;
            this.pageTitle.Text = "ТВОРЧЕСКИ СЪСТАВ";
            // 
            // personItemControl1
            // 
            this.personItemControl1.BackColor = System.Drawing.Color.White;
            this.personItemControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personItemControl1.Location = new System.Drawing.Point(0, 90);
            this.personItemControl1.Margin = new System.Windows.Forms.Padding(5);
            this.personItemControl1.Name = "personItemControl1";
            this.personItemControl1.Size = new System.Drawing.Size(147, 254);
            this.personItemControl1.TabIndex = 15;
            // 
            // staffPanel
            // 
            this.staffPanel.Location = new System.Drawing.Point(0, 90);
            this.staffPanel.Name = "staffPanel";
            this.staffPanel.Size = new System.Drawing.Size(588, 548);
            this.staffPanel.TabIndex = 18;
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.personItemControl1);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.staffPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StaffList";
            this.Text = "PersonPresentation";
            this.Load += new System.EventHandler(this.StaffList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button sortBtn;
        private UserControls.PersonItemControl personItemControl1;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Panel staffPanel;
    }
}