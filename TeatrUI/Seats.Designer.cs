namespace TeatrUI
{
    partial class Seats
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
            this.dateField = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            this.freeSeatsField = new System.Windows.Forms.Label();
            this.freeLabel = new System.Windows.Forms.Label();
            this.busyLabel = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.sumField = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.sceneDemoLabel = new System.Windows.Forms.Label();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.modelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedSeatControl = new TeatrUI.UserControls.SeatControl();
            this.freeSeatControl = new TeatrUI.UserControls.SeatControl();
            this.busySeatControl = new TeatrUI.UserControls.SeatControl();
            this.scenePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateField
            // 
            this.dateField.AutoSize = true;
            this.dateField.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.dateField.Location = new System.Drawing.Point(31, 34);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(218, 66);
            this.dateField.TabIndex = 0;
            this.dateField.Text = "01.01.20";
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sceneField.Location = new System.Drawing.Point(280, 34);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(244, 33);
            this.sceneField.TabIndex = 1;
            this.sceneField.Text = "КАМЕРНА СЦЕНА";
            // 
            // freeSeatsField
            // 
            this.freeSeatsField.AutoSize = true;
            this.freeSeatsField.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeSeatsField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.freeSeatsField.Location = new System.Drawing.Point(281, 70);
            this.freeSeatsField.Name = "freeSeatsField";
            this.freeSeatsField.Size = new System.Drawing.Size(265, 26);
            this.freeSeatsField.TabIndex = 2;
            this.freeSeatsField.Text = "13/60 СВОБОДНИ МЕСТА";
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Location = new System.Drawing.Point(110, 544);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(94, 22);
            this.freeLabel.TabIndex = 6;
            this.freeLabel.Text = "Свободни";
            // 
            // busyLabel
            // 
            this.busyLabel.AutoSize = true;
            this.busyLabel.Location = new System.Drawing.Point(266, 544);
            this.busyLabel.Name = "busyLabel";
            this.busyLabel.Size = new System.Drawing.Size(58, 22);
            this.busyLabel.TabIndex = 7;
            this.busyLabel.Text = "Заети";
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(382, 544);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(121, 22);
            this.selectedLabel.TabIndex = 8;
            this.selectedLabel.Text = "Селектирани";
            // 
            // sumField
            // 
            this.sumField.AutoSize = true;
            this.sumField.Location = new System.Drawing.Point(474, 606);
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(50, 22);
            this.sumField.TabIndex = 10;
            this.sumField.Text = "24лв";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(456, 584);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(68, 22);
            this.sumLabel.TabIndex = 11;
            this.sumLabel.Text = "ОБЩО";
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.White;
            this.continueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueBtn.FlatAppearance.BorderSize = 0;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Image = global::TeatrUI.Properties.Resources._continue;
            this.continueBtn.Location = new System.Drawing.Point(530, 585);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(48, 43);
            this.continueBtn.TabIndex = 12;
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // sceneDemoLabel
            // 
            this.sceneDemoLabel.AutoSize = true;
            this.sceneDemoLabel.Location = new System.Drawing.Point(205, 28);
            this.sceneDemoLabel.Name = "sceneDemoLabel";
            this.sceneDemoLabel.Size = new System.Drawing.Size(70, 22);
            this.sceneDemoLabel.TabIndex = 13;
            this.sceneDemoLabel.Text = "СЦЕНА";
            // 
            // scenePanel
            // 
            this.scenePanel.Controls.Add(this.sceneDemoLabel);
            this.scenePanel.Location = new System.Drawing.Point(33, 138);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(515, 50);
            this.scenePanel.TabIndex = 5;
            this.scenePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.scenePanel_Paint_1);
            // 
            // modelPanel
            // 
            this.modelPanel.Location = new System.Drawing.Point(32, 206);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(516, 305);
            this.modelPanel.TabIndex = 0;
            this.modelPanel.WrapContents = false;
            this.modelPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Paint);
            // 
            // selectedSeatControl
            // 
            this.selectedSeatControl.BackColor = System.Drawing.Color.White;
            this.selectedSeatControl.Enabled = false;
            this.selectedSeatControl.Location = new System.Drawing.Point(357, 547);
            this.selectedSeatControl.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSeatControl.Name = "selectedSeatControl";
            this.selectedSeatControl.SeatColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.selectedSeatControl.Size = new System.Drawing.Size(18, 19);
            this.selectedSeatControl.TabIndex = 0;
            // 
            // freeSeatControl
            // 
            this.freeSeatControl.BackColor = System.Drawing.Color.White;
            this.freeSeatControl.Enabled = false;
            this.freeSeatControl.Location = new System.Drawing.Point(83, 547);
            this.freeSeatControl.Margin = new System.Windows.Forms.Padding(5);
            this.freeSeatControl.Name = "freeSeatControl";
            this.freeSeatControl.SeatColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.freeSeatControl.Size = new System.Drawing.Size(18, 19);
            this.freeSeatControl.TabIndex = 1;
            // 
            // busySeatControl
            // 
            this.busySeatControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.busySeatControl.Enabled = false;
            this.busySeatControl.Location = new System.Drawing.Point(240, 547);
            this.busySeatControl.Margin = new System.Windows.Forms.Padding(5);
            this.busySeatControl.Name = "busySeatControl";
            this.busySeatControl.SeatColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.busySeatControl.Size = new System.Drawing.Size(18, 19);
            this.busySeatControl.TabIndex = 2;
            // 
            // Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.modelPanel);
            this.Controls.Add(this.scenePanel);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.busyLabel);
            this.Controls.Add(this.freeLabel);
            this.Controls.Add(this.selectedSeatControl);
            this.Controls.Add(this.freeSeatControl);
            this.Controls.Add(this.busySeatControl);
            this.Controls.Add(this.freeSeatsField);
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.dateField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Seats";
            this.Text = "SeatPresentaion";
            this.scenePanel.ResumeLayout(false);
            this.scenePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Label sceneField;
        private System.Windows.Forms.Label freeSeatsField;
        private UserControls.SeatControl selectedSeatControl;
        private UserControls.SeatControl freeSeatControl;
        private UserControls.SeatControl busySeatControl;
        private System.Windows.Forms.Label freeLabel;
        private System.Windows.Forms.Label busyLabel;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Label sumField;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label sceneDemoLabel;
        private System.Windows.Forms.Panel scenePanel;
        private System.Windows.Forms.FlowLayoutPanel modelPanel;
    }
}