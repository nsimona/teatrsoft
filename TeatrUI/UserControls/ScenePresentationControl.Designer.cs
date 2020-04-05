namespace TeatrUI.UserControls
{
    partial class ScenePresentationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scenePanel = new System.Windows.Forms.Panel();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.seatControl1 = new TeatrUI.UserControls.SeatControl();
            this.sceneTitle = new System.Windows.Forms.Label();
            this.modelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scenePanel
            // 
            this.scenePanel.Location = new System.Drawing.Point(31, 54);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(515, 57);
            this.scenePanel.TabIndex = 10;
            // 
            // modelPanel
            // 
            this.modelPanel.Controls.Add(this.seatControl1);
            this.modelPanel.Location = new System.Drawing.Point(31, 117);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(515, 308);
            this.modelPanel.TabIndex = 11;
            // 
            // seatControl1
            // 
            this.seatControl1.BackColor = System.Drawing.Color.White;
            this.seatControl1.Location = new System.Drawing.Point(8, 8);
            this.seatControl1.Margin = new System.Windows.Forms.Padding(8);
            this.seatControl1.Name = "seatControl1";
            this.seatControl1.Size = new System.Drawing.Size(20, 20);
            this.seatControl1.TabIndex = 3;
            // 
            // sceneTitle
            // 
            this.sceneTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.sceneTitle.Location = new System.Drawing.Point(0, 15);
            this.sceneTitle.Name = "sceneTitle";
            this.sceneTitle.Size = new System.Drawing.Size(590, 26);
            this.sceneTitle.TabIndex = 14;
            this.sceneTitle.Text = "ГОЛЯМА СЦЕНА";
            this.sceneTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScenePresentationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sceneTitle);
            this.Controls.Add(this.scenePanel);
            this.Controls.Add(this.modelPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScenePresentationControl";
            this.Size = new System.Drawing.Size(590, 435);
            this.modelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scenePanel;
        private SeatControl seatControl1;
        private System.Windows.Forms.Panel modelPanel;
        private System.Windows.Forms.Label sceneTitle;
    }
}
