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
using MySql.Data.MySqlClient;

namespace UI_New
{
    public partial class LoginForm : Form
    {
        private void LoginForm_Load(object sender, EventArgs e) //form load event
        {
            // when form loads connect to DB and see if there are any entires in the login table
                string Myconn = "server = localhost; user id = my.morrisc6; password = team2; SslMode=Preferred; persistsecurityinfo = True; database = my_morrisc6_template1";
            MySqlConnection conn = new MySqlConnection(Myconn);
            MySqlCommand cmd = new MySqlCommand("select * from login", conn);//mysql query command
            conn.Open();

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);//actually runs the query
            if (dt.Rows.Count == 0)//check to see if any rows are returned. if none then the program is being run for the first time
            {
                firstTimebtn.Visible = true; // set first time btn to visible
            }
            else // if any amount of rows are returned then this is not the first time the program has been run 
            {
                firstTimebtn.Visible = false; // set first time button to inivisible
            }
            conn.Dispose();
        }
        //fields
        //private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public LoginForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //Logo_panel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UserIcon_pbox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //close button
        private void close_button_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "" && PasswordTxt.Text == "")//checks to make sure the user name and the password are not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Username and password fields are empty. Please enter a username and password to login", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UsernameTxt.Text == "")//checks to make sure the username is not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Username field is empty. Please enter Username to continue", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTxt.Text == "")//checks to make sure the password is not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Password field is empty. Please enter Password to continue", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (UsernameTxt.Text != "" && PasswordTxt.Text != "")
            {
                //mysql connection stuff
                string Myconn = "server = localhost; user id = my.morrisc6; password = team2; persistsecurityinfo = True; database = my_morrisc6_template1";
                MySqlConnection conn = new MySqlConnection(Myconn);
                MySqlCommand cmd = new MySqlCommand("select * from login where binary username=@Username and admin = 1 OR binary username=@Username and admin = 0 ", conn);//mysql query command
                conn.Open();
                MySqlDataReader reader;//declare sql reader
                cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);
                //cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);//actually runs the query
                int Admin = 0;//admin var to change
                bool match = false;
                using (reader = cmd.ExecuteReader())//
                {
                    while (reader.Read())//reads while data is in querey results
                    {
                        if ((int)reader["admin"] == 0)// checks if admin tab in db is 0
                        {
                            
                            Admin = 0;//set admin to 0
                        }
                        else if ((int)reader["admin"] == 1)//checks if admin tab in db is 1
                        {
                            
                            Admin = 1;//set admin to 1
                        }
                        if (BCrypt.Net.BCrypt.Verify(PasswordTxt.Text, (string)reader["password"])) // if entered password matches the hashed password in DB set match = true
                            {
                            match = true;
                                }
                    }
                }
                if (dt.Rows.Count > 0)//looks through table for the requested credentials 
                {
                    if (match == true)
                    {

                        MainMenu f2 = new MainMenu();//if credentials are found move them to the next page
                        f2.urName = UsernameTxt.Text; //assigns username of current user to the public string urName from the main menu page
                        f2.isAdmin = Admin;// sets value of Admin to isAdmin var from main menu page
                        this.Hide();
                        f2.ShowDialog();
                    }
                    else
                    {// if credentials not found display this message
                        MessageBox.Show("credentials not found. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {// if credentials not found display this message
                    MessageBox.Show("credentials not found. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ForgotBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //close the login form
            ForgorPassForm f3 = new ForgorPassForm(); //link to the ForgorPass form
            f3.ShowDialog();//take useer to the ForgorPassForm
        }

        private void firstTimebtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //close the login form
            NewUserForm f4 = new NewUserForm();
            f4.firstTime = true; // set public bool var firstTime from the NewUserPage to true
            f4.ShowDialog();
        }
    }
}
