﻿namespace TeatrUI.UserControls
{
    partial class TicketControl
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
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.produtctionTitleField = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.Label();
            this.seatField = new System.Windows.Forms.Label();
            this.rowField = new System.Windows.Forms.Label();
            this.sceneAddressField = new System.Windows.Forms.Label();
            this.seatLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.sceneField = new System.Windows.Forms.Label();
            this.theaterAddress = new System.Windows.Forms.Label();
            this.theaterName = new System.Windows.Forms.Label();
            this.ticketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketPanel
            // 
            this.ticketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketPanel.Controls.Add(this.produtctionTitleField);
            this.ticketPanel.Controls.Add(this.priceField);
            this.ticketPanel.Controls.Add(this.dateField);
            this.ticketPanel.Controls.Add(this.seatField);
            this.ticketPanel.Controls.Add(this.rowField);
            this.ticketPanel.Controls.Add(this.sceneAddressField);
            this.ticketPanel.Controls.Add(this.seatLabel);
            this.ticketPanel.Controls.Add(this.rowLabel);
            this.ticketPanel.Controls.Add(this.sceneField);
            this.ticketPanel.Controls.Add(this.theaterAddress);
            this.ticketPanel.Controls.Add(this.theaterName);
            this.ticketPanel.Location = new System.Drawing.Point(3, 3);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(584, 222);
            this.ticketPanel.TabIndex = 0;
            // 
            // produtctionTitleField
            // 
            this.produtctionTitleField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produtctionTitleField.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.produtctionTitleField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.produtctionTitleField.Location = new System.Drawing.Point(15, 43);
            this.produtctionTitleField.Name = "produtctionTitleField";
            this.produtctionTitleField.Size = new System.Drawing.Size(546, 74);
            this.produtctionTitleField.TabIndex = 11;
            this.produtctionTitleField.Text = "Поп-фолк хроники: Бели птици и кушруми";
            // 
            // priceField
            // 
            this.priceField.AutoSize = true;
            this.priceField.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.ForeColor = System.Drawing.Color.Black;
            this.priceField.Location = new System.Drawing.Point(474, 181);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(96, 24);
            this.priceField.TabIndex = 10;
            this.priceField.Text = "15,00 лв";
            // 
            // dateField
            // 
            this.dateField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateField.Location = new System.Drawing.Point(17, 177);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(139, 37);
            this.dateField.TabIndex = 9;
            this.dateField.Text = "ПЕТЪК, 20.04.2020, 20:00ч";
            this.dateField.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // seatField
            // 
            this.seatField.AutoSize = true;
            this.seatField.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.seatField.Location = new System.Drawing.Point(357, 143);
            this.seatField.Name = "seatField";
            this.seatField.Size = new System.Drawing.Size(30, 21);
            this.seatField.TabIndex = 8;
            this.seatField.Text = "12";
            // 
            // rowField
            // 
            this.rowField.AutoSize = true;
            this.rowField.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.rowField.Location = new System.Drawing.Point(232, 143);
            this.rowField.Name = "rowField";
            this.rowField.Size = new System.Drawing.Size(20, 21);
            this.rowField.TabIndex = 7;
            this.rowField.Text = "4";
            // 
            // sceneAddressField
            // 
            this.sceneAddressField.AutoSize = true;
            this.sceneAddressField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneAddressField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sceneAddressField.Location = new System.Drawing.Point(18, 143);
            this.sceneAddressField.Name = "sceneAddressField";
            this.sceneAddressField.Size = new System.Drawing.Size(59, 16);
            this.sceneAddressField.TabIndex = 6;
            this.sceneAddressField.Text = "партер 2";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.seatLabel.Location = new System.Drawing.Point(359, 126);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(53, 16);
            this.seatLabel.TabIndex = 5;
            this.seatLabel.Text = "МЯСТО";
            this.seatLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rowLabel.Location = new System.Drawing.Point(234, 126);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(35, 16);
            this.rowLabel.TabIndex = 4;
            this.rowLabel.Text = "РЕД";
            // 
            // sceneField
            // 
            this.sceneField.AutoSize = true;
            this.sceneField.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sceneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sceneField.Location = new System.Drawing.Point(17, 126);
            this.sceneField.Name = "sceneField";
            this.sceneField.Size = new System.Drawing.Size(112, 16);
            this.sceneField.TabIndex = 3;
            this.sceneField.Text = "ГОЛЯМА СЦЕНА";
            this.sceneField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // theaterAddress
            // 
            this.theaterAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theaterAddress.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theaterAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.theaterAddress.Location = new System.Drawing.Point(235, 5);
            this.theaterAddress.Name = "theaterAddress";
            this.theaterAddress.Size = new System.Drawing.Size(243, 32);
            this.theaterAddress.TabIndex = 2;
            this.theaterAddress.Text = "СОФИЯ, 1000, БУЛ. МАДРИД 10";
            // 
            // theaterName
            // 
            this.theaterName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theaterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.theaterName.Location = new System.Drawing.Point(18, 5);
            this.theaterName.Name = "theaterName";
            this.theaterName.Size = new System.Drawing.Size(209, 32);
            this.theaterName.TabIndex = 1;
            this.theaterName.Text = "МАЛЪК ГРАДСКИ ТЕАТЪР \"ЗАД КАНАЛА\"";
            // 
            // TicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ticketPanel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketControl";
            this.Size = new System.Drawing.Size(590, 230);
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ticketPanel;
        private System.Windows.Forms.Label theaterName;
        private System.Windows.Forms.Label priceField;
        private System.Windows.Forms.Label dateField;
        private System.Windows.Forms.Label seatField;
        private System.Windows.Forms.Label rowField;
        private System.Windows.Forms.Label sceneAddressField;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label sceneField;
        private System.Windows.Forms.Label produtctionTitleField;
        private System.Windows.Forms.Label theaterAddress;
    }
}
