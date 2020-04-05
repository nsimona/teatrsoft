namespace TeatrUI
{
    partial class TickerSideForm
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
            this.author = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.actors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.scene = new System.Windows.Forms.Label();
            this.seatsPanel = new System.Windows.Forms.Panel();
            this.reservedTicketControl2 = new TeatrUI.UserControls.ReservedTicketControl();
            this.reservedTicketControl1 = new TeatrUI.UserControls.ReservedTicketControl();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.seatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.ForeColor = System.Drawing.Color.Gray;
            this.author.Location = new System.Drawing.Point(13, 135);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(155, 18);
            this.author.TabIndex = 32;
            this.author.Text = "Костадин Костадинов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Автор:";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.director.ForeColor = System.Drawing.Color.Gray;
            this.director.Location = new System.Drawing.Point(13, 175);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(155, 18);
            this.director.TabIndex = 30;
            this.director.Text = "Костадин Костадинов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Режисьор";
            // 
            // actors
            // 
            this.actors.AutoEllipsis = true;
            this.actors.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actors.ForeColor = System.Drawing.Color.Gray;
            this.actors.Location = new System.Drawing.Point(13, 211);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(289, 40);
            this.actors.TabIndex = 28;
            this.actors.Text = "Костадин Костадинов Костадин Костадинов Костадин Костадинов Костадин Костадинов К" +
    "остадин Костадинов Костадин Костадинов ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Актьори";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.ForeColor = System.Drawing.Color.Gray;
            this.duration.Location = new System.Drawing.Point(14, 269);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(52, 18);
            this.duration.TabIndex = 26;
            this.duration.Text = "96мин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Продължителност";
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.title.Location = new System.Drawing.Point(12, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(294, 92);
            this.title.TabIndex = 24;
            this.title.Text = "Ромео и Жулиета";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.date.Location = new System.Drawing.Point(14, 301);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(238, 44);
            this.date.TabIndex = 33;
            this.date.Text = "01.01.20 19:00";
            // 
            // scene
            // 
            this.scene.AutoSize = true;
            this.scene.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scene.Location = new System.Drawing.Point(14, 345);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(195, 29);
            this.scene.TabIndex = 34;
            this.scene.Text = "ГОЛЯМА СЦЕНА";
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
            this.cancelBtn.Enabled = false;
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
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(12, 660);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "ПЛАТИ";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(10, 618);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "ОБЩО:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.total.Location = new System.Drawing.Point(93, 618);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(64, 29);
            this.total.TabIndex = 38;
            this.total.Text = "52лв";
            // 
            // TickerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(330, 710);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.scene);
            this.Controls.Add(this.date);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.director);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TickerSideForm";
            this.Text = "TickerSideForm";
            this.seatsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label actors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label scene;
        private System.Windows.Forms.Panel seatsPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private UserControls.ReservedTicketControl reservedTicketControl1;
        private UserControls.ReservedTicketControl reservedTicketControl2;
    }
}