namespace TeatrUI
{
    partial class ScenesPresentation
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
            this.scenesPanel = new System.Windows.Forms.Panel();
            this.scenePresentationControl1 = new TeatrUI.UserControls.ScenePresentationControl();
            this.scenesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.White;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 10);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(82, 24);
            this.pageTitle.TabIndex = 18;
            this.pageTitle.Text = "СЦЕНИ";
            // 
            // scenesPanel
            // 
            this.scenesPanel.Controls.Add(this.scenePresentationControl1);
            this.scenesPanel.Location = new System.Drawing.Point(0, 65);
            this.scenesPanel.Name = "scenesPanel";
            this.scenesPanel.Size = new System.Drawing.Size(591, 533);
            this.scenesPanel.TabIndex = 19;
            // 
            // scenePresentationControl1
            // 
            this.scenePresentationControl1.BackColor = System.Drawing.Color.White;
            this.scenePresentationControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scenePresentationControl1.Location = new System.Drawing.Point(0, 0);
            this.scenePresentationControl1.Margin = new System.Windows.Forms.Padding(5);
            this.scenePresentationControl1.Name = "scenePresentationControl1";
            this.scenePresentationControl1.Size = new System.Drawing.Size(590, 435);
            this.scenePresentationControl1.TabIndex = 0;
            // 
            // ScenesPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.scenesPanel);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScenesPresentation";
            this.Text = "ScenesPresentation";
            this.scenesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Panel scenesPanel;
        private UserControls.ScenePresentationControl scenePresentationControl1;
    }
}