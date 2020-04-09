namespace TeatrUI
{
    partial class TicketSideForm
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
            this.authorField = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.directorField = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.actorsField = new System.Windows.Forms.Label();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.durationField = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.titleField = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            this.seatsPanel = new System.Windows.Forms.Panel();
            this.reservedTicketControl2 = new TeatrUI.UserControls.ReservedTicketControl();
            this.reservedTicketControl1 = new TeatrUI.UserControls.ReservedTicketControl();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.backButtonControl = new TeatrUI.UserControls.BackButtonControl();
            this.seatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorField
            // 
            this.authorField.AutoSize = true;
            this.authorField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorField.ForeColor = System.Drawing.Color.Gray;
            this.authorField.Location = new System.Drawing.Point(13, 135);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(155, 18);
            this.authorField.TabIndex = 32;
            this.authorField.Text = "Костадин Костадинов";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(12, 117);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(52, 18);
            this.authorLabel.TabIndex = 31;
            this.authorLabel.Text = "Автор:";
            // 
            // directorField
            // 
            this.directorField.AutoSize = true;
            this.directorField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorField.ForeColor = System.Drawing.Color.Gray;
            this.directorField.Location = new System.Drawing.Point(13, 175);
            this.directorField.Name = "directorField";
            this.directorField.Size = new System.Drawing.Size(155, 18);
            this.directorField.TabIndex = 30;
            this.directorField.Text = "Костадин Костадинов";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorLabel.Location = new System.Drawing.Point(12, 157);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(76, 18);
            this.directorLabel.TabIndex = 29;
            this.directorLabel.Text = "Режисьор";
            // 
            // actorsField
            // 
            this.actorsField.AutoEllipsis = true;
            this.actorsField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorsField.ForeColor = System.Drawing.Color.Gray;
            this.actorsField.Location = new System.Drawing.Point(13, 211);
            this.actorsField.Name = "actorsField";
            this.actorsField.Size = new System.Drawing.Size(289, 40);
            this.actorsField.TabIndex = 28;
            this.actorsField.Text = "Костадин Костадинов Костадин Костадинов Костадин Костадинов Костадин Костадинов К" +
    "остадин Костадинов Костадин Костадинов ";
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorsLabel.Location = new System.Drawing.Point(12, 193);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(65, 18);
            this.actorsLabel.TabIndex = 27;
            this.actorsLabel.Text = "Актьори";
            // 
            // durationField
            // 
            this.durationField.AutoSize = true;
            this.durationField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationField.ForeColor = System.Drawing.Color.Gray;
            this.durationField.Location = new System.Drawing.Point(14, 269);
            this.durationField.Name = "durationField";
            this.durationField.Size = new System.Drawing.Size(52, 18);
            this.durationField.TabIndex = 26;
            this.durationField.Text = "96мин";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLabel.Location = new System.Drawing.Point(13, 251);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(132, 18);
            this.durationLabel.TabIndex = 25;
            this.durationLabel.Text = "Продължителност";
            // 
            // titleField
            // 
            this.titleField.AutoEllipsis = true;
            this.titleField.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.titleField.Location = new System.Drawing.Point(12, 25);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(294, 92);
            this.titleField.TabIndex = 24;
            this.titleField.Text = "Ромео и Жулиета";
            this.titleField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateField
            // 
            this.dateField.AutoSize = true;
            this.dateField.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dateField.Location = new System.Drawing.Point(14, 301);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(238, 44);
            this.dateField.TabIndex = 33;
            this.dateField.Text = "01.01.20 19:00";
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sceneField.Location = new System.Drawing.Point(14, 345);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(195, 29);
            this.sceneField.TabIndex = 34;
            this.sceneField.Text = "ГОЛЯМА СЦЕНА";
            // 
            // seatsPanel
            // 
            this.seatsPanel.Controls.Add(this.reservedTicketControl2);
            this.seatsPanel.Controls.Add(this.reservedTicketControl1);
            this.seatsPanel.Location = new System.Drawing.Point(17, 388);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(280, 218);
            this.seatsPanel.TabIndex = 35;
            // 
            // reservedTicketControl2
            // 
            this.reservedTicketControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservedTicketControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.reservedTicketControl2.Location = new System.Drawing.Point(0, 61);
            this.reservedTicketControl2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reservedTicketControl2.Name = "reservedTicketControl2";
            this.reservedTicketControl2.Size = new System.Drawing.Size(280, 61);
            this.reservedTicketControl2.TabIndex = 1;
            // 
            // reservedTicketControl1
            // 
            this.reservedTicketControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservedTicketControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.reservedTicketControl1.Location = new System.Drawing.Point(0, 0);
            this.reservedTicketControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reservedTicketControl1.Name = "reservedTicketControl1";
            this.reservedTicketControl1.Size = new System.Drawing.Size(280, 61);
            this.reservedTicketControl1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(121, 660);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 30);
            this.cancelBtn.TabIndex = 36;
            this.cancelBtn.Text = "ОТКАЗ";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(12, 660);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(100, 30);
            this.payBtn.TabIndex = 35;
            this.payBtn.Text = "ПЛАТИ";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.totalLabel.Location = new System.Drawing.Point(10, 618);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(91, 29);
            this.totalLabel.TabIndex = 37;
            this.totalLabel.Text = "ОБЩО:";
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.totalField.Location = new System.Drawing.Point(93, 618);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(64, 29);
            this.totalField.TabIndex = 38;
            this.totalField.Text = "52лв";
            // 
            // backButtonControl
            // 
            this.backButtonControl.BackColor = System.Drawing.Color.Transparent;
            this.backButtonControl.Location = new System.Drawing.Point(10, 10);
            this.backButtonControl.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.backButtonControl.Name = "backButtonControl";
            this.backButtonControl.Size = new System.Drawing.Size(135, 36);
            this.backButtonControl.TabIndex = 40;
            // 
            // TicketSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(330, 710);
            this.Controls.Add(this.backButtonControl);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.sceneField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.directorField);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.actorsField);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.durationField);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.titleField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketSideForm";
            this.Text = "TickerSideForm";
            this.seatsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorField;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label directorField;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label actorsField;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.Label durationField;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label titleField;
        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Label sceneField;
        private System.Windows.Forms.Panel seatsPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalField;
        private UserControls.ReservedTicketControl reservedTicketControl1;
        private UserControls.ReservedTicketControl reservedTicketControl2;
        private UserControls.BackButtonControl backButtonControl;
    }
}