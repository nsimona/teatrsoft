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
            this.dateLabel = new System.Windows.Forms.Label();
            this.sceneLabel = new System.Windows.Forms.Label();
            this.freeSeatsLabel = new System.Windows.Forms.Label();
            this.seatControl2 = new TeatrUI.UserControls.SeatControl();
            this.seatControl1 = new TeatrUI.UserControls.SeatControl();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.selectedSeatControl = new TeatrUI.UserControls.SeatControl();
            this.freeSeatControl = new TeatrUI.UserControls.SeatControl();
            this.busySeatControl = new TeatrUI.UserControls.SeatControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.modelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.dateLabel.Location = new System.Drawing.Point(31, 34);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(218, 66);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "01.01.20";
            // 
            // sceneLabel
            // 
            this.sceneLabel.AutoSize = true;
            this.sceneLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sceneLabel.Location = new System.Drawing.Point(255, 34);
            this.sceneLabel.Name = "sceneLabel";
            this.sceneLabel.Size = new System.Drawing.Size(244, 33);
            this.sceneLabel.TabIndex = 1;
            this.sceneLabel.Text = "КАМЕРНА СЦЕНА";
            // 
            // freeSeatsLabel
            // 
            this.freeSeatsLabel.AutoSize = true;
            this.freeSeatsLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeSeatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.freeSeatsLabel.Location = new System.Drawing.Point(256, 70);
            this.freeSeatsLabel.Name = "freeSeatsLabel";
            this.freeSeatsLabel.Size = new System.Drawing.Size(265, 26);
            this.freeSeatsLabel.TabIndex = 2;
            this.freeSeatsLabel.Text = "13/60 СВОБОДНИ МЕСТА";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Свободни";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Заети";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Селектирани";
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
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(440, 591);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(50, 22);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "24лв";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(422, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "ОБЩО";
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.White;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectedSeatControl);
            this.Controls.Add(this.freeSeatControl);
            this.Controls.Add(this.busySeatControl);
            this.Controls.Add(this.scenePanel);
            this.Controls.Add(this.freeSeatsLabel);
            this.Controls.Add(this.sceneLabel);
            this.Controls.Add(this.dateLabel);
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

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label sceneLabel;
        private System.Windows.Forms.Label freeSeatsLabel;
        private UserControls.SeatControl seatControl1;
        private UserControls.SeatControl seatControl2;
        private System.Windows.Forms.Panel scenePanel;
        private UserControls.SeatControl selectedSeatControl;
        private UserControls.SeatControl freeSeatControl;
        private UserControls.SeatControl busySeatControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel modelPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button continueBtn;
    }
}