
namespace UI_New
{
    partial class EditUserForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.User1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchUser = new System.Windows.Forms.Button();
            this.UserNameTxt2 = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.ComboBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.User2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.EmplEmailTxt = new System.Windows.Forms.TextBox();
            this.EmployeeEmail = new System.Windows.Forms.Label();
            this.invalid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(298, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 48);
            this.label3.TabIndex = 17;
            this.label3.Text = "Edit User";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.UserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.UserNameTxt.Location = new System.Drawing.Point(285, 136);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(205, 25);
            this.UserNameTxt.TabIndex = 71;
            // 
            // User1
            // 
            this.User1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User1.AutoSize = true;
            this.User1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.User1.Location = new System.Drawing.Point(170, 136);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(107, 24);
            this.User1.TabIndex = 72;
            this.User1.Text = "Username:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(288, 191);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(202, 55);
            this.label31.TabIndex = 73;
            this.label31.Text = "User Information";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 55);
            this.label1.TabIndex = 74;
            this.label1.Text = "Enter Username";
            // 
            // SearchUser
            // 
            this.SearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.SearchUser.FlatAppearance.BorderSize = 0;
            this.SearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchUser.ForeColor = System.Drawing.Color.White;
            this.SearchUser.Location = new System.Drawing.Point(511, 128);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(237, 41);
            this.SearchUser.TabIndex = 76;
            this.SearchUser.Text = "Search User";
            this.SearchUser.UseVisualStyleBackColor = false;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // UserNameTxt2
            // 
            this.UserNameTxt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.UserNameTxt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxt2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.UserNameTxt2.Location = new System.Drawing.Point(285, 252);
            this.UserNameTxt2.Name = "UserNameTxt2";
            this.UserNameTxt2.Size = new System.Drawing.Size(205, 25);
            this.UserNameTxt2.TabIndex = 77;
            // 
            // Ad
            // 
            this.Ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.Ad.Location = new System.Drawing.Point(206, 339);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(73, 24);
            this.Ad.TabIndex = 80;
            this.Ad.Text = "Admin:";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.Admin.FormattingEnabled = true;
            this.Admin.Location = new System.Drawing.Point(285, 339);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(121, 24);
            this.Admin.TabIndex = 81;
            this.Admin.SelectedIndexChanged += new System.EventHandler(this.Admin_SelectedIndexChanged);
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.DeleteUser.FlatAppearance.BorderSize = 0;
            this.DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser.ForeColor = System.Drawing.Color.White;
            this.DeleteUser.Location = new System.Drawing.Point(511, 244);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(237, 41);
            this.DeleteUser.TabIndex = 82;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // User2
            // 
            this.User2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User2.AutoSize = true;
            this.User2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.User2.Location = new System.Drawing.Point(172, 252);
            this.User2.Name = "User2";
            this.User2.Size = new System.Drawing.Size(107, 24);
            this.User2.TabIndex = 84;
            this.User2.Text = "Username:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(270, 382);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(237, 41);
            this.SaveBtn.TabIndex = 85;
            this.SaveBtn.Text = "Save Edit";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(756, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 26);
            this.panel2.TabIndex = 86;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.close_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.close_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_button.IconSize = 60;
            this.close_button.Location = new System.Drawing.Point(7, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 26);
            this.close_button.TabIndex = 2;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click_1);
            // 
            // EmplEmailTxt
            // 
            this.EmplEmailTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmplEmailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.EmplEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmplEmailTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.EmplEmailTxt.Location = new System.Drawing.Point(285, 292);
            this.EmplEmailTxt.Name = "EmplEmailTxt";
            this.EmplEmailTxt.Size = new System.Drawing.Size(205, 25);
            this.EmplEmailTxt.TabIndex = 87;
            this.EmplEmailTxt.TextChanged += new System.EventHandler(this.EmplEmailTxt_TextChanged);
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeEmail.AutoSize = true;
            this.EmployeeEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.EmployeeEmail.Location = new System.Drawing.Point(118, 293);
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.Size = new System.Drawing.Size(159, 24);
            this.EmployeeEmail.TabIndex = 88;
            this.EmployeeEmail.Text = "Employee Email:";
            // 
            // invalid
            // 
            this.invalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalid.AutoSize = true;
            this.invalid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.invalid.Location = new System.Drawing.Point(507, 293);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(134, 24);
            this.invalid.TabIndex = 89;
            this.invalid.Text = "*invalid email";
            this.invalid.Visible = false;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.EmployeeEmail);
            this.Controls.Add(this.EmplEmailTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.User2);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.UserNameTxt2);
            this.Controls.Add(this.SearchUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.User1);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label User1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.TextBox UserNameTxt2;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.ComboBox Admin;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Label User2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private System.Windows.Forms.TextBox EmplEmailTxt;
        private System.Windows.Forms.Label EmployeeEmail;
        private System.Windows.Forms.Label invalid;
    }
}