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
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;
using static TypeCheck.TypeChecker;

namespace UI_New
{
    public partial class ReportForm : Form
    {
        //fields
        
        private Panel leftBorderBtn;
        private bool editClient = false;

        //Constructor
        public ReportForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
           
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        public ReportForm(bool editClient)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.editClient = true;

            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        //drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void EnterClient_txt_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //minimize, maximize, close
        private void minimize_button_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void close_button_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            ProcessSearch();
        }
        //search database
        public void ProcessSearch()
        {
            try
            {
                //Connection String
                string MyConnection = "server=localhost;userid=my.morrisc6;password=team2;database=my_morrisc6_template1;SslMode=Preferred;persistsecurityinfo=True";
                //Open MySQL connection
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MyConn2.Open();
                if (MyConn2.State == ConnectionState.Closed) MyConn2.Open();

                MySqlCommand comm = MyConn2.CreateCommand();
                using (DataTable dt = new DataTable("CLIENT_DEMOGRAPHICS"))
                {
                    //Insert query
                    comm.CommandText = "select * from CLIENT_DEMOGRAPHICS ";
                    string joinWord = "where";
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
                        if (!string.IsNullOrEmpty(enterDateTxt.Text))
                        {
                            comm.Parameters["@DateAdmitted"].Value = ParseDate(enterDateTxt.Text);
                            comm.CommandText += joinWord + " DateAdmitted like @DateAdmitted ";
                            joinWord = "and";
                        }

                        //client information
                        if (!string.IsNullOrEmpty(searchLastTxt.Text))
                        {
                            comm.Parameters["@LastName"].Value = ParseString(searchLastTxt.Text, 24);
                            comm.CommandText += joinWord + " LastName like @LastName ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(searchFirstTxt.Text))
                        {
                            comm.Parameters["@FirstName"].Value = ParseString(searchFirstTxt.Text, 24);
                            comm.CommandText += joinWord + " FirstName like @FirstName ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(searchAddressTxt.Text))
                        {
                            comm.Parameters["@Address"].Value = ParseString(searchAddressTxt.Text, 48);
                            comm.CommandText += joinWord + " Address like @Address ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterPOTxt.Text))
                        {
                            comm.Parameters["@POBox"].Value = ParsePosInt(enterPOTxt.Text, 6, false);
                            comm.CommandText += joinWord + " POBox like @POBox ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterApartmentTxt.Text))
                        {
                            comm.Parameters["@AptNumber"].Value = ParsePosInt(enterApartmentTxt.Text, 6, false);
                            comm.CommandText += joinWord + " AptNumber like @AptNumber ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterCityTxt.Text))
                        {
                            comm.Parameters["@City"].Value = ParseString(enterCityTxt.Text, 24);
                            comm.CommandText += joinWord + " City like @City ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterStateCbox.Text))
                        {
                            comm.Parameters["@State"].Value = ParseString(enterStateCbox.Text, 2);
                            comm.CommandText += joinWord + " State like @State ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterZipTxt.Text))
                        {
                            comm.Parameters["@ZipCode"].Value = ParsePosInt(enterZipTxt.Text, 5);
                            comm.CommandText += joinWord + " ZipCode like @ZipCode ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterPhoneTxt.Text))
                        {
                            comm.Parameters["@PhoneNumber"].Value = ParsePosInt(enterPhoneTxt.Text, 10);
                            comm.CommandText += joinWord + " PhoneNumber like @PhoneNumber ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterDobTxt.Text))
                        {
                            comm.Parameters["@DateOfBirth"].Value = ParseDate(enterDobTxt.Text);
                            comm.CommandText += joinWord + " DateOfBirth like @DateOfBirth ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterIncomeTxt.Text))
                        {
                            comm.Parameters["@Income"].Value = ParsePosInt(enterIncomeTxt.Text, 0, 10000000);
                            comm.CommandText += joinWord + " Income like @Income ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterMaritalStatusCbox.Text))
                        {
                            comm.Parameters["@MaritalStatus"].Value = ParseString(enterMaritalStatusCbox.Text, 7);
                            comm.CommandText += joinWord + " MaritalStatus like @MaritalStatus ";
                            joinWord = "and";
                        }

                        if (!string.IsNullOrEmpty(enterHouseholdTxt.Text))
                        {
                            comm.Parameters["@HouseholdSize"].Value = ParsePosInt(enterHouseholdTxt.Text, 2, false);
                            comm.CommandText += joinWord + " HouseholdSize like @HouseholdSize ";
                            joinWord = "and";
                        }

                        /*
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
                        */


                        if (!string.IsNullOrEmpty(enterCommentsTxt.Text))
                        {
                            comm.Parameters["@Comment"].Value = ParseString(enterCommentsTxt.Text, 300);
                            comm.CommandText += joinWord + " Comment like @Comment ";
                            joinWord = "and";
                        }

                        // if no parameters, only show the first 300 rows
                        if (joinWord == "where")
                        {
                            comm.CommandText += "limit 300";
                        }


                    }
                    catch (ArgumentException error)
                    {
                        MessageBox.Show(error.Message);
                        InputCheckPassed = false;
                    }

                    if (InputCheckPassed)
                    {
                        MySqlDataAdapter apt = new MySqlDataAdapter(comm);
                        apt.Fill(dt);

                        if (editClient)
                        {
                            // opens a datagrid with "edit" button
                            EditViewForm editForm = new EditViewForm(dt);
                            editForm.Show();
                        }
                        else
                        {
                            // opens a datagrid with "export" button
                            DataViewForm dataForm = new DataViewForm(dt);
                            dataForm.Show();
                        }
                    }
                    // close the connection
                    MyConn2.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   

