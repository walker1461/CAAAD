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
using AAJGen;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


namespace UI_New
{
    public partial class ForgorPassForm : Form
    {
        RandomGen rnd = new RandomGen(); //used for generation of 6 digit code
        public ForgorPassForm()
        {
            InitializeComponent();
        }

        class Global
        {
            public static string ranNum = null;

        }

        

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Hide();// hides the form so there are not more than one open at once
            LoginForm f1 = new LoginForm();//if user clicks send them back to the login page
            f1.ShowDialog();
        }

        private void sendCode_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "")//checks to make sure the user name and the password are not blank
            {
                //message prompts the user letting them know that the field is empty
                MessageBox.Show("Username field is empty. Please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (UsernameTxt.Text != "")
            {
                //mysql connection stuff
       
                string Myconn = "server = localhost; user id = my.morrisc6; password = team2; SslMode=Preferred; persistsecurityinfo = True; database = my_morrisc6_template1";
                MySqlConnection conn = new MySqlConnection(Myconn);
                MySqlCommand cmd = new MySqlCommand("select * from login where username=@Username", conn);//mysql query command
                conn.Open();
                MySqlDataReader reader;//declare sql reader
                cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);//actually runs the query
                string email = null;
                using (reader = cmd.ExecuteReader())//
                {
                    while (reader.Read())//reads while data is in querey results
                    {
                        email = (String)reader["email"]; 
                            //Console.WriteLine(email); console log for testing purposes
                    }
                }
                if (dt.Rows.Count > 0)//if username is found log into gmail account and send verification code
                {
                    string sysemail = "caad565@gmail.com";
                    string password = "exwwiibvkymmxjhc";
                    Global.ranNum = rnd.Gen(); // store the random code in ranNum for later use 
                    MimeMessage message = new MimeMessage(); // create mime message which will be used to fill the message data
                    message.From.Add(new MailboxAddress("CAAAD", "caad565@gmail.com")); //sender info that will show up in the email message
                    message.To.Add(MailboxAddress.Parse(email));//adds the reciver email address that is stored in the email variable
                    message.Subject = "CAAAD Verification code";//subject line of the email being sent
                    message.Body = new TextPart("plain")
                    {
                        Text = Global.ranNum
                    };

                    SmtpClient client = new SmtpClient();

                    try
                    {
                        client.Connect("smtp.gmail.com", 465, true); //establishing connection to smtp server
                        client.Authenticate(sysemail, password);//logs in with the provided username and pass
                        client.Send(message); //sends the message
                      

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message); // prints error message
                    }
                    finally
                    {
                        client.Disconnect(true); // closes the connection
                        client.Dispose(); // disposes of the connection
                        conn.Dispose(); // disposed of DB conection
                    }






                }
                else
                {// if credentials not found display this message
                    MessageBox.Show("credentials not found. please try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void entCode_Click(object sender, EventArgs e)
        {
           if (VerificationTxt.Text != Global.ranNum)
            {
                MessageBox.Show("verification codes do not match.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
           else   
            {
                this.Hide();
                ResetPassForm f3 = new ResetPassForm();//move them to the next page
                f3.urName = UsernameTxt.Text;
                f3.ShowDialog();
                

            }


        }
    }
}
