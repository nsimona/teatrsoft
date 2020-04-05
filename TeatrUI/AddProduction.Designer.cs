namespace TeatrUI
{
    partial class AddProduction
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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addProductionPanel = new System.Windows.Forms.Panel();
            this.archiveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label7.Location = new System.Drawing.Point(0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(510, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "ДОБАВЯНЕ/ РЕДАКТИРАНЕ НА СПЕКТАКЪЛ\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(349, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "ЗАПИС";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addProductionPanel
            // 
            this.addProductionPanel.AutoScroll = true;
            this.addProductionPanel.Location = new System.Drawing.Point(0, 90);
            this.addProductionPanel.Name = "addProductionPanel";
            this.addProductionPanel.Size = new System.Drawing.Size(590, 502);
            this.addProductionPanel.TabIndex = 30;
            this.addProductionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // archiveBtn
            // 
            this.archiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
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
            // AddProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.archiveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel addProductionPanel;
        private System.Windows.Forms.Button archiveBtn;
    }
}