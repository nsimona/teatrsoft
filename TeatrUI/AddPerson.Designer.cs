namespace TeatrUI
{
    partial class AddPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.personPic = new System.Windows.Forms.PictureBox();
            this.archiveBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(0, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(0, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(0, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Имейл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(335, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Снимка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label7.Location = new System.Drawing.Point(0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(502, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "ДОБАВЯНЕ/ РЕДАКТИРАНЕ НА СЛУЖИТЕЛ\r\n";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(0, 118);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(300, 27);
            this.name.TabIndex = 15;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(0, 243);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(300, 27);
            this.phone.TabIndex = 16;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(0, 304);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(300, 27);
            this.mail.TabIndex = 17;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.White;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(0, 179);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(300, 30);
            this.category.TabIndex = 18;
            // 
            // personPic
            // 
            this.personPic.Location = new System.Drawing.Point(339, 118);
            this.personPic.Name = "personPic";
            this.personPic.Size = new System.Drawing.Size(233, 275);
            this.personPic.TabIndex = 9;
            this.personPic.TabStop = false;
            this.personPic.Click += new System.EventHandler(this.personPic_Click);
            // 
            // archiveBtn
            // 
            this.archiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.archiveBtn.Enabled = false;
            this.archiveBtn.FlatAppearance.BorderSize = 0;
            this.archiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveBtn.ForeColor = System.Drawing.Color.White;
            this.archiveBtn.Location = new System.Drawing.Point(448, 423);
            this.archiveBtn.Name = "archiveBtn";
            this.archiveBtn.Size = new System.Drawing.Size(130, 30);
            this.archiveBtn.TabIndex = 34;
            this.archiveBtn.Text = "АХИВИРАНЕ";
            this.archiveBtn.UseVisualStyleBackColor = false;
            this.archiveBtn.Click += new System.EventHandler(this.archiveBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(337, 423);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "ЗАПИС";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.archiveBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.category);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.personPic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddPerson";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox personPic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button archiveBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}