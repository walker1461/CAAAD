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
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics; // Add this namespace at the top of your C# file
//using ReportForm.class


namespace UI_New
{
    public partial class DataViewForm : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private DataTable dt;

        //Constructor
        public DataViewForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            // Logo_panel.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }



        public DataViewForm(DataTable dt)
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
            this.dt = dt;
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

        private void minimize_button_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExportFile(string fileName)
        {
            // ordering of the columns in exported file, initally set to match import format
            int[] columnOrder = { 27, 1, 2, 3, 5, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 18, 19, 23, 24, 25, 20, 21, 22, 26 };
            try
            {
                string outputMessage = "";
                using (StreamWriter writetext = new StreamWriter(fileName))
                {
                    // Write the column headers to the CSV file, without a comma on the last entry
                    int i;
                    for (i = 0; i < columnOrder.Length - 1; i++) //dt = the variable for our datatable
                    {
                        writetext.Write(dt.Columns[columnOrder[i]] + ",");
                        Console.Write(dt.Columns[columnOrder[i]] + ",");
                    }
                    writetext.WriteLine(dt.Columns[columnOrder[i]]);
                    Console.WriteLine(dt.Columns[columnOrder[i]]);

                    // Write the values for each index in the table
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        // No comma after last
                        int j;
                        for (j = 0; j < columnOrder.Length - 1; j++)
                        {
                            // Format the dates
                            if (columnOrder[j] == 10 || columnOrder[j] == 27)
                            {
                                writetext.Write(DateTime.Parse((dt.Rows[i][columnOrder[j]].ToString())).ToString("MM/dd/yyyy") + ",");
                                Console.Write(DateTime.Parse((dt.Rows[i][columnOrder[j]].ToString())).ToString("MM/dd/yyyy") + ",");
                            }
                            else
                            {
                                string writeVal = "";
                                // Format bool
                                if (dt.Columns[columnOrder[j]].DataType == typeof(Boolean))
                                {
                                    if ((bool)dt.Rows[i][columnOrder[j]] == true) writeVal = "YES";
                                }
                                // if not date or bool, interpret directly
                                else writeVal = dt.Rows[i][columnOrder[j]].ToString();
                                writetext.Write(writeVal + ",");
                                Console.Write(writeVal + ",");
                            }
                        }
                        // No commas for final column
                        // Format the dates
                        if (columnOrder[j] == 10 || columnOrder[j] == 27)
                        {
                            writetext.WriteLine(DateTime.Parse((dt.Rows[i][columnOrder[j]].ToString())).ToString("MM/dd/yyyy"));
                            Console.WriteLine(DateTime.Parse((dt.Rows[i][columnOrder[j]].ToString())).ToString("MM/dd/yyyy"));
                        }
                        else
                        {
                            string writeVal = "";
                            // Format bool
                            if (dt.Columns[columnOrder[j]].DataType == typeof(Boolean))
                            {
                                if ((bool)dt.Rows[i][columnOrder[j]] == true) writeVal = "YES";
                            }
                            // if not date or bool, interpret directly
                            else writeVal = dt.Rows[i][columnOrder[j]].ToString();
                            writetext.Write(writeVal);
                            Console.Write(writeVal);
                        }
                        writetext.WriteLine();
                    }
                    outputMessage = "Succesfully exported " + dt.Rows.Count.ToString() + " records.";
                }
                MessageBox.Show(outputMessage, "Export summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Export error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void exportCsvBtn_Click(object sender, EventArgs e) // This is the create CSV button By Preston F 
        //private void exportCsvBtn_Click(object sender, EventArgs e, DataTable dt) // This is the create CSV button By Preston F
        {

            {
                // Create the filename
                DateTime now = DateTime.Now;

                // Get the filepath
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Select a destination for the report";
                saveFile.FileName = now.ToString("MM-dd-yyyy_hh-mmtt") + ".csv";
                saveFile.DefaultExt = (".csv");
                saveFile.Filter = "CSV files (*.csv)|*.csv";
                saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                string fileName;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFile.FileName;
                    ExportFile(fileName);
                    Console.WriteLine(fileName);
                }
            }
        }
    }

}
