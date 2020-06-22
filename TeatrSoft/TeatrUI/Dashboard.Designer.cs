namespace TeatrUI
{
    partial class TeatrSoft
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.footerControl1 = new TeatrUI.UserControls.FooterControl();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(330, 710);
            this.sidePanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(333, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.contentPanel.Size = new System.Drawing.Size(620, 665);
            this.contentPanel.TabIndex = 1;
            // 
            // footerControl1
            // 
            this.footerControl1.BackColor = System.Drawing.Color.White;
            this.footerControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.footerControl1.Location = new System.Drawing.Point(333, 672);
            this.footerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.footerControl1.Name = "footerControl1";
            this.footerControl1.Size = new System.Drawing.Size(620, 38);
            this.footerControl1.TabIndex = 2;
            // 
            // TeatrSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 711);
            this.Controls.Add(this.footerControl1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "TeatrSoft";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.FlowLayoutPanel contentPanel;
        private UserControls.FooterControl footerControl1;
    }
}