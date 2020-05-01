namespace TeatrUI
{
    partial class MonthProgram
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
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.programPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Април",
            "Май",
            "Юни"});
            this.monthComboBox.Location = new System.Drawing.Point(0, 12);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(201, 30);
            this.monthComboBox.TabIndex = 10;
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveToFileBtn.FlatAppearance.BorderSize = 0;
            this.saveToFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToFileBtn.Image = global::TeatrUI.Properties.Resources.save;
            this.saveToFileBtn.Location = new System.Drawing.Point(548, 54);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(30, 30);
            this.saveToFileBtn.TabIndex = 50;
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Image = global::TeatrUI.Properties.Resources.print;
            this.printBtn.Location = new System.Drawing.Point(512, 54);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(30, 30);
            this.printBtn.TabIndex = 49;
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(218, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(188, 30);
            this.saveBtn.TabIndex = 51;
            this.saveBtn.Text = "ВИЖ ПРОГРАМАТА";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // programPanel
            // 
            this.programPanel.AutoScroll = true;
            this.programPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.programPanel.Location = new System.Drawing.Point(0, 90);
            this.programPanel.Name = "programPanel";
            this.programPanel.Size = new System.Drawing.Size(591, 552);
            this.programPanel.TabIndex = 0;
            // 
            // MonthProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.programPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.monthComboBox);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MonthProgram";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.MonthProgram_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel programPanel;
    }
}