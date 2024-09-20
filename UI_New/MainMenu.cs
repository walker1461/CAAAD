using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
namespace UI_New
{
    public partial class MainMenu : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //main menu username
        public string urName { get; set; }
        public int isAdmin { get; set; }//holds the status of weather or not a user is an admin

        //Constructor
        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            Logo_panel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(244, 122, 96);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(49, 104, 121);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(49, 104, 121);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //load event to display username of current user
        private void MainMenu_Load(object sender, EventArgs e)
        {
            UsermainTxt.Text = urName;//puts the value of urName inside UsermainTxt (name at the top left of the mainmenu page) label on main menu
            if (isAdmin == 0)//if statement to check if the user is an admin
            {
                newUser_button.Visible = false;//hides the newuser button
                editUser_button.Visible = false;//hides the edit user button
            }
        }

        //single click new client button
        private void newClient_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

            //make the description text read-only
            description_text.ReadOnly = true;

            //clear textbox before appending text
            description_text.Clear();

            //append the following text to the textbox
            description_text.AppendText(Environment.NewLine + "By selecting the New Client menu item, you will be able to enter new clients and corresponding information related to the client. To edit an existing client, please select the Edit Client menu item.");
        }



        private void editClient_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

            //make the description text read-only
            description_text.ReadOnly = true;

            //clear textbox before appending text
            description_text.Clear();

            //append the following text to the textbox
            description_text.AppendText(Environment.NewLine + "By selecting Edit Client, you will be able to retrive existing client information and make edits or updates.");
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

            //make the description text read-only
            description_text.ReadOnly = true;

            //clear textbox before appending text
            description_text.Clear();

            //append the following text to the textbox
            description_text.AppendText(Environment.NewLine + "Search the database for a specific client or search the database according to specific parameters. Generate reports based on search parameters.");
        }

        private void newUser_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

            //make the description text read-only
            description_text.ReadOnly = true;

            //clear textbox before appending text
            description_text.Clear();

            //append the following text to the textbox
            description_text.AppendText(Environment.NewLine + "Create a new user for the CAAAD program. Administration accounts only.");
        }

        private void editUser_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

            //make the description text read-only
            description_text.ReadOnly = true;

            //clear textbox before appending text
            description_text.Clear();

            //append the following text to the textbox
            description_text.AppendText(Environment.NewLine + "Edit existing users of the CAAAD program. Administration accounts only.");
        }
        private void importData_button_Click(object sender, EventArgs e)
        {
            //change color of button when selected
            ActivateButton(sender, RGBColors.color7);

            //make the description text read-only
            description_text.ReadOnly = true;

            //clear textbox before appending text
            description_text.Clear();

            description_text.AppendText(Environment.NewLine + "Select a Comma Separated Value (CSV) file to import new and update existing clients from.");
        }

        //drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void user_button_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_button_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //open forms
        private void select_button_Click(object sender, EventArgs e)
        {
            if (currentBtn == newClient_button)
            {
                NewClientForm newClientForm = new NewClientForm();
                newClientForm.ShowDialog();
            }

            else if (currentBtn == editClient_button)
            {
                // open search with intent of editing
                ReportForm reportForm = new ReportForm(true);
                reportForm.ShowDialog();
            }
            else if (currentBtn == search_button)
            {
                ReportForm reportForm = new ReportForm();
                reportForm.ShowDialog();
            }
            else if (currentBtn == newUser_button)
            {
                NewUserForm newUserForm = new NewUserForm();
                newUserForm.ShowDialog();
            }
            else if (currentBtn == editUser_button)
            {
                EditUserForm editUserForm = new EditUserForm();
                editUserForm.urName1 = urName;
                editUserForm.ShowDialog();
            }
            else if (currentBtn == importData_button)
            {
                ImportForm importForm = new ImportForm();
                importForm.ShowDialog();
            }

        }

        
    }
}
