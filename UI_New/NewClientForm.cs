﻿using System;
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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static TypeCheck.TypeChecker;


namespace UI_New
{
    public partial class NewClientForm : Form
    {
        
        private void NewClientForm_Load(object sender, EventArgs e)
        {
            enterDobTxt.Text = "MM/DD/YYYY";
            enterDateTxt.Text = "MM/DD/YYYY";
        }
        //fields
        //private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public NewClientForm()
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

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void enterNewClientLbl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //minimize, maximize, close
        private void minimize_button_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_button_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //enter new client
        private void enterClient_button_Click(object sender, EventArgs e)
        {

            try
            {
                //Connection String
                string MyConnection = "server=localhost;userid=my.morrisc6;password=team2;database=my_morrisc6_template1;SslMode=Preferred;persistsecurityinfo=True";

                //Open MySQL connection
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MyConn2.Open();
                MySqlCommand comm = MyConn2.CreateCommand();

                //Insert query
                comm.CommandText = "REPLACE into CLIENT_DEMOGRAPHICS(LastName, FirstName, Address,AptNumber, POBox, City, State, ZipCode, PhoneNumber, DateOfBirth, Income, MaritalStatus, HouseholdSize, MedicareA, Medicaid, Comment, ReceivesIRA, ReceivesSHIP, Caregiver, ReceivesHomeMeals, ReceivesCongregateMeals,  ReceivesHomeCare, ReceivesEBHP, ReceivesLegalService, ConsumerChoice, ReceivesTransportation, DateAdmitted) VALUES(@LastName, @FirstName, @Address, @AptNumber, @POBox, @City, @State, @ZipCode, @PhoneNumber, @DateOfBirth, @Income, @MaritalStatus, @HouseholdSize, @MedicareA, @Medicaid, @Comment, @ReceivesIRA, @ReceivesSHIP, @Caregiver, @ReceivesHomeMeals, @ReceivesCongregateMeals, @ReceivesHomeCare, @ReceivesEBHP, @ReceivesLegalService, @ConsumerChoice, @ReceivesTransportation, @DateAdmitted)";
                bool InputCheckPassed = true;

                //Declare parameters
                comm.Parameters.Add("@LastName", MySqlDbType.VarChar);
                comm.Parameters["@LastName"].IsNullable = true;
                comm.Parameters.Add("@FirstName", MySqlDbType.VarChar);
                comm.Parameters["@FirstName"].IsNullable = true;
                comm.Parameters.Add("@Address", MySqlDbType.VarChar);
                comm.Parameters["@Address"].IsNullable = true;
                comm.Parameters.Add("@AptNumber", MySqlDbType.VarChar);
                comm.Parameters["@AptNumber"].IsNullable = true;
                comm.Parameters.Add("@POBox", MySqlDbType.VarChar);
                comm.Parameters["@POBox"].IsNullable = true;
                comm.Parameters.Add("@City", MySqlDbType.VarChar);
                comm.Parameters["@City"].IsNullable = true;
                comm.Parameters.Add("@State", MySqlDbType.Enum);
                comm.Parameters["@State"].IsNullable = true;
                comm.Parameters.Add("@ZipCode", MySqlDbType.String);
                comm.Parameters["@ZipCode"].IsNullable = true;
                comm.Parameters.Add("@PhoneNumber", MySqlDbType.String);
                comm.Parameters["@PhoneNumber"].IsNullable = true;
                comm.Parameters.Add("@DateOfBirth", MySqlDbType.Date);
                comm.Parameters["@DateOfBirth"].IsNullable = true;
                comm.Parameters.Add("@Income", MySqlDbType.Decimal);
                comm.Parameters["@Income"].IsNullable = true;
                comm.Parameters.Add("@MaritalStatus", MySqlDbType.Enum);
                comm.Parameters["@MaritalStatus"].IsNullable = true;
                comm.Parameters.Add("@HouseholdSize", MySqlDbType.Int32);
                comm.Parameters["@HouseholdSize"].IsNullable = true;
                comm.Parameters.Add("@MedicareA", MySqlDbType.Bit);
                comm.Parameters["@MedicareA"].IsNullable = true;
                comm.Parameters.Add("@Medicaid", MySqlDbType.Bit);
                comm.Parameters["@Medicaid"].IsNullable = true;
                comm.Parameters.Add("@Comment", MySqlDbType.VarChar);
                comm.Parameters["@Comment"].IsNullable = true;
                comm.Parameters.Add("@ReceivesIRA", MySqlDbType.Bit);
                comm.Parameters["@ReceivesIRA"].IsNullable = true;
                comm.Parameters.Add("@ReceivesSHIP", MySqlDbType.Bit);
                comm.Parameters["@ReceivesSHIP"].IsNullable = true;
                comm.Parameters.Add("@Caregiver", MySqlDbType.Bit);
                comm.Parameters["@Caregiver"].IsNullable = true;
                comm.Parameters.Add("@ReceivesHomeMeals", MySqlDbType.Bit);
                comm.Parameters["@ReceivesHomeMeals"].IsNullable = true;
                comm.Parameters.Add("@ReceivesCongregateMeals", MySqlDbType.Bit);
                comm.Parameters["@ReceivesCongregateMeals"].IsNullable = true;
                comm.Parameters.Add("@ReceivesHomeCare", MySqlDbType.Bit);
                comm.Parameters["@ReceivesHomeCare"].IsNullable = true;
                comm.Parameters.Add("@ReceivesEBHP", MySqlDbType.Bit);
                comm.Parameters["@ReceivesEBHP"].IsNullable = true;
                comm.Parameters.Add("@ReceivesLegalService", MySqlDbType.Bit);
                comm.Parameters["@ReceivesLegalService"].IsNullable = true;
                comm.Parameters.Add("@ConsumerChoice", MySqlDbType.Bit);
                comm.Parameters["@ConsumerChoice"].IsNullable = true;
                comm.Parameters.Add("@ReceivesTransportation", MySqlDbType.Bit);
                comm.Parameters["@ReceivesTransportation"].IsNullable = true;
                comm.Parameters.Add("@DateAdmitted", MySqlDbType.Date);
                comm.Parameters["@DateAdmitted"].IsNullable = true;

                //Set default values for BOOL parameters
                comm.Parameters["@MedicareA"].Value = 0;
                comm.Parameters["@Medicaid"].Value = 0;
                comm.Parameters["@ReceivesIRA"].Value = 0;
                comm.Parameters["@ReceivesSHIP"].Value = 0;
                comm.Parameters["@Caregiver"].Value = 0;
                comm.Parameters["@ReceivesHomeMeals"].Value = 0;
                comm.Parameters["@ReceivesCongregateMeals"].Value = 0;
                comm.Parameters["@ReceivesHomeCare"].Value = 0;
                comm.Parameters["@ReceivesEBHP"].Value = 0;
                comm.Parameters["@ReceivesLegalService"].Value = 0;
                comm.Parameters["@ConsumerChoice"].Value = 0;
                comm.Parameters["@ReceivesTransportation"].Value = 0;


                try
                {
                    //date admitted
                    if (!string.IsNullOrEmpty(enterDateTxt.Text)) comm.Parameters["@DateAdmitted"].Value = ParseDate(enterDateTxt.Text);



                    //client information
                    if (!string.IsNullOrEmpty(enterLastTxt.Text)) comm.Parameters["@LastName"].Value = ParseString(enterLastTxt.Text, 24);
                    else throw new ArgumentException("Client last name is required.");

                    if (!string.IsNullOrEmpty(enterFirstTxt.Text)) comm.Parameters["@FirstName"].Value = ParseString(enterFirstTxt.Text, 24);
                    else throw new ArgumentException("Client first name is required.");

                    if (!string.IsNullOrEmpty(enterAddressTxt.Text)) comm.Parameters["@Address"].Value = ParseString(enterAddressTxt.Text, 48);
                    if (!string.IsNullOrEmpty(enterPOTxt.Text)) comm.Parameters["@POBox"].Value = ParsePosInt(enterPOTxt.Text, 6, false);
                    if (!string.IsNullOrEmpty(enterApartmentTxt.Text)) comm.Parameters["@AptNumber"].Value = ParsePosInt(enterApartmentTxt.Text, 6, false);
                    if (!string.IsNullOrEmpty(enterCityTxt.Text)) comm.Parameters["@City"].Value = ParseString(enterCityTxt.Text, 24);

                    if (!string.IsNullOrEmpty(enterStateCbox.Text)) comm.Parameters["@State"].Value = ParseString(enterStateCbox.Text, 2);
                    if (!string.IsNullOrEmpty(enterZipTxt.Text)) comm.Parameters["@ZipCode"].Value = ParsePosInt(enterZipTxt.Text, 5);
                    if (!string.IsNullOrEmpty(enterPhoneTxt.Text)) comm.Parameters["@PhoneNumber"].Value = ParsePosInt(enterPhoneTxt.Text, 10);
                    if (!string.IsNullOrEmpty(enterDobTxt.Text)) comm.Parameters["@DateOfBirth"].Value = ParseDate(enterDobTxt.Text);
                    else throw new ArgumentException("Client date-of-birth is required.");

                    if (!string.IsNullOrEmpty(enterIncomeTxt.Text)) comm.Parameters["@Income"].Value = ParsePosDouble(enterIncomeTxt.Text, 0, 10000000);

                    if (!string.IsNullOrEmpty(enterMaritalStatusCbox.Text)) comm.Parameters["@MaritalStatus"].Value = ParseString(enterMaritalStatusCbox.Text, 7);

                    if (!string.IsNullOrEmpty(enterHouseholdTxt.Text)) comm.Parameters["@HouseholdSize"].Value = ParsePosInt(enterHouseholdTxt.Text, 2, false);
                    

                    //services information/////////////////////////////////////////////////
                    if (recMedicareCbox.Checked)
                    {
                        comm.Parameters["@MedicareA"].Value = 1;
                    }

                    if (recMedicaidCbox.Checked)
                    {
                        comm.Parameters["@Medicaid"].Value = 1;
                    }

                    if (recIRACbox.Checked)
                    {
                        comm.Parameters["@ReceivesIRA"].Value = 1;
                    }

                    if (recShipCbox.Checked)
                    {
                        comm.Parameters["@ReceivesSHIP"].Value = 1;
                    }

                    if (recCaregiverCbox.Checked)
                    {
                        comm.Parameters["@Caregiver"].Value = 1;
                    }

                    if (recDeliveredMealsCbox.Checked)
                    {
                        comm.Parameters["@ReceivesHomeMeals"].Value = 1;
                    }

                    if (recCongregateMealsCbox.Checked)
                    {
                        comm.Parameters["@ReceivesCongregateMeals"].Value = 1;
                    }

                    if (recHomeCareCbox.Checked)
                    {
                        comm.Parameters["@ReceivesHomeCare"].Value = 1;
                    }

                    if (recEbhpCbox.Checked)
                    {
                        comm.Parameters["@ReceivesEBHP"].Value = 1;
                    }

                    if (recLegalServicesCbox.Checked)
                    {
                        comm.Parameters["@ReceivesLegalService"].Value = 1;
                    }

                    if (recConsumerChoiceCbox.Checked)
                    {
                        comm.Parameters["@ConsumerChoice"].Value = 1;
                    }

                    if (recTransportationCbox.Checked)
                    {
                        comm.Parameters["@ReceivesTransportation"].Value = 1;
                    }


                    if (!string.IsNullOrEmpty(enterCommentsTxt.Text)) comm.Parameters["@Comment"].Value = ParseString(enterCommentsTxt.Text, 300);


                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Add client error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InputCheckPassed = false;
                }

                if (InputCheckPassed)
                {
                    int rowsEffected = comm.ExecuteNonQuery();
                    // close the connection
                    MyConn2.Close();

                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add client error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //clear Date of Birth Text box when active
        private void enterDobTxt_Enter(object sender, EventArgs e)
        {
            enterDobTxt.Text = "";
        }

        private void enterDateTxt_Enter(object sender, EventArgs e)
        {
            enterDateTxt.Text = "";
        }

    
    }
}
