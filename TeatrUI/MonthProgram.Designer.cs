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
            this.monthBtn = new System.Windows.Forms.Button();
            this.productionLabel = new System.Windows.Forms.Label();
            this.sceneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.programDateControl1 = new TeatrUI.UserControls.ProgramDateControl();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // monthBtn
            // 
            this.monthBtn.FlatAppearance.BorderSize = 0;
            this.monthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.monthBtn.Location = new System.Drawing.Point(0, 12);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(115, 39);
            this.monthBtn.TabIndex = 2;
            this.monthBtn.Text = "Март 2020";
            this.monthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monthBtn.UseVisualStyleBackColor = true;
            // 
            // productionLabel
            // 
            this.productionLabel.AutoSize = true;
            this.productionLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.productionLabel.Location = new System.Drawing.Point(24, 176);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(462, 18);
            this.productionLabel.TabIndex = 4;
            this.productionLabel.Text = "19:00 Ромео и Жулиета, автор: Иван Иванов, режисьор: А.Ангелова";
            // 
            // sceneLabel
            // 
            this.sceneLabel.AutoSize = true;
            this.sceneLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.sceneLabel.Location = new System.Drawing.Point(24, 153);
            this.sceneLabel.Name = "sceneLabel";
            this.sceneLabel.Size = new System.Drawing.Size(123, 18);
            this.sceneLabel.TabIndex = 5;
            this.sceneLabel.Text = "ГОЛЯМА СЦЕНА";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(24, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "19:00 Ромео и Жулиета, автор: Иван Иванов, режисьор: А.Ангелова";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button1.Location = new System.Drawing.Point(121, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Април 2020";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // programDateControl1
            // 
            this.programDateControl1.BackColor = System.Drawing.Color.White;
            this.programDateControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programDateControl1.Location = new System.Drawing.Point(0, 92);
            this.programDateControl1.Margin = new System.Windows.Forms.Padding(5);
            this.programDateControl1.Name = "programDateControl1";
            this.programDateControl1.Size = new System.Drawing.Size(212, 45);
            this.programDateControl1.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 90);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(591, 576);
            this.panel.TabIndex = 9;
            // 
            // MonthProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sceneLabel);
            this.Controls.Add(this.productionLabel);
            this.Controls.Add(this.programDateControl1);
            this.Controls.Add(this.monthBtn);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MonthProgram";
            this.Text = "    ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthBtn;
        private UserControls.ProgramDateControl programDateControl1;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Label sceneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
    }
}