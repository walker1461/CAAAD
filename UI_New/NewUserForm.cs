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
    public partial class NewUserForm : Form
    {
        

        public int AdminPrivlages;//holds weather or not the user has admin privlages
        public bool firstTime { get; set; }//holds weather or not this is the first time the program has been run
        public NewUserForm()
        {
            InitializeComponent();
        }
        private void NewUserForm_Load(object sender, EventArgs e)//when the form loads the options of yes and no are put in the drop downbox
        {
            if (firstTime == true)//if program is being run for first time only give the option for the user being created to be an admin so that that account can create all other accounts
            {
                Admin.Items.Add("Yes");// adds yes to the list for the drop down menu at index 1
            }
            else
            {
                Admin.Items.Add("No"); // adds no to the list for the drop down menu at index 0 
                Admin.Items.Add("Yes");// adds yes to the list for the drop down menu at index 1
            }
            Admin.SelectedIndex = 0; // sets default selected thing in the dropbox. In this case it sets index 0 as the default 
        }
        private void Admin_SelectedIndexChanged(object sender, EventArgs e)
        {   if (Admin.Text == "Yes") // if yes is selected then AdminPrivlages are set to 1 which means the new user account will have admin privliges
            {
                AdminPrivlages = 1;
            }
        else if (Admin.Text == "No")// else AdminPrivlages will be set to 0 and the account will not have admin privlages
            {
                AdminPrivlages = 0;
            }
        }
        private void CreateUser_Click(object sender, EventArgs e) 
        {



         if (UserNameTxt.Text != "" && PasswordTxt.Text != "" && ConfirmPassTxt.Text != "" && EmpEmailTxt.Text != "")//checks to make sure all the fields are not blank

            {
                bool UserExist = false; // set user exist to false because we dont know if the user exist yet
                bool emailUsed = false; // set email used to false because we dont know if the email is in use yet
                //mysql connection stuff
                string Myconn = "server = localhost; user id = my.morrisc6; password = team2; SslMode=Preferred; persistsecurityinfo = True; database = my_morrisc6_template1";
                MySqlConnection conn = new MySqlConnection(Myconn);
                
                //check to see if the username is used
                MySqlCommand cmd = new MySqlCommand("select * from login where username=@Username", conn);//mysql query command that checks for the username to see if a user already exist
                conn.Open();//opens the connnection to the database
                cmd.Parameters.AddWithValue("@Username", UserNameTxt.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);//actually runs the query
                   if (dt.Rows.Count > 0)//looks through table for the requested credentials 
                      {
                        UserExist = true;  //if username is found set UserExist to true
                      }

                //check to see if the entered email is used
                MySqlCommand cmd2 = new MySqlCommand("select * from login where email=@EmpEmail", conn);//mysql query command for checking if the endered email is used for an already exsisting account
                cmd2.Parameters.AddWithValue("@EmpEmail", EmpEmailTxt.Text);
                MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);//actually runs the query
                    if (dt2.Rows.Count > 0)//looks through table for the requested credentials 
                    {
                        emailUsed = true;  //if the email is found set emailUsed to be true
                    }
                if (UserExist== true )// if userExist is true notify the user
                { 
                    MessageBox.Show("Username is aready in use please pick another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (emailUsed == true)
                { // if email is used notify the user
                    MessageBox.Show("email is already in use. please pick another email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else {

                    //password guidelines
                    string specpattern = "[^a-zA-Z0-9]"; //regular expression for detecting special characters.
                    int speChar = 0; // var to hold the number of special char found in the password
                    int capLetter = 0;// var to hold the number of capital letters the password in the password
                    int isnumb = 0;//var to hold the number of numbers found in the password
                    if (PasswordTxt.Text.Length < 8)// if the passwordlength is less than 8 
                    {
                        MessageBox.Show("password is less than 8 characters. please enter a longer password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//print error msg letting the user know their password is too short
                    }

                    else// else if the password is at least 8 characters long
                    {
                       for (int counter = 0; counter < PasswordTxt.Text.Length; counter++)//loop through password until you've gone through the whole password
                        {
                            if (char.IsUpper(PasswordTxt.Text[counter]))//if a capital letter is found increment capLetter
                            {
                                capLetter = capLetter + 1;
                            }
                            // else if a speical char is found increment speChar 
                            else if (Regex.IsMatch(PasswordTxt.Text[counter].ToString(),specpattern))// uses the regular expression to look for everything that is not a number, letter or capital letter in the password at the current index
                            {
                                speChar = speChar + 1;
                            }
                            else if (char.IsNumber(PasswordTxt.Text[counter]))//if a capital letter is found increment capLetter
                            {
                                isnumb = isnumb + 1;
                            }

                        }

                        if (capLetter >= 2 && speChar >= 1 && isnumb >=2)// if capLetter is greater than or equal to 2 AND spChar is greater than or equal to 1 move on the the rest of the account creation process
                        {

                            if (PasswordTxt.Text == ConfirmPassTxt.Text) //checks to make sure PasswordTxt.text and ConfimPassTxt.Text match. if they do then it opens the connection to the database 
                            {
                                //Hash Password
                                string HashWord = BCrypt.Net.BCrypt.HashPassword(PasswordTxt.Text);

                                //mysql connection stuff
                                MySqlCommand cmd3 = new MySqlCommand("insert into login (username,password,admin,email) values (@Username ,@Password ,@Admin ,@Email)", conn);//mysql query command for inserting the user into the database

                                cmd3.Parameters.AddWithValue("@Username", UserNameTxt.Text);
                                cmd3.Parameters.AddWithValue("@Password", HashWord);
                                cmd3.Parameters.AddWithValue("@Email", EmpEmailTxt.Text);
                                cmd3.Parameters.AddWithValue("@Admin", AdminPrivlages);

                                MySqlDataAdapter sda3 = new MySqlDataAdapter(cmd3);
                                DataTable dt3 = new DataTable();
                                sda3.Fill(dt3);//actually runs the query
                                MessageBox.Show("User has been created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (firstTime == true)// if the program is being run for the first time 
                                {
                                    this.Hide();//close the newusersform
                                    LoginForm f1 = new LoginForm();
                                    f1.ShowDialog();//logout the user and take them to the login page
                                }

                            }
                            else //if PasswordTxt.text and ConfirmPassTxt.text do not match then notify the user and then do nothing
                            {
                                MessageBox.Show("Password and Confirm password do not match. Please check them and try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else// else if speChar is less than 1 and capLetter is less than 2 then print our error msg letting the user know
                        {
                            MessageBox.Show("Password does not contain enough special characters, numbers or capital letters. passwords must contain at least 2 capital letters and at least 1 speical character and at least 2 numbers. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    conn.Dispose();//closes the connection
                }
            }
         else
            {
              //message prompts the user letting them know that one or more fields are empty
               MessageBox.Show("one or more fields are empty. please try again", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmpEmailTxt_TextChanged(object sender, EventArgs e)
        {
            string enteredEmail = EmpEmailTxt.Text; // put value of EmpEmailTxt box in entered email string
            if (emailValid(enteredEmail)) //if the function emailValid returns true set the invalid labe to be visible
            {
                invalid.Visible = false;
            }

            else//if the function emailValid returns true set the invalid labe to be invisisble
            {
                invalid.Visible = true;
            }
        }
        private static bool emailValid (string enteredEmail)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase); //regular expression that dictates if the email is vailid
            return emailRegex.IsMatch(enteredEmail); //returns true if email is valid and false if it is not
        }
    }
}
