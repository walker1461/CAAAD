
namespace UI_New
{
    partial class NewUserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.label31 = new System.Windows.Forms.Label();
            this.ConfirmPassTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpEmailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.ComboBox();
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(258, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 48);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter New User";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(756, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 26);
            this.panel2.TabIndex = 25;
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
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(313, 68);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(202, 55);
            this.label31.TabIndex = 66;
            this.label31.Text = "User Information";
            // 
            // ConfirmPassTxt
            // 
            this.ConfirmPassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.ConfirmPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPassTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ConfirmPassTxt.Location = new System.Drawing.Point(407, 221);
            this.ConfirmPassTxt.Name = "ConfirmPassTxt";
            this.ConfirmPassTxt.Size = new System.Drawing.Size(205, 25);
            this.ConfirmPassTxt.TabIndex = 72;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PasswordTxt.Location = new System.Drawing.Point(368, 174);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(205, 25);
            this.PasswordTxt.TabIndex = 71;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.UserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.UserNameTxt.Location = new System.Drawing.Point(368, 126);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(205, 25);
            this.UserNameTxt.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(225, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(224, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(224, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Username:";
            // 
            // EmpEmailTxt
            // 
            this.EmpEmailTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmpEmailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.EmpEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpEmailTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.EmpEmailTxt.Location = new System.Drawing.Point(407, 272);
            this.EmpEmailTxt.Name = "EmpEmailTxt";
            this.EmpEmailTxt.Size = new System.Drawing.Size(205, 25);
            this.EmpEmailTxt.TabIndex = 74;
            this.EmpEmailTxt.TextChanged += new System.EventHandler(this.EmpEmailTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label5.Location = new System.Drawing.Point(225, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Employee Email:";
            // 
            // CreateUser
            // 
            this.CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.CreateUser.FlatAppearance.BorderSize = 0;
            this.CreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUser.ForeColor = System.Drawing.Color.White;
            this.CreateUser.Location = new System.Drawing.Point(297, 379);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(237, 41);
            this.CreateUser.TabIndex = 75;
            this.CreateUser.Text = "Create User";
            this.CreateUser.UseVisualStyleBackColor = false;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label6.Location = new System.Drawing.Point(225, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 76;
            this.label6.Text = "Admin:";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.Admin.FormattingEnabled = true;
            this.Admin.Location = new System.Drawing.Point(304, 321);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(121, 24);
            this.Admin.TabIndex = 77;
            this.Admin.SelectedIndexChanged += new System.EventHandler(this.Admin_SelectedIndexChanged);
            // 
            // invalid
            // 
            this.invalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalid.AutoSize = true;
            this.invalid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.invalid.Location = new System.Drawing.Point(618, 273);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(134, 24);
            this.invalid.TabIndex = 78;
            this.invalid.Text = "*invalid email";
            this.invalid.Visible = false;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.EmpEmailTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmPassTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox ConfirmPassTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmpEmailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Admin;
        private System.Windows.Forms.Label invalid;
    }
}