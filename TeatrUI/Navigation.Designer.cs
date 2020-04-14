namespace TeatrUI
{
    partial class Navigation
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
            this.userPhotoField = new System.Windows.Forms.PictureBox();
            this.userNameField = new System.Windows.Forms.Label();
            this.userRoleField = new System.Windows.Forms.Label();
            this.homeNavBtn = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.Panel();
            this.programNavBtn = new System.Windows.Forms.Button();
            this.productionsNavBtn = new System.Windows.Forms.Button();
            this.exportsNavBtn = new System.Windows.Forms.Button();
            this.personNavBtn = new System.Windows.Forms.Button();
            this.usersNavBtn = new System.Windows.Forms.Button();
            this.infoBtnNav = new System.Windows.Forms.Button();
            this.scenesNavBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoField)).BeginInit();
            this.SuspendLayout();
            // 
            // userPhotoField
            // 
            this.userPhotoField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPhotoField.Location = new System.Drawing.Point(29, 29);
            this.userPhotoField.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.userPhotoField.Name = "userPhotoField";
            this.userPhotoField.Size = new System.Drawing.Size(100, 100);
            this.userPhotoField.TabIndex = 0;
            this.userPhotoField.TabStop = false;
            this.userPhotoField.Click += new System.EventHandler(this.userPhotoField_Click);
            // 
            // userNameField
            // 
            this.userNameField.AutoSize = true;
            this.userNameField.BackColor = System.Drawing.Color.Transparent;
            this.userNameField.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(142, 40);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(98, 22);
            this.userNameField.TabIndex = 1;
            this.userNameField.Text = "Симона Н.";
            // 
            // userRoleField
            // 
            this.userRoleField.AutoSize = true;
            this.userRoleField.BackColor = System.Drawing.Color.Transparent;
            this.userRoleField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.userRoleField.Location = new System.Drawing.Point(142, 62);
            this.userRoleField.Name = "userRoleField";
            this.userRoleField.Size = new System.Drawing.Size(141, 22);
            this.userRoleField.TabIndex = 2;
            this.userRoleField.Text = "администратор";
            // 
            // homeNavBtn
            // 
            this.homeNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeNavBtn.FlatAppearance.BorderSize = 0;
            this.homeNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.homeNavBtn.Image = global::TeatrUI.Properties.Resources.grid_view_line;
            this.homeNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeNavBtn.Location = new System.Drawing.Point(29, 184);
            this.homeNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.homeNavBtn.Name = "homeNavBtn";
            this.homeNavBtn.Size = new System.Drawing.Size(262, 45);
            this.homeNavBtn.TabIndex = 3;
            this.homeNavBtn.TabStop = false;
            this.homeNavBtn.Text = "         НАЧАЛО";
            this.homeNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeNavBtn.UseVisualStyleBackColor = false;
            this.homeNavBtn.Click += new System.EventHandler(this.homeNavBtn_Click);
            // 
            // selector
            // 
            this.selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(162)))), ((int)(((byte)(135)))));
            this.selector.Location = new System.Drawing.Point(0, 184);
            this.selector.Margin = new System.Windows.Forms.Padding(0);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(10, 45);
            this.selector.TabIndex = 4;
            // 
            // programNavBtn
            // 
            this.programNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.programNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programNavBtn.FlatAppearance.BorderSize = 0;
            this.programNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.programNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.programNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.programNavBtn.Image = global::TeatrUI.Properties.Resources.pinboard_line;
            this.programNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programNavBtn.Location = new System.Drawing.Point(29, 235);
            this.programNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.programNavBtn.Name = "programNavBtn";
            this.programNavBtn.Size = new System.Drawing.Size(262, 45);
            this.programNavBtn.TabIndex = 13;
            this.programNavBtn.TabStop = false;
            this.programNavBtn.Text = "         ПРОГРАМА";
            this.programNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programNavBtn.UseVisualStyleBackColor = false;
            this.programNavBtn.Click += new System.EventHandler(this.programNavBtn_Click);
            // 
            // productionsNavBtn
            // 
            this.productionsNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.productionsNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionsNavBtn.FlatAppearance.BorderSize = 0;
            this.productionsNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.productionsNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.productionsNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productionsNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionsNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.productionsNavBtn.Image = global::TeatrUI.Properties.Resources.bank_line;
            this.productionsNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productionsNavBtn.Location = new System.Drawing.Point(29, 286);
            this.productionsNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.productionsNavBtn.Name = "productionsNavBtn";
            this.productionsNavBtn.Size = new System.Drawing.Size(262, 45);
            this.productionsNavBtn.TabIndex = 14;
            this.productionsNavBtn.TabStop = false;
            this.productionsNavBtn.Text = "         СПЕКТАКЛИ";
            this.productionsNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productionsNavBtn.UseVisualStyleBackColor = false;
            this.productionsNavBtn.Click += new System.EventHandler(this.productionsNavBtn_Click);
            // 
            // exportsNavBtn
            // 
            this.exportsNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.exportsNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportsNavBtn.FlatAppearance.BorderSize = 0;
            this.exportsNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exportsNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exportsNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportsNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportsNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.exportsNavBtn.Image = global::TeatrUI.Properties.Resources.layers_line;
            this.exportsNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportsNavBtn.Location = new System.Drawing.Point(29, 337);
            this.exportsNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.exportsNavBtn.Name = "exportsNavBtn";
            this.exportsNavBtn.Size = new System.Drawing.Size(262, 45);
            this.exportsNavBtn.TabIndex = 15;
            this.exportsNavBtn.TabStop = false;
            this.exportsNavBtn.Text = "         ОТЧЕТИ";
            this.exportsNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportsNavBtn.UseVisualStyleBackColor = false;
            this.exportsNavBtn.Click += new System.EventHandler(this.exportsNavBtn_Click);
            // 
            // personNavBtn
            // 
            this.personNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.personNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personNavBtn.FlatAppearance.BorderSize = 0;
            this.personNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.personNavBtn.Image = global::TeatrUI.Properties.Resources.users_line;
            this.personNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personNavBtn.Location = new System.Drawing.Point(29, 425);
            this.personNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.personNavBtn.Name = "personNavBtn";
            this.personNavBtn.Size = new System.Drawing.Size(262, 45);
            this.personNavBtn.TabIndex = 16;
            this.personNavBtn.TabStop = false;
            this.personNavBtn.Text = "         ТВОРЧЕСКИ СЪСТАВ";
            this.personNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personNavBtn.UseVisualStyleBackColor = false;
            this.personNavBtn.Click += new System.EventHandler(this.personNavBtn_Click);
            // 
            // usersNavBtn
            // 
            this.usersNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.usersNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersNavBtn.FlatAppearance.BorderSize = 0;
            this.usersNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.usersNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.usersNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.usersNavBtn.Image = global::TeatrUI.Properties.Resources.employee_group_line;
            this.usersNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersNavBtn.Location = new System.Drawing.Point(29, 476);
            this.usersNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.usersNavBtn.Name = "usersNavBtn";
            this.usersNavBtn.Size = new System.Drawing.Size(262, 45);
            this.usersNavBtn.TabIndex = 17;
            this.usersNavBtn.TabStop = false;
            this.usersNavBtn.Text = "         ПОТРЕБИТЕЛИ";
            this.usersNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersNavBtn.UseVisualStyleBackColor = false;
            this.usersNavBtn.Click += new System.EventHandler(this.usersNavBtn_Click);
            // 
            // infoBtnNav
            // 
            this.infoBtnNav.BackColor = System.Drawing.Color.Transparent;
            this.infoBtnNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtnNav.FlatAppearance.BorderSize = 0;
            this.infoBtnNav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.infoBtnNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.infoBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtnNav.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtnNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.infoBtnNav.Image = global::TeatrUI.Properties.Resources.help_line;
            this.infoBtnNav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoBtnNav.Location = new System.Drawing.Point(29, 627);
            this.infoBtnNav.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.infoBtnNav.Name = "infoBtnNav";
            this.infoBtnNav.Size = new System.Drawing.Size(262, 45);
            this.infoBtnNav.TabIndex = 19;
            this.infoBtnNav.TabStop = false;
            this.infoBtnNav.Text = "         ИНФО";
            this.infoBtnNav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoBtnNav.UseVisualStyleBackColor = false;
            this.infoBtnNav.Click += new System.EventHandler(this.infoBtnNav_Click);
            // 
            // scenesNavBtn
            // 
            this.scenesNavBtn.BackColor = System.Drawing.Color.Transparent;
            this.scenesNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenesNavBtn.FlatAppearance.BorderSize = 0;
            this.scenesNavBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.scenesNavBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.scenesNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scenesNavBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scenesNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scenesNavBtn.Image = global::TeatrUI.Properties.Resources.heat_map_line;
            this.scenesNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scenesNavBtn.Location = new System.Drawing.Point(29, 527);
            this.scenesNavBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.scenesNavBtn.Name = "scenesNavBtn";
            this.scenesNavBtn.Size = new System.Drawing.Size(262, 45);
            this.scenesNavBtn.TabIndex = 18;
            this.scenesNavBtn.TabStop = false;
            this.scenesNavBtn.Text = "         СЦЕНИ";
            this.scenesNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scenesNavBtn.UseVisualStyleBackColor = false;
            this.scenesNavBtn.Click += new System.EventHandler(this.scenesNavBtn_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TeatrUI.Properties.Resources.navBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 710);
            this.Controls.Add(this.infoBtnNav);
            this.Controls.Add(this.scenesNavBtn);
            this.Controls.Add(this.usersNavBtn);
            this.Controls.Add(this.personNavBtn);
            this.Controls.Add(this.exportsNavBtn);
            this.Controls.Add(this.productionsNavBtn);
            this.Controls.Add(this.programNavBtn);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.homeNavBtn);
            this.Controls.Add(this.userRoleField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.userPhotoField);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Navigation";
            this.Text = "Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPhotoField;
        private System.Windows.Forms.Label userNameField;
        private System.Windows.Forms.Label userRoleField;
        private System.Windows.Forms.Button homeNavBtn;
        private System.Windows.Forms.Panel selector;
        private System.Windows.Forms.Button programNavBtn;
        private System.Windows.Forms.Button productionsNavBtn;
        private System.Windows.Forms.Button exportsNavBtn;
        private System.Windows.Forms.Button personNavBtn;
        private System.Windows.Forms.Button usersNavBtn;
        private System.Windows.Forms.Button infoBtnNav;
        private System.Windows.Forms.Button scenesNavBtn;
    }
}