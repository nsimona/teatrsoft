namespace TeatrUI
{
    partial class CreateUpdateProduction
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
            this.pageTitle = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addProductionPanel = new System.Windows.Forms.Panel();
            this.archiveBtn = new System.Windows.Forms.Button();
            this.backButtonControl = new TeatrUI.UserControls.BackButtonControl();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 40);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(510, 29);
            this.pageTitle.TabIndex = 29;
            this.pageTitle.Text = "ДОБАВЯНЕ/ РЕДАКТИРАНЕ НА СПЕКТАКЪЛ\r\n";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(349, 610);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 27;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addProductionPanel
            // 
            this.addProductionPanel.AutoScroll = true;
            this.addProductionPanel.Location = new System.Drawing.Point(0, 90);
            this.addProductionPanel.Name = "addProductionPanel";
            this.addProductionPanel.Size = new System.Drawing.Size(590, 502);
            this.addProductionPanel.TabIndex = 30;
            // 
            // archiveBtn
            // 
            this.archiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.archiveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archiveBtn.FlatAppearance.BorderSize = 0;
            this.archiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveBtn.ForeColor = System.Drawing.Color.White;
            this.archiveBtn.Location = new System.Drawing.Point(460, 610);
            this.archiveBtn.Name = "archiveBtn";
            this.archiveBtn.Size = new System.Drawing.Size(130, 30);
            this.archiveBtn.TabIndex = 31;
            this.archiveBtn.Text = "АХИВИРАНЕ";
            this.archiveBtn.UseVisualStyleBackColor = false;
            // 
            // backButtonControl
            // 
            this.backButtonControl.BackColor = System.Drawing.Color.Transparent;
            this.backButtonControl.Location = new System.Drawing.Point(0, 0);
            this.backButtonControl.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.backButtonControl.Name = "backButtonControl";
            this.backButtonControl.Size = new System.Drawing.Size(135, 36);
            this.backButtonControl.TabIndex = 36;
            // 
            // AddProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.backButtonControl);
            this.Controls.Add(this.archiveBtn);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addProductionPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProduction";
            this.Text = "AddProduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel addProductionPanel;
        private System.Windows.Forms.Button archiveBtn;
        private UserControls.BackButtonControl backButtonControl;
    }
}