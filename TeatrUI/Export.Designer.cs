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
            this.soldTicketsLabel = new System.Windows.Forms.Label();
            this.datesLabel = new System.Windows.Forms.Label();
            this.forProductionLabel = new System.Windows.Forms.Label();
            this.datesField = new System.Windows.Forms.Label();
            this.forProductionField = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.tableDateLabel = new System.Windows.Forms.Label();
            this.tableProductionLabel = new System.Windows.Forms.Label();
            this.tableTicketLabel = new System.Windows.Forms.Label();
            this.tableAmountLabel = new System.Windows.Forms.Label();
            this.tableSceneLabel = new System.Windows.Forms.Label();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.sumResultLabel = new System.Windows.Forms.Label();
            this.sumResultField = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportItemControl3 = new TeatrUI.UserControls.ExportItemControl();
            this.exportItemControl2 = new TeatrUI.UserControls.ExportItemControl();
            this.exportItemControl1 = new TeatrUI.UserControls.ExportItemControl();
            this.resultPanel.SuspendLayout();
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
            this.pageTitle.Click += new System.EventHandler(this.headingLabel_Click);
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
            this.clearBtn.Enabled = false;
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
            this.generatebtn.Text = "ОТЧЕТ";
            this.generatebtn.UseVisualStyleBackColor = false;
            // 
            // soldTicketsLabel
            // 
            this.soldTicketsLabel.AutoSize = true;
            this.soldTicketsLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldTicketsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.soldTicketsLabel.Location = new System.Drawing.Point(0, 236);
            this.soldTicketsLabel.Name = "soldTicketsLabel";
            this.soldTicketsLabel.Size = new System.Drawing.Size(201, 22);
            this.soldTicketsLabel.TabIndex = 80;
            this.soldTicketsLabel.Text = "ПРОДАДЕНИ БИЛЕТИ";
            // 
            // datesLabel
            // 
            this.datesLabel.AutoSize = true;
            this.datesLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.datesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.datesLabel.Location = new System.Drawing.Point(0, 260);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(131, 22);
            this.datesLabel.TabIndex = 81;
            this.datesLabel.Text = "ЗА ПЕРИОДА:";
            // 
            // forProductionLabel
            // 
            this.forProductionLabel.AutoSize = true;
            this.forProductionLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.forProductionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.forProductionLabel.Location = new System.Drawing.Point(0, 284);
            this.forProductionLabel.Name = "forProductionLabel";
            this.forProductionLabel.Size = new System.Drawing.Size(165, 22);
            this.forProductionLabel.TabIndex = 82;
            this.forProductionLabel.Text = "ЗА ПОСТАНОВКА:";
            // 
            // datesField
            // 
            this.datesField.AutoSize = true;
            this.datesField.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.datesField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.datesField.Location = new System.Drawing.Point(137, 260);
            this.datesField.Name = "datesField";
            this.datesField.Size = new System.Drawing.Size(184, 22);
            this.datesField.TabIndex = 83;
            this.datesField.Text = "01.03.2020-31.03.2020";
            // 
            // forProductionField
            // 
            this.forProductionField.AutoSize = true;
            this.forProductionField.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.forProductionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.forProductionField.Location = new System.Drawing.Point(171, 284);
            this.forProductionField.Name = "forProductionField";
            this.forProductionField.Size = new System.Drawing.Size(212, 22);
            this.forProductionField.TabIndex = 84;
            this.forProductionField.Text = "ВСИЧКИ ПОСТАНОВКИ";
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.Controls.Add(this.exportItemControl3);
            this.resultPanel.Controls.Add(this.exportItemControl2);
            this.resultPanel.Controls.Add(this.exportItemControl1);
            this.resultPanel.Location = new System.Drawing.Point(6, 359);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(579, 247);
            this.resultPanel.TabIndex = 87;
            // 
            // tableDateLabel
            // 
            this.tableDateLabel.AutoSize = true;
            this.tableDateLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.tableDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableDateLabel.Location = new System.Drawing.Point(10, 320);
            this.tableDateLabel.Name = "tableDateLabel";
            this.tableDateLabel.Size = new System.Drawing.Size(52, 22);
            this.tableDateLabel.TabIndex = 88;
            this.tableDateLabel.Text = "Дата";
            // 
            // tableProductionLabel
            // 
            this.tableProductionLabel.AutoSize = true;
            this.tableProductionLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.tableProductionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableProductionLabel.Location = new System.Drawing.Point(119, 320);
            this.tableProductionLabel.Name = "tableProductionLabel";
            this.tableProductionLabel.Size = new System.Drawing.Size(104, 22);
            this.tableProductionLabel.TabIndex = 90;
            this.tableProductionLabel.Text = "Спектакъл";
            // 
            // tableTicketLabel
            // 
            this.tableTicketLabel.AutoSize = true;
            this.tableTicketLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.tableTicketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableTicketLabel.Location = new System.Drawing.Point(398, 320);
            this.tableTicketLabel.Name = "tableTicketLabel";
            this.tableTicketLabel.Size = new System.Drawing.Size(74, 22);
            this.tableTicketLabel.TabIndex = 91;
            this.tableTicketLabel.Text = "Билети";
            // 
            // tableAmountLabel
            // 
            this.tableAmountLabel.AutoSize = true;
            this.tableAmountLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.tableAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableAmountLabel.Location = new System.Drawing.Point(505, 320);
            this.tableAmountLabel.Name = "tableAmountLabel";
            this.tableAmountLabel.Size = new System.Drawing.Size(55, 22);
            this.tableAmountLabel.TabIndex = 92;
            this.tableAmountLabel.Text = "Сума";
            // 
            // tableSceneLabel
            // 
            this.tableSceneLabel.AutoSize = true;
            this.tableSceneLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.tableSceneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableSceneLabel.Location = new System.Drawing.Point(294, 320);
            this.tableSceneLabel.Name = "tableSceneLabel";
            this.tableSceneLabel.Size = new System.Drawing.Size(64, 22);
            this.tableSceneLabel.TabIndex = 93;
            this.tableSceneLabel.Text = "Сцена";
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.FlatAppearance.BorderSize = 0;
            this.saveToFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToFileBtn.Image = global::TeatrUI.Properties.Resources.save;
            this.saveToFileBtn.Location = new System.Drawing.Point(544, 225);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(33, 33);
            this.saveToFileBtn.TabIndex = 86;
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Image = global::TeatrUI.Properties.Resources.print;
            this.printBtn.Location = new System.Drawing.Point(504, 225);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(33, 33);
            this.printBtn.TabIndex = 85;
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // sumResultLabel
            // 
            this.sumResultLabel.AutoSize = true;
            this.sumResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sumResultLabel.Location = new System.Drawing.Point(341, 611);
            this.sumResultLabel.Name = "sumResultLabel";
            this.sumResultLabel.Size = new System.Drawing.Size(63, 22);
            this.sumResultLabel.TabIndex = 94;
            this.sumResultLabel.Text = "Общо:";
            // 
            // sumResultField
            // 
            this.sumResultField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumResultField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.sumResultField.Location = new System.Drawing.Point(407, 609);
            this.sumResultField.Name = "sumResultField";
            this.sumResultField.Size = new System.Drawing.Size(153, 24);
            this.sumResultField.TabIndex = 95;
            this.sumResultField.Text = "25,000 лв";
            this.sumResultField.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel2.Location = new System.Drawing.Point(6, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 2);
            this.panel2.TabIndex = 105;
            // 
            // exportItemControl3
            // 
            this.exportItemControl3.BackColor = System.Drawing.Color.White;
            this.exportItemControl3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportItemControl3.Location = new System.Drawing.Point(-2, 204);
            this.exportItemControl3.Margin = new System.Windows.Forms.Padding(5);
            this.exportItemControl3.Name = "exportItemControl3";
            this.exportItemControl3.Size = new System.Drawing.Size(556, 63);
            this.exportItemControl3.TabIndex = 2;
            // 
            // exportItemControl2
            // 
            this.exportItemControl2.BackColor = System.Drawing.Color.White;
            this.exportItemControl2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportItemControl2.Location = new System.Drawing.Point(0, 87);
            this.exportItemControl2.Margin = new System.Windows.Forms.Padding(5);
            this.exportItemControl2.Name = "exportItemControl2";
            this.exportItemControl2.Size = new System.Drawing.Size(556, 63);
            this.exportItemControl2.TabIndex = 1;
            // 
            // exportItemControl1
            // 
            this.exportItemControl1.BackColor = System.Drawing.Color.White;
            this.exportItemControl1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportItemControl1.Location = new System.Drawing.Point(0, 2);
            this.exportItemControl1.Margin = new System.Windows.Forms.Padding(5);
            this.exportItemControl1.Name = "exportItemControl1";
            this.exportItemControl1.Size = new System.Drawing.Size(556, 63);
            this.exportItemControl1.TabIndex = 0;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sumResultField);
            this.Controls.Add(this.sumResultLabel);
            this.Controls.Add(this.tableSceneLabel);
            this.Controls.Add(this.tableAmountLabel);
            this.Controls.Add(this.tableTicketLabel);
            this.Controls.Add(this.tableProductionLabel);
            this.Controls.Add(this.tableDateLabel);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.forProductionField);
            this.Controls.Add(this.datesField);
            this.Controls.Add(this.forProductionLabel);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.soldTicketsLabel);
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
            this.resultPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label soldTicketsLabel;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.Label forProductionLabel;
        private System.Windows.Forms.Label datesField;
        private System.Windows.Forms.Label forProductionField;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label tableDateLabel;
        private System.Windows.Forms.Label tableProductionLabel;
        private System.Windows.Forms.Label tableTicketLabel;
        private System.Windows.Forms.Label tableAmountLabel;
        private System.Windows.Forms.Label tableSceneLabel;
        private System.Windows.Forms.Label sumResultLabel;
        private System.Windows.Forms.Label sumResultField;
        private System.Windows.Forms.Panel panel2;
        private UserControls.ExportItemControl exportItemControl3;
        private UserControls.ExportItemControl exportItemControl2;
        private UserControls.ExportItemControl exportItemControl1;
    }
}