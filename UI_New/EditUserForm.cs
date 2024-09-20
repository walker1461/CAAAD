using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace UI_New
{
    public partial class EditUserForm : Form
    {
        public string urName1 { get; set; }//holds the name of the currently logged in user
        public int AdminPrivlages;// holds weather or not user will have admin prilages
        public EditUserForm()
        {
            InitializeComponent();
        }

       
       

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            Admin.Items.Add("No"); // adds no to the list for the drop down menu at index 0 
            Admin.Items.Add("Yes");// adds yes to the list for the drop down menu at index 1
            Admin.SelectedIndex = 0; // sets default selected thing in the dropbox. In this case it sets index 0 as the default
        }
         private void close_button_Click_1(object sender, EventArgs e)
        {
                    this.Close();//closes the EditUserForm
        }

        private void Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Admin.Text == "Yes") // if yes is selected then AdminPrivlages are set to 1 which means the new user account will have admin privliges
            {
                AdminPrivlages = 1;
            }
            else if (Admin.Text == "No")// else AdminPrivlages will be set to 0 and the account will not have admin privlages
            {
                AdminPrivlages = 0;
            }
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            //mysql connection stuff
            string Myconn = "server = localhost; user id = my.morrisc6; password = team2; SslMode=Preferred; persistsecurityinfo = True; database = my_morrisc6_template1";
            MySqlConnection conn = new MySqlConnection(Myconn);
            MySqlCommand cmd = new MySqlCommand("select * from login where binary username=@Username ", conn);//mysql query command
            conn.Open();
            MySqlDataReader reader;//declare sql reader
            cmd.Parameters.AddWithValue("@Username", UserNameTxt.Text);
          

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);//actually runs the query

            if (dt.Rows.Count > 0)//looks through table for the requested user
            {
                UserNameTxt2.Text = UserNameTxt.Text;// load the username into the second username box under the user information header.
                using (reader = cmd.ExecuteReader())//
                {
                    while (reader.Read())//reads while data is in querey results
                    {
                        EmplEmailTxt.Text = (string)reader["email"]; //Store the selected employee's email in the emplemailTxt textbox
                        Admin.SelectedIndex = (int)reader["admin"]; //Store the the admin privlages in the admin combobox
                    }
                }

            }
            else
            {// if credentials not found display this message
                MessageBox.Show("User not found. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == urName1) //if the username matches the currently logged in user 
            {
                MessageBox.Show("Cannot delete currently signed in user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//do not delete and notify them that they cannot delete their own account
            }
            else// if not then let them delete the user
            {
                DialogResult deleteCon = MessageBox.Show("are you sure you want to delete this user?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // confirmation message making sure the user actually wants to delete the user
                if (deleteCon == DialogResult.Yes)// if the user hits yes on the not sure prompt connect to the database and delete the user
                {
                    //mysql connection and db query start
                    string Myconn = "server = localhost; user id = my.morrisc6; password = team2; persistsecurityinfo = True; database = my_morrisc6_template1";
                    MySqlConnection conn = new MySqlConnection(Myconn);
                    MySqlCommand cmd = new MySqlCommand("delete from login where binary username=@Username ", conn);//mysql query command that will delete the user from the db login table
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Username", UserNameTxt2.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);//actually runs the query
                    conn.Dispose();
                    //mysql connection and db query end

                    UserNameTxt.Text = "";//after deletion set all textboxes as blank to signify that the user has been deleted
                    UserNameTxt2.Text = "";
                    EmplEmailTxt.Text = ""; 

                }

                else if (deleteCon == DialogResult.No) // if user hits no on the not sure prompt do nothing
                {

                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTxt2.Text != "" && EmplEmailTxt.Text != "")// if both text fields are not empty connect to the database and make the edit
            {
                bool UserExist = false;//holds if the username is used or not
                bool emailUsed = false;//holds if an email address is used or not

                if (UserNameTxt.Text != UserNameTxt2.Text)
                {


                    //mysql connection and db query start
                    string Myconn = "server = localhost; user id = my.morrisc6; password = team2; persistsecurityinfo = True; database = my_morrisc6_template1";
                    MySqlConnection conn = new MySqlConnection(Myconn);
                    MySqlCommand cmd = new MySqlCommand("select * from login where username=@Username", conn);//mysql query command that checks for the username to see if a user already exist
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Username", UserNameTxt2.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);//actually runs the query
                    if (dt.Rows.Count > 0)//looks through table for the requested credentials 
                    {
                        UserExist = true;  //if username is found set UserExist to true
                    }
                    

                    if (UserExist == true)
                    { // if userExist is true notify the user
                        MessageBox.Show("Username is aready in use please pick another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Dispose();
                    //mysql connection and db query end
                }

                if (UserExist == false)
                {   //mysql connection and db query start            
                    string Myconn2 = "server = localhost; user id = my.morrisc6; password = team2; persistsecurityinfo = True; database = my_morrisc6_template1";
                    MySqlConnection conn2 = new MySqlConnection(Myconn2);
                    conn2.Open(); // open the connection to the database
                    MySqlDataReader reader;//declare sql reader
                    //check to see if the entered email is used
                    MySqlCommand cmd1 = new MySqlCommand("select * from login where email=@EmpEmail", conn2);//mysql query command for looking for the specified email in the database
                    cmd1.Parameters.AddWithValue("@EmpEmail", EmplEmailTxt.Text);
                    MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);//actually runs the query
                    if (dt1.Rows.Count > 0)//looks through table for the requested results
                    {
                        using (reader = cmd1.ExecuteReader())//
                        {
                            while (reader.Read())//reads while data is in querey results
                            {
                                if ((string)reader["username"] == UserNameTxt.Text)// if the username in the results matches the current username pulled from DB do nothing because it is okay to use the email
                                {
                                    
                                }
                                else if ((string)reader["username"] != UserNameTxt.Text)// if the username in the results does not match the current username pulled from db it is not okay to use that email because that means it is tied to another acount
                                {
                                    emailUsed = true;//set email used to true
                                }


                            }
                        }
                    }

                    if (emailUsed == false)//if email is not used then continue with edit
                    {

                        MySqlCommand cmd2 = new MySqlCommand("update login set username=@Username2, email=@Email, admin=@Admin where username=@Username", conn2);//mysqlupdate existing entry with new changes 

                        cmd2.Parameters.AddWithValue("@Username", UserNameTxt.Text);//set @username to value of UserNameTxt.Text
                        cmd2.Parameters.AddWithValue("@Username2", UserNameTxt2.Text);//set @username2 to value of UserNameTxt2.Text
                        cmd2.Parameters.AddWithValue("@Email", EmplEmailTxt.Text);//set @Email to value of EmpEmailTxt.Text
                        cmd2.Parameters.AddWithValue("@Admin", AdminPrivlages);//set @Admin to value of AdminPrivlages
                        MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);//actually runs the query

                        MessageBox.Show("User changes have been saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (emailUsed == true)
                    { // if email is used notify the user
                        MessageBox.Show("email is already in use. please pick another email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn2.Dispose();
                    //mysql connection and db query end
                }
            }
            else// else print error message
            {// if credentials not found display this message
                MessageBox.Show("one or more fields are blank. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EmplEmailTxt_TextChanged(object sender, EventArgs e)
        {
            string enteredEmail = EmplEmailTxt.Text; // put value of EmpEmailTxt box in entered email string
            if (emailValid(enteredEmail)) //if the function emailValid returns true set the invalid labe to be visible
            {
                invalid.Visible = false;
            }

            else//if the function emailValid returns true set the invalid labe to be invisisble
            {
                invalid.Visible = true;
            }
        }

        private static bool emailValid(string enteredEmail)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase); //regular expression that dictates if the email is vailid
            return emailRegex.IsMatch(enteredEmail); //returns true if email is valid and false if it is not
        }
    }
}
