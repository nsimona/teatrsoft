namespace TeatrUI.UserControls
{
    partial class ExportItemControl
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
            this.date = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.scene = new System.Windows.Forms.Label();
            this.seats = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoEllipsis = true;
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.date.Location = new System.Drawing.Point(3, 6);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(96, 50);
            this.date.TabIndex = 99;
            this.date.Text = "01.03.20 19:00";
            // 
            // name
            // 
            this.name.AutoEllipsis = true;
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.name.Location = new System.Drawing.Point(118, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 50);
            this.name.TabIndex = 100;
            this.name.Text = "Ромео и Жулиета и Ромео и Жулиета";
            // 
            // scene
            // 
            this.scene.AutoEllipsis = true;
            this.scene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scene.Location = new System.Drawing.Point(287, 6);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(109, 50);
            this.scene.TabIndex = 101;
            this.scene.Text = "Голяма сцена";
            // 
            // seats
            // 
            this.seats.AutoEllipsis = true;
            this.seats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.seats.Location = new System.Drawing.Point(413, 6);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(88, 50);
            this.seats.TabIndex = 102;
            this.seats.Text = "250/800";
            // 
            // total
            // 
            this.total.AutoEllipsis = true;
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.total.Location = new System.Drawing.Point(497, 6);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(83, 50);
            this.total.TabIndex = 103;
            this.total.Text = "10,000";
            this.total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 2);
            this.panel1.TabIndex = 104;
            // 
            // ExportItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.scene);
            this.Controls.Add(this.name);
            this.Controls.Add(this.date);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ExportItemControl";
            this.Size = new System.Drawing.Size(580, 63);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label scene;
        private System.Windows.Forms.Label seats;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Panel panel1;
    }
}
