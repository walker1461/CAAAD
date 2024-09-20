using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics; // Add this namespace at the top of your C# file
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using ReportForm.class


namespace UI_New
{
    public partial class EditViewForm : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private DataTable dt;

        //Constructor
        public EditViewForm()
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



        public EditViewForm(DataTable dt)
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dt = dt;
        }



        //drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public void RefreshGrid()
        {
            ReportForm parentForm = Application.OpenForms.OfType<ReportForm>().FirstOrDefault();
            parentForm.ProcessSearch();
            this.Close();
        }

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
            try
            {
                string outputMessage = "";
                using (StreamWriter writetext = new StreamWriter(fileName))
                {
                    // Write the column headers to the CSV file, without a comma on the last entry
                    int i = 0;
                    for (i = 0; i < dt.Columns.Count - 1; i++) //dt = the variable for our datatable
                    {
                        writetext.Write(dt.Columns[i] + ",");
                        Console.Write(dt.Columns[i] + ",");
                    }
                    writetext.WriteLine(dt.Columns[i]);
                    Console.WriteLine(dt.Columns[i]);

                    // Write the values for each index in the table
                    for (i = 0; i < dt.Rows.Count; i++)
                    {
                        // No comma after last
                        int j;
                        for (j = 0; j < dt.Columns.Count - 1; j++)
                        {
                            // Format the dates
                            if (j == 10 || j == 27)
                            {
                                writetext.Write(DateTime.Parse((dt.Rows[i][10].ToString())).ToString("MM/dd/yyyy") + ",");
                                Console.Write(DateTime.Parse((dt.Rows[i][10].ToString())).ToString("MM/dd/yyyy") + ",");
                            }
                            else
                            {
                                writetext.Write(dt.Rows[i][j].ToString() + ",");
                                Console.Write(dt.Rows[i][j].ToString() + ",");
                            }
                        }
                        // Format the dates
                        if (j == 10 || j == 27)
                        {
                            writetext.WriteLine(DateTime.Parse((dt.Rows[i][10].ToString())).ToString("MM/dd/yyyy"));
                            Console.WriteLine(DateTime.Parse((dt.Rows[i][10].ToString())).ToString("MM/dd/yyyy"));
                        }
                        else
                        {
                            writetext.WriteLine(dt.Rows[i][j].ToString());
                            Console.WriteLine(dt.Rows[i][j].ToString());
                        }
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

        // this is the edit button, not renamed for efficiency
        private void exportCsvBtn_Click(object sender, EventArgs e) 
        {
            try
            {
                // make sure only one row is selected, and the row has content
                int selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount != 1)
                {
                    throw new Exception("Multiple or no rows selected. Please select one row.");
                }
                if (dataGridView.SelectedRows[0].Cells[0].Value == null)
                {
                    throw new Exception("Invalid row selected. Please select a row with data.");
                }

                // get an array of strings to send to EditClientForm
                string[] clientInfo = new string[27];
                DataGridViewRow client = dataGridView.SelectedRows[0];

                Console.WriteLine(client.Cells.Count);
                for (int i = 0; i < client.Cells.Count - 1; i++) // ignore client id
                {
                    string currCell = client.Cells[i + 1].Value.ToString();

                    // Format the dates
                    if (i + 1 == 10 || i + 1 == 27)
                    {
                        if (!string.IsNullOrEmpty(currCell)) clientInfo[i] = DateTime.Parse(currCell).ToString("MM/dd/yyyy");
                    }
                    else clientInfo[i] = currCell;

                    //Console.WriteLine(i.ToString() + clientInfo[i]);
                }

                // create an edit form, and send the client details along
                EditClientForm editClientForm = new EditClientForm(clientInfo);
                editClientForm.ShowDialog();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Client select error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }


    }

}
