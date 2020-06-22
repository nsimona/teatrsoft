namespace TeatrUI
{
    partial class Export
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromDateControl = new System.Windows.Forms.DateTimePicker();
            this.toDateControl = new System.Windows.Forms.DateTimePicker();
            this.productionLabel = new System.Windows.Forms.Label();
            this.productionComboBox = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.generatebtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.pageTitle.Location = new System.Drawing.Point(0, 11);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(262, 29);
            this.pageTitle.TabIndex = 14;
            this.pageTitle.Text = "ПРОДАДЕНИ БИЛЕТИ";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.fromLabel.Location = new System.Drawing.Point(0, 72);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 22);
            this.fromLabel.TabIndex = 15;
            this.fromLabel.Text = "ОТ";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Montserrat", 12F);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.toLabel.Location = new System.Drawing.Point(203, 72);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(37, 22);
            this.toLabel.TabIndex = 16;
            this.toLabel.Text = "ДО";
            // 
            // fromDateControl
            // 
            this.fromDateControl.CustomFormat = "dd/MM/yyyy";
            this.fromDateControl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateControl.Location = new System.Drawing.Point(43, 69);
            this.fromDateControl.Name = "fromDateControl";
            this.fromDateControl.Size = new System.Drawing.Size(147, 29);
            this.fromDateControl.TabIndex = 74;
            // 
            // toDateControl
            // 
            this.toDateControl.CustomFormat = "dd/MM/yyyy";
            this.toDateControl.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateControl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateControl.Location = new System.Drawing.Point(257, 69);
            this.toDateControl.Name = "toDateControl";
            this.toDateControl.Size = new System.Drawing.Size(147, 29);
            this.toDateControl.TabIndex = 75;
            // 
            // productionLabel
            // 
            this.productionLabel.AutoSize = true;
            this.productionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.productionLabel.Location = new System.Drawing.Point(0, 112);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(108, 22);
            this.productionLabel.TabIndex = 76;
            this.productionLabel.Text = "Постановка";
            // 
            // productionComboBox
            // 
            this.productionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productionComboBox.FormattingEnabled = true;
            this.productionComboBox.Location = new System.Drawing.Point(4, 140);
            this.productionComboBox.Name = "productionComboBox";
            this.productionComboBox.Size = new System.Drawing.Size(400, 30);
            this.productionComboBox.TabIndex = 77;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clearBtn.Location = new System.Drawing.Point(127, 185);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(123, 33);
            this.clearBtn.TabIndex = 79;
            this.clearBtn.Text = "ИЗЧИСТИ";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // generatebtn
            // 
            this.generatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.generatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatebtn.FlatAppearance.BorderSize = 0;
            this.generatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatebtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatebtn.ForeColor = System.Drawing.Color.White;
            this.generatebtn.Location = new System.Drawing.Point(6, 185);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(111, 33);
            this.generatebtn.TabIndex = 78;
            this.generatebtn.Text = "СПРАВКА";
            this.generatebtn.UseVisualStyleBackColor = false;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(1, 240);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(577, 193);
            this.infoLabel.TabIndex = 80;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.productionComboBox);
            this.Controls.Add(this.productionLabel);
            this.Controls.Add(this.toDateControl);
            this.Controls.Add(this.fromDateControl);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker fromDateControl;
        private System.Windows.Forms.DateTimePicker toDateControl;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.ComboBox productionComboBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Label infoLabel;
    }
}