namespace TeatrUI
{
    partial class SeatPresentaion
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
            this.seatControl2 = new TeatrUI.UserControls.SeatControl();
            this.seatControl1 = new TeatrUI.UserControls.SeatControl();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.selectedSeatControl = new TeatrUI.UserControls.SeatControl();
            this.freeSeatControl = new TeatrUI.UserControls.SeatControl();
            this.busySeatControl = new TeatrUI.UserControls.SeatControl();
            this.freeLabel = new System.Windows.Forms.Label();
            this.busyLabel = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.sumField = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.modelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateField
            // 
            this.dateField.AutoSize = true;
            this.dateField.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.dateField.Location = new System.Drawing.Point(31, 34);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(212, 56);
            this.dateField.TabIndex = 0;
            this.dateField.Text = "01.01.20";
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sceneField.Location = new System.Drawing.Point(255, 34);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(224, 29);
            this.sceneField.TabIndex = 1;
            this.sceneField.Text = "КАМЕРНА СЦЕНА";
            // 
            // freeSeatsField
            // 
            this.freeSeatsField.AutoSize = true;
            this.freeSeatsField.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeSeatsField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.freeSeatsField.Location = new System.Drawing.Point(256, 70);
            this.freeSeatsField.Name = "freeSeatsField";
            this.freeSeatsField.Size = new System.Drawing.Size(250, 22);
            this.freeSeatsField.TabIndex = 2;
            this.freeSeatsField.Text = "13/60 СВОБОДНИ МЕСТА";
            // 
            // seatControl2
            // 
            this.seatControl2.BackColor = System.Drawing.Color.White;
            this.seatControl2.Location = new System.Drawing.Point(50, 18);
            this.seatControl2.Margin = new System.Windows.Forms.Padding(5);
            this.seatControl2.Name = "seatControl2";
            this.seatControl2.Size = new System.Drawing.Size(18, 19);
            this.seatControl2.TabIndex = 4;
            // 
            // seatControl1
            // 
            this.seatControl1.BackColor = System.Drawing.Color.White;
            this.seatControl1.Location = new System.Drawing.Point(22, 18);
            this.seatControl1.Margin = new System.Windows.Forms.Padding(5);
            this.seatControl1.Name = "seatControl1";
            this.seatControl1.Size = new System.Drawing.Size(18, 19);
            this.seatControl1.TabIndex = 3;
            // 
            // scenePanel
            // 
            this.scenePanel.Location = new System.Drawing.Point(33, 127);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(515, 57);
            this.scenePanel.TabIndex = 5;
            // 
            // selectedSeatControl
            // 
            this.selectedSeatControl.BackColor = System.Drawing.Color.White;
            this.selectedSeatControl.Location = new System.Drawing.Point(337, 517);
            this.selectedSeatControl.Margin = new System.Windows.Forms.Padding(5);
            this.selectedSeatControl.Name = "selectedSeatControl";
            this.selectedSeatControl.Size = new System.Drawing.Size(18, 19);
            this.selectedSeatControl.TabIndex = 0;
            // 
            // freeSeatControl
            // 
            this.freeSeatControl.BackColor = System.Drawing.Color.White;
            this.freeSeatControl.Location = new System.Drawing.Point(65, 517);
            this.freeSeatControl.Margin = new System.Windows.Forms.Padding(5);
            this.freeSeatControl.Name = "freeSeatControl";
            this.freeSeatControl.Size = new System.Drawing.Size(18, 19);
            this.freeSeatControl.TabIndex = 1;
            // 
            // busySeatControl
            // 
            this.busySeatControl.BackColor = System.Drawing.Color.White;
            this.busySeatControl.Location = new System.Drawing.Point(221, 517);
            this.busySeatControl.Margin = new System.Windows.Forms.Padding(5);
            this.busySeatControl.Name = "busySeatControl";
            this.busySeatControl.Size = new System.Drawing.Size(18, 19);
            this.busySeatControl.TabIndex = 2;
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Location = new System.Drawing.Point(91, 514);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(81, 18);
            this.freeLabel.TabIndex = 6;
            this.freeLabel.Text = "Свободни";
            // 
            // busyLabel
            // 
            this.busyLabel.AutoSize = true;
            this.busyLabel.Location = new System.Drawing.Point(247, 514);
            this.busyLabel.Name = "busyLabel";
            this.busyLabel.Size = new System.Drawing.Size(50, 18);
            this.busyLabel.TabIndex = 7;
            this.busyLabel.Text = "Заети";
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(363, 514);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(101, 18);
            this.selectedLabel.TabIndex = 8;
            this.selectedLabel.Text = "Селектирани";
            // 
            // modelPanel
            // 
            this.modelPanel.Controls.Add(this.seatControl2);
            this.modelPanel.Controls.Add(this.seatControl1);
            this.modelPanel.Location = new System.Drawing.Point(33, 201);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(515, 308);
            this.modelPanel.TabIndex = 9;
            // 
            // sumField
            // 
            this.sumField.AutoSize = true;
            this.sumField.Location = new System.Drawing.Point(440, 591);
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(43, 18);
            this.sumField.TabIndex = 10;
            this.sumField.Text = "24лв";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(422, 569);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(61, 19);
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
            this.continueBtn.Location = new System.Drawing.Point(496, 570);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(48, 43);
            this.continueBtn.TabIndex = 12;
            this.continueBtn.UseVisualStyleBackColor = false;
            // 
            // SeatPresentaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumField);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.busyLabel);
            this.Controls.Add(this.freeLabel);
            this.Controls.Add(this.selectedSeatControl);
            this.Controls.Add(this.freeSeatControl);
            this.Controls.Add(this.busySeatControl);
            this.Controls.Add(this.scenePanel);
            this.Controls.Add(this.freeSeatsField);
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.modelPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SeatPresentaion";
            this.Text = "SeatPresentaion";
            this.modelPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Label sceneField;
        private System.Windows.Forms.Label freeSeatsField;
        private UserControls.SeatControl seatControl1;
        private UserControls.SeatControl seatControl2;
        private System.Windows.Forms.Panel scenePanel;
        private UserControls.SeatControl selectedSeatControl;
        private UserControls.SeatControl freeSeatControl;
        private UserControls.SeatControl busySeatControl;
        private System.Windows.Forms.Label freeLabel;
        private System.Windows.Forms.Label busyLabel;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Panel modelPanel;
        private System.Windows.Forms.Label sumField;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button continueBtn;
    }
}