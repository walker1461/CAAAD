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
    public partial class ResetPassForm : Form
    {
        public ResetPassForm()
        {
            InitializeComponent();
        }
        public string urName { get; set; }
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();//if user clicks send them back to the login page
            f1.ShowDialog();
        }

        private void Resetp_Click(object sender, EventArgs e)
        {
            //password guidelines
            string specpattern = "[^a-zA-Z0-9]"; //regular expression for detecting special characters.
            int speChar = 0; // var to hold the number of special char found in the password
            int capLetter = 0;// var to hold the number of capital letters the password in the password
            int isnumb = 0;//var to hold the number of numbers found in the password
            if (NewPassTxt.Text.Length < 8)// if the passwordlength is less than 8 
            {
                MessageBox.Show("password is less than 8 characters. please enter a longer password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//print error msg letting the user know their password is too short
            }

            else// else if the password is at least 8 characters long
            {
                for (int counter = 0; counter < NewPassTxt.Text.Length; counter++)//loop through password until you've gone through the whole password
                {
                    if (char.IsUpper(NewPassTxt.Text[counter]))//if a capital letter is found increment capLetter
                    {
                        capLetter = capLetter + 1;
                    }
                    // else if a speical char is found increment speChar 
                    else if (Regex.IsMatch(NewPassTxt.Text[counter].ToString(), specpattern))// uses the regular expression to look for everything that is not a number, letter or capital letter in the password at the current index
                    {
                        speChar = speChar + 1;
                    }
                    else if (char.IsNumber(NewPassTxt.Text[counter]))//if a number is found increment isnumb
                    {
                        isnumb = isnumb + 1;
                    }

                }
            }
            if (capLetter >= 2 && speChar >= 1 && isnumb >= 2)// if capLetter is greater than or equal to 2 AND spChar is greater than or equal to 1 move on the the rest of the account creation process
            {
                if (NewPassTxt.Text == PVerificationTxt.Text)
                {
                    // genrate hash from the new password
                    string HashWord = BCrypt.Net.BCrypt.HashPassword(NewPassTxt.Text);
                    string Myconn = "server = localhost; user id = my.morrisc6; password = team2; persistsecurityinfo = True; database = my_morrisc6_template1";
                    MySqlConnection conn = new MySqlConnection(Myconn);
                    MySqlCommand cmd = new MySqlCommand("update login set password = @Newpass where username=@Username", conn);//mysql query command
                    conn.Open();
                    cmd.Parameters.AddWithValue("@NewPass", HashWord);
                    cmd.Parameters.AddWithValue("@Username", urName);


                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);//actually runs the query
                    MessageBox.Show("Password has been reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();//closes the form before moving on to the next form
                    LoginForm f2 = new LoginForm();//if credentials are found move them to the next page
                    f2.ShowDialog();

                }

                else
                {
                    MessageBox.Show("Your passwords do not match. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else// else if speChar is less than 1 and capLetter is less than 2 then print our error msg letting the user know
            {
                MessageBox.Show("Password does not contain enough special characters, numbers or capital letters. passwords must contain at least 2 capital letters and at least 1 speical character and at least 2 numbers. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
