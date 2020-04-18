namespace TeatrUI
{
    partial class ProductionSideForm
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
            this.titleField = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationField = new System.Windows.Forms.Label();
            this.actorsField = new System.Windows.Forms.Label();
            this.actrosLabel = new System.Windows.Forms.Label();
            this.directorField = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.backButtonControl = new TeatrUI.UserControls.BackButtonControl();
            this.posterField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterField)).BeginInit();
            this.SuspendLayout();
            // 
            // titleField
            // 
            this.titleField.AutoEllipsis = true;
            this.titleField.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.titleField.Location = new System.Drawing.Point(15, 46);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(298, 75);
            this.titleField.TabIndex = 14;
            this.titleField.Text = "Ромео и Жулиета";
            this.titleField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLabel.Location = new System.Drawing.Point(13, 658);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(132, 18);
            this.durationLabel.TabIndex = 16;
            this.durationLabel.Text = "Продължителност";
            // 
            // durationField
            // 
            this.durationField.AutoSize = true;
            this.durationField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationField.ForeColor = System.Drawing.Color.Gray;
            this.durationField.Location = new System.Drawing.Point(14, 676);
            this.durationField.Name = "durationField";
            this.durationField.Size = new System.Drawing.Size(52, 18);
            this.durationField.TabIndex = 17;
            this.durationField.Text = "96мин";
            // 
            // actorsField
            // 
            this.actorsField.AutoEllipsis = true;
            this.actorsField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorsField.ForeColor = System.Drawing.Color.Gray;
            this.actorsField.Location = new System.Drawing.Point(13, 618);
            this.actorsField.Name = "actorsField";
            this.actorsField.Size = new System.Drawing.Size(304, 40);
            this.actorsField.TabIndex = 19;
            this.actorsField.Text = "Костадин Костадинов Костадин Костадинов Костадин Костадинов Костадин Костадинов К" +
    "остадин Костадинов Костадин Костадинов ";
            // 
            // actrosLabel
            // 
            this.actrosLabel.AutoSize = true;
            this.actrosLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actrosLabel.Location = new System.Drawing.Point(12, 600);
            this.actrosLabel.Name = "actrosLabel";
            this.actrosLabel.Size = new System.Drawing.Size(65, 18);
            this.actrosLabel.TabIndex = 18;
            this.actrosLabel.Text = "Актьори";
            // 
            // directorField
            // 
            this.directorField.AutoSize = true;
            this.directorField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorField.ForeColor = System.Drawing.Color.Gray;
            this.directorField.Location = new System.Drawing.Point(13, 582);
            this.directorField.Name = "directorField";
            this.directorField.Size = new System.Drawing.Size(155, 18);
            this.directorField.TabIndex = 21;
            this.directorField.Text = "Костадин Костадинов";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorLabel.Location = new System.Drawing.Point(12, 564);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(76, 18);
            this.directorLabel.TabIndex = 20;
            this.directorLabel.Text = "Режисьор";
            // 
            // authorField
            // 
            this.authorField.AutoSize = true;
            this.authorField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorField.ForeColor = System.Drawing.Color.Gray;
            this.authorField.Location = new System.Drawing.Point(13, 542);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(155, 18);
            this.authorField.TabIndex = 23;
            this.authorField.Text = "Костадин Костадинов";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(12, 524);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(52, 18);
            this.authorLabel.TabIndex = 22;
            this.authorLabel.Text = "Автор:";
            // 
            // backButtonControl
            // 
            this.backButtonControl.BackColor = System.Drawing.Color.Transparent;
            this.backButtonControl.Location = new System.Drawing.Point(10, 10);
            this.backButtonControl.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.backButtonControl.Name = "backButtonControl";
            this.backButtonControl.Size = new System.Drawing.Size(135, 36);
            this.backButtonControl.TabIndex = 37;
            // 
            // posterField
            // 
            this.posterField.ImageLocation = "";
            this.posterField.InitialImage = global::TeatrUI.Properties.Resources.default_poster;
            this.posterField.Location = new System.Drawing.Point(15, 124);
            this.posterField.Name = "posterField";
            this.posterField.Size = new System.Drawing.Size(300, 384);
            this.posterField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterField.TabIndex = 15;
            this.posterField.TabStop = false;
            this.posterField.WaitOnLoad = true;
            // 
            // ProductionSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(330, 710);
            this.Controls.Add(this.backButtonControl);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.directorField);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.actorsField);
            this.Controls.Add(this.actrosLabel);
            this.Controls.Add(this.durationField);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.posterField);
            this.Controls.Add(this.titleField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductionSideForm";
            this.Text = "ProductionSideForm";
            ((System.ComponentModel.ISupportInitialize)(this.posterField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleField;
        private System.Windows.Forms.PictureBox posterField;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label durationField;
        private System.Windows.Forms.Label actorsField;
        private System.Windows.Forms.Label actrosLabel;
        private System.Windows.Forms.Label directorField;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label authorField;
        private System.Windows.Forms.Label authorLabel;
        private UserControls.BackButtonControl backButtonControl;
    }
}