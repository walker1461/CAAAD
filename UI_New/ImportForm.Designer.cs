
namespace UI_New
{
    partial class ImportForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.output_lb = new System.Windows.Forms.ListBox();
            this.processedCount_lbl = new System.Windows.Forms.Label();
            this.entriesProcessed_lbl = new System.Windows.Forms.Label();
            this.browse_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filename_txt = new System.Windows.Forms.TextBox();
            this.import_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.output_lb);
            this.panel1.Controls.Add(this.processedCount_lbl);
            this.panel1.Controls.Add(this.entriesProcessed_lbl);
            this.panel1.Controls.Add(this.browse_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.filename_txt);
            this.panel1.Controls.Add(this.import_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 580);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(375, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output_lb
            // 
            this.output_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_lb.FormattingEnabled = true;
            this.output_lb.HorizontalScrollbar = true;
            this.output_lb.ItemHeight = 25;
            this.output_lb.Items.AddRange(new object[] {
            "To begin, enter the filepath and click import or browse for a .csv file above."});
            this.output_lb.Location = new System.Drawing.Point(52, 244);
            this.output_lb.Margin = new System.Windows.Forms.Padding(2);
            this.output_lb.Name = "output_lb";
            this.output_lb.Size = new System.Drawing.Size(472, 179);
            this.output_lb.TabIndex = 20;
            // 
            // processedCount_lbl
            // 
            this.processedCount_lbl.AutoSize = true;
            this.processedCount_lbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedCount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.processedCount_lbl.Location = new System.Drawing.Point(285, 195);
            this.processedCount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.processedCount_lbl.Name = "processedCount_lbl";
            this.processedCount_lbl.Size = new System.Drawing.Size(43, 29);
            this.processedCount_lbl.TabIndex = 19;
            this.processedCount_lbl.Text = "NA";
            // 
            // entriesProcessed_lbl
            // 
            this.entriesProcessed_lbl.AutoSize = true;
            this.entriesProcessed_lbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entriesProcessed_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.entriesProcessed_lbl.Location = new System.Drawing.Point(46, 191);
            this.entriesProcessed_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entriesProcessed_lbl.Name = "entriesProcessed_lbl";
            this.entriesProcessed_lbl.Size = new System.Drawing.Size(239, 33);
            this.entriesProcessed_lbl.TabIndex = 17;
            this.entriesProcessed_lbl.Text = "Records Imported:";
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(425, 131);
            this.browse_btn.Margin = new System.Windows.Forms.Padding(2);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(99, 34);
            this.browse_btn.TabIndex = 16;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(46, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select a CSV file to import";
            // 
            // filename_txt
            // 
            this.filename_txt.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_txt.Location = new System.Drawing.Point(52, 131);
            this.filename_txt.Margin = new System.Windows.Forms.Padding(2);
            this.filename_txt.Name = "filename_txt";
            this.filename_txt.Size = new System.Drawing.Size(366, 34);
            this.filename_txt.TabIndex = 11;
            this.filename_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filename_txt_KeyDown);
            // 
            // import_btn
            // 
            this.import_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.import_btn.FlatAppearance.BorderSize = 0;
            this.import_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_btn.ForeColor = System.Drawing.Color.White;
            this.import_btn.Location = new System.Drawing.Point(52, 472);
            this.import_btn.Margin = new System.Windows.Forms.Padding(2);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(318, 44);
            this.import_btn.TabIndex = 8;
            this.import_btn.Text = "Import";
            this.import_btn.UseVisualStyleBackColor = false;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(362, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 26);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // close_button
            // 
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.close_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
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
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(578, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm_Template1";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filename_txt;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Label entriesProcessed_lbl;
        private System.Windows.Forms.Label processedCount_lbl;
        private System.Windows.Forms.ListBox output_lb;
        private System.Windows.Forms.Button button1;
    }
}