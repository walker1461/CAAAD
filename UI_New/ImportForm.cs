using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static TypeCheck.TypeChecker;

namespace UI_New
{
    public partial class ImportForm : Form
    {
        private void ImportForm_Load(object sender, EventArgs e)
        {

        }
        //fields
        //private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public ImportForm()
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
            this.Close();
        }

        //import the file
        private void ImportFile(string fileName)
        {
            //provide visual feedback to the user
            output_lb.Items.Clear();
            output_lb.Items.Add("Import in progress... Please do not exit this screen.");
            try
            {
                //connect to the DB
                //Connection String
                string MyConnection = "server=localhost;userid=my.morrisc6;password=team2;database=my_morrisc6_template1;SslMode=Preferred;persistsecurityinfo=True";

                //Open MySQL connection
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MyConn2.Open();
                MySqlCommand comm = MyConn2.CreateCommand();

                //Command structure similar to NewClientForm but without comment
                comm.CommandText = "REPLACE into CLIENT_DEMOGRAPHICS(LastName, FirstName, Address,AptNumber, POBox, City, State, ZipCode, PhoneNumber, DateOfBirth, Income, MaritalStatus, HouseholdSize, MedicareA, Medicaid, ReceivesIRA, ReceivesSHIP, Caregiver, ReceivesHomeMeals, ReceivesCongregateMeals,  ReceivesHomeCare, ReceivesEBHP, ReceivesLegalService, ConsumerChoice, ReceivesTransportation, DateAdmitted) VALUES(@LastName, @FirstName, @Address, @AptNumber, @POBox, @City, @State, @ZipCode, @PhoneNumber, @DateOfBirth, @Income, @MaritalStatus, @HouseholdSize, @MedicareA, @Medicaid, @ReceivesIRA, @ReceivesSHIP, @Caregiver, @ReceivesHomeMeals, @ReceivesCongregateMeals, @ReceivesHomeCare, @ReceivesEBHP, @ReceivesLegalService, @ConsumerChoice, @ReceivesTransportation, @DateAdmitted)";

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

                //check that a path was provided
                if (fileName.Length < 1) throw new ArgumentException("No file path specified");

                //try to open the file
                string fileContents = System.IO.File.ReadAllText(fileName);

                //number of entries - header row
                string[] eachRow = fileContents.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int rowsToProcess = eachRow.Length - 1;
                if (rowsToProcess < 1) throw new ArgumentException("No content detected in file: \"" + fileName + "\"");

                //setup the progress displays
                processedCount_lbl.Text = "0";

                //document any bad queries, and the number of succesful queries
                string[] badQueries = new string[rowsToProcess + 1];
                int attemptedQueries = 0;
                int succesfulQueries = 0;

                //create a query for each row, ignoring the first row
                for (int i = 1; i <= rowsToProcess; i++)
                {
                    //remove commas from currency values
                    int idx = eachRow[i].IndexOf('\"'); //find first occurence
                    if (idx != -1)
                    {
                        idx++;
                        bool done = false;
                        while (idx < eachRow[i].Length && !done) //remove commas until next """ or end of row
                        {
                            if (eachRow[i][idx] == ',') eachRow[i] = eachRow[i].Remove(idx, 1);
                            else if (eachRow[i][idx] == '\"') done = true;
                            idx++;
                        }
                    }

                    try
                    {
                        //check that the row has content
                        string[] eachColumn = eachRow[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        //Console.WriteLine(eachColumn.Length);
                        if (eachColumn.Length < 2) // row has no content (eachColumn is min len 1 by default)
                        {
                            throw new DataException("Empty row detected");
                        }

                        //separate the line into columns (fields)
                        eachColumn = eachRow[i].Split(new char[] { ',' });

                        //check for index range
                        if (eachColumn.Length < 26) throw new ArgumentException("Record must have 26 fields");

                        //trim the columns of additional whitespace
                        for (int j = 0; j < eachColumn.Length; j++)
                        {
                            eachColumn[j] = eachColumn[j].Trim();
                        }

                        //check that the record meets the minimum information requirement (Last, First, DoB)
                        if (string.IsNullOrEmpty(eachColumn[1])) throw new ArgumentException("Last name required");
                        if (string.IsNullOrEmpty(eachColumn[2])) throw new ArgumentException("First name required");
                        if (string.IsNullOrEmpty(eachColumn[10])) throw new ArgumentException("DoB required");

                        //set default bool values
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

                        //assign command parameters
                        bool InputCheckPassed = true;
                        try
                        {
                            //date admitted
                            if (!string.IsNullOrEmpty(eachColumn[0])) comm.Parameters["@DateAdmitted"].Value = ParseDate(eachColumn[0]);

                            //client information
                            if (!string.IsNullOrEmpty(eachColumn[1])) comm.Parameters["@LastName"].Value = ParseString(eachColumn[1], 24);
                            if (!string.IsNullOrEmpty(eachColumn[2])) comm.Parameters["@FirstName"].Value = ParseString(eachColumn[2], 24);
                            if (!string.IsNullOrEmpty(eachColumn[3])) comm.Parameters["@Address"].Value = ParseString(eachColumn[3], 48);
                            if (!string.IsNullOrEmpty(eachColumn[4])) comm.Parameters["@POBox"].Value = ParsePosInt(eachColumn[4], 6, false);
                            if (!string.IsNullOrEmpty(eachColumn[5])) comm.Parameters["@AptNumber"].Value = ParsePosInt(eachColumn[5], 6, false);
                            if (!string.IsNullOrEmpty(eachColumn[6])) comm.Parameters["@City"].Value = ParseString(eachColumn[6], 24);
                            if (!string.IsNullOrEmpty(eachColumn[7])) comm.Parameters["@State"].Value = ParseString(eachColumn[7], 2);
                            if (!string.IsNullOrEmpty(eachColumn[8])) comm.Parameters["@ZipCode"].Value = ParsePosInt(eachColumn[8], 5);
                            if (!string.IsNullOrEmpty(eachColumn[9])) comm.Parameters["@PhoneNumber"].Value = ParsePosInt(eachColumn[9], 10);
                            if (!string.IsNullOrEmpty(eachColumn[10])) comm.Parameters["@DateOfBirth"].Value = ParseDate(eachColumn[10]);
                            if (!string.IsNullOrEmpty(eachColumn[11])) comm.Parameters["@Income"].Value = ParsePosDouble(eachColumn[11], 0, 10000000);
                            if (!string.IsNullOrEmpty(eachColumn[12])) comm.Parameters["@MaritalStatus"].Value = ParseString(eachColumn[12], 7);
                            if (!string.IsNullOrEmpty(eachColumn[13])) comm.Parameters["@HouseholdSize"].Value = ParsePosInt(eachColumn[13], 2, false);

                            //services information/////////////////////////////////////////////////
                            if (ParseString(eachColumn[14], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@MedicareA"].Value = 1;
                            }

                            if (ParseString(eachColumn[15], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@Medicaid"].Value = 1;
                            }

                            if (ParseString(eachColumn[16], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesIRA"].Value = 1;
                            }

                            if (ParseString(eachColumn[17], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesSHIP"].Value = 1;
                            }

                            if (ParseString(eachColumn[18], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@Caregiver"].Value = 1;
                            }

                            if (ParseString(eachColumn[19], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesEBHP"].Value = 1;
                            }

                            if (ParseString(eachColumn[20], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesLegalService"].Value = 1;
                            }

                            if (ParseString(eachColumn[21], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ConsumerChoice"].Value = 1;
                            }

                            if (ParseString(eachColumn[22], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesHomeMeals"].Value = 1;
                            }

                            if (ParseString(eachColumn[23], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesCongregateMeals"].Value = 1;
                            }

                            if (ParseString(eachColumn[24], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesHomeCare"].Value = 1;
                            }

                            if (ParseString(eachColumn[25], 3).ToLower() == "yes")
                            {
                                comm.Parameters["@ReceivesTransportation"].Value = 1;
                            }

                        }
                        catch (ArgumentException error)
                        {
                            // document the error for the record
                            Console.WriteLine(error.Message);
                            attemptedQueries++;
                            badQueries[i] = "Error for row " + (i+1).ToString() + ": " + error.Message;
                            InputCheckPassed = false;
                        }

                        if (InputCheckPassed)
                        {
                            if (comm.ExecuteNonQuery() > 0)
                            {
                                attemptedQueries++;
                                succesfulQueries++;
                            }
                            else
                            {
                                attemptedQueries++;
                                badQueries[i] = "Error for row " + (i + 1).ToString() + ": " + ":\n\t unable to process query at this time.";
                            }
                        }

                    }
                    catch (DataException)
                    {
                        // skip the empty record
                    }
                    catch (Exception er)
                    {
                        //ignore the record, but note to console
                        attemptedQueries++;
                        Console.WriteLine(i.ToString() + ": " + er.Message);

                        if (i < badQueries.Length)
                        {
                            badQueries[i] = "Error for row " + (i+1).ToString() + ": " + er.Message;
                        }
                    };
                }

                //show the success message and update the screen with any errors
                string outputMessage = "Import finished.\n" + succesfulQueries.ToString() + "/" + attemptedQueries.ToString() + " records imported succesfully.";
                bool errorFound = false;
                foreach (string error in badQueries)
                {
                    if (!string.IsNullOrEmpty(error))
                    {
                        if (!errorFound)
                        {
                            errorFound = true;
                            output_lb.Items.Clear();
                        }
                        output_lb.Items.Add(error);
                    }
                }

                //show the user if no errors detected
                if (!errorFound)
                {
                    output_lb.Items.Clear();
                    output_lb.Items.Add("No errors detected during import.");
                }

                //update the import display
                processedCount_lbl.Text = succesfulQueries.ToString() + "/" + attemptedQueries.ToString();

                MessageBox.Show(outputMessage, "Import summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // close the connection
                MyConn2.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message + "\n Refer to the user documentation for accepted file formats.", "Import error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //reset the progress display and reset the output hint
                processedCount_lbl.Text = "NA";
                output_lb.Items.Clear();
                output_lb.Items.Add("To begin, enter the filepath and click import or browse for a .csv file above.");
            }
        }

        //click "browse"
        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();
            fileSelect.Title = "Select a CSV file to import";
            fileSelect.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            fileSelect.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                filename_txt.Text = fileSelect.FileName;
                ImportFile(filename_txt.Text);
            }
        }

        //click "import"
        private void import_btn_Click(object sender, EventArgs e)
        {
            ImportFile(filename_txt.Text);
        }

        //press enter key
        private void filename_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ImportFile(filename_txt.Text);
        }

        //click "done"
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
