
namespace UI_New
{
    partial class ReportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterNewClientLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.maximize_button = new FontAwesome.Sharp.IconButton();
            this.minimize_button = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.clientInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.enterDateTxt = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.enterStateCbox = new System.Windows.Forms.ComboBox();
            this.enterMaritalStatusCbox = new System.Windows.Forms.ComboBox();
            this.enterIncomeTxt = new System.Windows.Forms.TextBox();
            this.enterHouseholdTxt = new System.Windows.Forms.TextBox();
            this.searchLastTxt = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.enterCityTxt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enterApartmentTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enterDobTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.enterPhoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enterZipTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enterPOTxt = new System.Windows.Forms.TextBox();
            this.first_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchFirstTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchAddressTxt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enterCommentsTxt = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.searchClientBtn = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.clientInformationGroupBox.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.enterNewClientLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1872, 58);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // enterNewClientLbl
            // 
            this.enterNewClientLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterNewClientLbl.AutoSize = true;
            this.enterNewClientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.enterNewClientLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterNewClientLbl.Location = new System.Drawing.Point(806, 5);
            this.enterNewClientLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterNewClientLbl.Name = "enterNewClientLbl";
            this.enterNewClientLbl.Size = new System.Drawing.Size(260, 46);
            this.enterNewClientLbl.TabIndex = 103;
            this.enterNewClientLbl.Text = "Search Client";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.maximize_button);
            this.panel2.Controls.Add(this.minimize_button);
            this.panel2.Location = new System.Drawing.Point(1668, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 26);
            this.panel2.TabIndex = 102;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // close_button
            // 
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.close_button.IconColor = System.Drawing.Color.Gainsboro;
            this.close_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_button.IconSize = 60;
            this.close_button.Location = new System.Drawing.Point(177, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 26);
            this.close_button.TabIndex = 2;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_button_MouseClick);
            // 
            // maximize_button
            // 
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.maximize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize_button.IconColor = System.Drawing.Color.Gainsboro;
            this.maximize_button.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.maximize_button.IconSize = 25;
            this.maximize_button.Location = new System.Drawing.Point(148, -2);
            this.maximize_button.Margin = new System.Windows.Forms.Padding(2);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(25, 26);
            this.maximize_button.TabIndex = 1;
            this.maximize_button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.maximize_button.UseVisualStyleBackColor = true;
            this.maximize_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maximize_button_MouseClick);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.minimize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize_button.IconColor = System.Drawing.Color.Gainsboro;
            this.minimize_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimize_button.Location = new System.Drawing.Point(116, -2);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(2);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(25, 26);
            this.minimize_button.TabIndex = 0;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimize_button_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.clientInformationGroupBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 6);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1847, 401);
            this.flowLayoutPanel2.TabIndex = 90;
            // 
            // clientInformationGroupBox
            // 
            this.clientInformationGroupBox.Controls.Add(this.enterDateTxt);
            this.clientInformationGroupBox.Controls.Add(this.dateLbl);
            this.clientInformationGroupBox.Controls.Add(this.enterStateCbox);
            this.clientInformationGroupBox.Controls.Add(this.enterMaritalStatusCbox);
            this.clientInformationGroupBox.Controls.Add(this.enterIncomeTxt);
            this.clientInformationGroupBox.Controls.Add(this.enterHouseholdTxt);
            this.clientInformationGroupBox.Controls.Add(this.searchLastTxt);
            this.clientInformationGroupBox.Controls.Add(this.label32);
            this.clientInformationGroupBox.Controls.Add(this.label31);
            this.clientInformationGroupBox.Controls.Add(this.enterCityTxt);
            this.clientInformationGroupBox.Controls.Add(this.label30);
            this.clientInformationGroupBox.Controls.Add(this.label2);
            this.clientInformationGroupBox.Controls.Add(this.label7);
            this.clientInformationGroupBox.Controls.Add(this.enterApartmentTxt);
            this.clientInformationGroupBox.Controls.Add(this.label3);
            this.clientInformationGroupBox.Controls.Add(this.enterDobTxt);
            this.clientInformationGroupBox.Controls.Add(this.label9);
            this.clientInformationGroupBox.Controls.Add(this.enterPhoneTxt);
            this.clientInformationGroupBox.Controls.Add(this.label4);
            this.clientInformationGroupBox.Controls.Add(this.enterZipTxt);
            this.clientInformationGroupBox.Controls.Add(this.label8);
            this.clientInformationGroupBox.Controls.Add(this.label5);
            this.clientInformationGroupBox.Controls.Add(this.enterPOTxt);
            this.clientInformationGroupBox.Controls.Add(this.first_lbl);
            this.clientInformationGroupBox.Controls.Add(this.label6);
            this.clientInformationGroupBox.Controls.Add(this.searchFirstTxt);
            this.clientInformationGroupBox.Controls.Add(this.label1);
            this.clientInformationGroupBox.Controls.Add(this.searchAddressTxt);
            this.clientInformationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientInformationGroupBox.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInformationGroupBox.Location = new System.Drawing.Point(2, 2);
            this.clientInformationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientInformationGroupBox.Name = "clientInformationGroupBox";
            this.clientInformationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.clientInformationGroupBox.Size = new System.Drawing.Size(1856, 382);
            this.clientInformationGroupBox.TabIndex = 0;
            this.clientInformationGroupBox.TabStop = false;
            this.clientInformationGroupBox.Text = "Client Information";
            // 
            // enterDateTxt
            // 
            this.enterDateTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterDateTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterDateTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDateTxt.Location = new System.Drawing.Point(352, 62);
            this.enterDateTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterDateTxt.Name = "enterDateTxt";
            this.enterDateTxt.Size = new System.Drawing.Size(242, 29);
            this.enterDateTxt.TabIndex = 77;
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(78, 51);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.dateLbl.Size = new System.Drawing.Size(195, 49);
            this.dateLbl.TabIndex = 76;
            this.dateLbl.Text = "Date Admitted:";
            // 
            // enterStateCbox
            // 
            this.enterStateCbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterStateCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterStateCbox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterStateCbox.FormattingEnabled = true;
            this.enterStateCbox.Items.AddRange(new object[] {
            "NC",
            "SC"});
            this.enterStateCbox.Location = new System.Drawing.Point(946, 169);
            this.enterStateCbox.Margin = new System.Windows.Forms.Padding(2);
            this.enterStateCbox.Name = "enterStateCbox";
            this.enterStateCbox.Size = new System.Drawing.Size(243, 36);
            this.enterStateCbox.TabIndex = 75;
            // 
            // enterMaritalStatusCbox
            // 
            this.enterMaritalStatusCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterMaritalStatusCbox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterMaritalStatusCbox.FormattingEnabled = true;
            this.enterMaritalStatusCbox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widow"});
            this.enterMaritalStatusCbox.Location = new System.Drawing.Point(1534, 168);
            this.enterMaritalStatusCbox.Margin = new System.Windows.Forms.Padding(2);
            this.enterMaritalStatusCbox.Name = "enterMaritalStatusCbox";
            this.enterMaritalStatusCbox.Size = new System.Drawing.Size(243, 36);
            this.enterMaritalStatusCbox.TabIndex = 68;
            // 
            // enterIncomeTxt
            // 
            this.enterIncomeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterIncomeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterIncomeTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIncomeTxt.Location = new System.Drawing.Point(1536, 116);
            this.enterIncomeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterIncomeTxt.Name = "enterIncomeTxt";
            this.enterIncomeTxt.Size = new System.Drawing.Size(242, 29);
            this.enterIncomeTxt.TabIndex = 67;
            // 
            // enterHouseholdTxt
            // 
            this.enterHouseholdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterHouseholdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterHouseholdTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterHouseholdTxt.Location = new System.Drawing.Point(1536, 228);
            this.enterHouseholdTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterHouseholdTxt.Name = "enterHouseholdTxt";
            this.enterHouseholdTxt.Size = new System.Drawing.Size(242, 29);
            this.enterHouseholdTxt.TabIndex = 66;
            // 
            // searchLastTxt
            // 
            this.searchLastTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchLastTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.searchLastTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchLastTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLastTxt.Location = new System.Drawing.Point(352, 120);
            this.searchLastTxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchLastTxt.Name = "searchLastTxt";
            this.searchLastTxt.Size = new System.Drawing.Size(242, 29);
            this.searchLastTxt.TabIndex = 32;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(674, 218);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label32.Size = new System.Drawing.Size(135, 49);
            this.label32.TabIndex = 30;
            this.label32.Text = "Zip Code:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(674, 51);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label31.Size = new System.Drawing.Size(170, 49);
            this.label31.TabIndex = 29;
            this.label31.Text = "Apt Number:";
            // 
            // enterCityTxt
            // 
            this.enterCityTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterCityTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterCityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterCityTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCityTxt.Location = new System.Drawing.Point(946, 116);
            this.enterCityTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterCityTxt.Name = "enterCityTxt";
            this.enterCityTxt.Size = new System.Drawing.Size(242, 29);
            this.enterCityTxt.TabIndex = 62;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(78, 282);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label30.Size = new System.Drawing.Size(134, 49);
            this.label30.TabIndex = 28;
            this.label30.Text = "P.O. Box:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label2.Size = new System.Drawing.Size(199, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Street Address:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(674, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label7.Size = new System.Drawing.Size(98, 49);
            this.label7.TabIndex = 25;
            this.label7.Text = "State:";
            // 
            // enterApartmentTxt
            // 
            this.enterApartmentTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterApartmentTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterApartmentTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterApartmentTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterApartmentTxt.Location = new System.Drawing.Point(946, 61);
            this.enterApartmentTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterApartmentTxt.Name = "enterApartmentTxt";
            this.enterApartmentTxt.Size = new System.Drawing.Size(242, 29);
            this.enterApartmentTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label3.Size = new System.Drawing.Size(82, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "City:";
            // 
            // enterDobTxt
            // 
            this.enterDobTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterDobTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterDobTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterDobTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDobTxt.Location = new System.Drawing.Point(1534, 64);
            this.enterDobTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterDobTxt.Name = "enterDobTxt";
            this.enterDobTxt.Size = new System.Drawing.Size(242, 29);
            this.enterDobTxt.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1264, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label9.Size = new System.Drawing.Size(203, 49);
            this.label9.TabIndex = 27;
            this.label9.Text = "Household Size:";
            // 
            // enterPhoneTxt
            // 
            this.enterPhoneTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterPhoneTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterPhoneTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPhoneTxt.Location = new System.Drawing.Point(946, 282);
            this.enterPhoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterPhoneTxt.Name = "enterPhoneTxt";
            this.enterPhoneTxt.Size = new System.Drawing.Size(242, 29);
            this.enterPhoneTxt.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1262, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label4.Size = new System.Drawing.Size(179, 49);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date of Birth:";
            // 
            // enterZipTxt
            // 
            this.enterZipTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterZipTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterZipTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterZipTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterZipTxt.Location = new System.Drawing.Point(946, 229);
            this.enterZipTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterZipTxt.Name = "enterZipTxt";
            this.enterZipTxt.Size = new System.Drawing.Size(242, 29);
            this.enterZipTxt.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label8.Size = new System.Drawing.Size(200, 49);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1264, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label5.Size = new System.Drawing.Size(122, 49);
            this.label5.TabIndex = 21;
            this.label5.Text = "Income:";
            // 
            // enterPOTxt
            // 
            this.enterPOTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterPOTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterPOTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterPOTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPOTxt.Location = new System.Drawing.Point(352, 294);
            this.enterPOTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterPOTxt.Name = "enterPOTxt";
            this.enterPOTxt.Size = new System.Drawing.Size(242, 29);
            this.enterPOTxt.TabIndex = 4;
            // 
            // first_lbl
            // 
            this.first_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.first_lbl.AutoSize = true;
            this.first_lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_lbl.Location = new System.Drawing.Point(78, 168);
            this.first_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first_lbl.Name = "first_lbl";
            this.first_lbl.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.first_lbl.Size = new System.Drawing.Size(159, 49);
            this.first_lbl.TabIndex = 1;
            this.first_lbl.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1262, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label6.Size = new System.Drawing.Size(189, 49);
            this.label6.TabIndex = 23;
            this.label6.Text = "Marital Status:";
            // 
            // searchFirstTxt
            // 
            this.searchFirstTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchFirstTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.searchFirstTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchFirstTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFirstTxt.Location = new System.Drawing.Point(352, 178);
            this.searchFirstTxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchFirstTxt.Name = "searchFirstTxt";
            this.searchFirstTxt.Size = new System.Drawing.Size(242, 29);
            this.searchFirstTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label1.Size = new System.Drawing.Size(157, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // searchAddressTxt
            // 
            this.searchAddressTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchAddressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.searchAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchAddressTxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAddressTxt.Location = new System.Drawing.Point(352, 236);
            this.searchAddressTxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchAddressTxt.Name = "searchAddressTxt";
            this.searchAddressTxt.Size = new System.Drawing.Size(242, 29);
            this.searchAddressTxt.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.groupBox3);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(12, 420);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1457, 192);
            this.flowLayoutPanel5.TabIndex = 93;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enterCommentsTxt);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1472, 172);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comments";
            // 
            // enterCommentsTxt
            // 
            this.enterCommentsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.enterCommentsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterCommentsTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterCommentsTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCommentsTxt.Location = new System.Drawing.Point(2, 27);
            this.enterCommentsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.enterCommentsTxt.Multiline = true;
            this.enterCommentsTxt.Name = "enterCommentsTxt";
            this.enterCommentsTxt.Size = new System.Drawing.Size(1468, 143);
            this.enterCommentsTxt.TabIndex = 72;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(504, 422);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(305, 29);
            this.textBox13.TabIndex = 90;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(59, 410);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label20.Size = new System.Drawing.Size(103, 49);
            this.label20.TabIndex = 89;
            this.label20.Text = "Other:";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(20, 569);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(211, 22);
            this.checkBox11.TabIndex = 87;
            this.checkBox11.Text = "check all services that apply";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // searchClientBtn
            // 
            this.searchClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.searchClientBtn.FlatAppearance.BorderSize = 0;
            this.searchClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchClientBtn.Font = new System.Drawing.Font("Tahoma", 13.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.searchClientBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.searchClientBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.searchClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchClientBtn.Location = new System.Drawing.Point(1495, 424);
            this.searchClientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchClientBtn.Name = "searchClientBtn";
            this.searchClientBtn.Size = new System.Drawing.Size(365, 189);
            this.searchClientBtn.TabIndex = 94;
            this.searchClientBtn.Text = "Search Client";
            this.searchClientBtn.UseVisualStyleBackColor = false;
            this.searchClientBtn.Click += new System.EventHandler(this.searchClientBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.panel4.Controls.Add(this.searchClientBtn);
            this.panel4.Controls.Add(this.flowLayoutPanel5);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1872, 1872);
            this.panel4.TabIndex = 91;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1872, 1050);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.clientInformationGroupBox.ResumeLayout(false);
            this.clientInformationGroupBox.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private FontAwesome.Sharp.IconButton maximize_button;
        private FontAwesome.Sharp.IconButton minimize_button;
        private System.Windows.Forms.Label enterNewClientLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox clientInformationGroupBox;
        private System.Windows.Forms.TextBox enterDateTxt;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox enterStateCbox;
        private System.Windows.Forms.ComboBox enterMaritalStatusCbox;
        private System.Windows.Forms.TextBox enterIncomeTxt;
        private System.Windows.Forms.TextBox enterHouseholdTxt;
        private System.Windows.Forms.TextBox searchLastTxt;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox enterCityTxt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox enterApartmentTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enterDobTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox enterPhoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enterZipTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enterPOTxt;
        private System.Windows.Forms.Label first_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchFirstTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchAddressTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox enterCommentsTxt;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBox11;
        private FontAwesome.Sharp.IconButton searchClientBtn;
        private System.Windows.Forms.Panel panel4;
    }
}