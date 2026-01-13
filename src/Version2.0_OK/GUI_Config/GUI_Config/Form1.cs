using GUI_Config.DATA;
using GUI_Config.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Config
{
    public partial class Form1 : Form
    {   
        private int numberofrows, rowIndex;

        public SystemConfig SystemConfig { get; private set; }

        public MatrixConfig MatrixConfig { get; private set; }

        public Updatedatetime Updatedatetime { get; private set; }

        public Form1()
        {
            InitializeComponent();
            DataConfiguration.InitializeConfiguration();
            VisualizeMatrix();
        }
        public DataGridView GetDataGridView()
        {
            return dataGridView1;
        }

        private void VisualizeMatrix() 
        {
            dataGridView1.Rows.Clear();
            foreach (MatrixConfig matrixConfig in DataConfiguration.matrixConfigs)
            {
                rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = matrixConfig.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = matrixConfig.Sensors.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = matrixConfig.Parameters.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = matrixConfig.Socket_Number.ToString();
                dataGridView1.Rows[rowIndex].Cells[7].Value = matrixConfig.Math_Analysis.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = matrixConfig.Parameter_Title.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = matrixConfig.Property_Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = matrixConfig.Sensor_Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[8].Value = matrixConfig.Statistic_Id.ToString();                
            }
        }
        public Form1(SystemConfig systemConfig)
        {
            cbxplatform.Text = systemConfig.Devices.ToString();
            tbxSamplingT.Text = systemConfig.Sampling_Time.ToString();
            cbxBaudRate.Text = systemConfig.Baudrate.ToString();
            tbxwifiname.Text = systemConfig.WiFi_Name.ToString();
            tbxwifipassword.Text = systemConfig.WiFi_Password.ToString();
            lbltimer1.Text = systemConfig.Date_Time.ToString();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataForm dataForm = new DataForm();
            int rowIndex = dataGridView1.RowCount;                    
            dataForm.tbxIdSensor.Text = rowIndex.ToString();
            DialogResult dialogResult = dataForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                DataConfiguration.AddConfig(dataForm.MatrixConfig);
                VisualizeMatrix();
                tbxNumberP.Text = rowIndex.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idremovesensor = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DataConfiguration.RemoveConfig(idremovesensor);               
                VisualizeMatrix();
                int updatenumberp = dataGridView1.Rows.Count;
                updatenumberp--;
                tbxNumberP.Text = updatenumberp.ToString();        
                
            }
            else 
            {
                MessageBox.Show("There is not sensor selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idmodifysensor = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string modifysensorname = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string modifyparameter = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string modifysocket = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string modifyanalysis = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string modifytitle = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string modifypropertyid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string modifysensorid = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string modifystatisticid = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                MatrixConfig matrixConfigmodify = new MatrixConfig(idmodifysensor, modifysensorname, modifyparameter, modifysocket, modifyanalysis, modifytitle, modifypropertyid, modifysensorid, modifystatisticid);
                DataForm dataForm = new DataForm(matrixConfigmodify);
                DialogResult dialogResult = dataForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    DataConfiguration.UpdateConfig(idmodifysensor, dataForm.MatrixConfig);
                    VisualizeMatrix();
                }
            }
            else
            {
                MessageBox.Show("There is not sensor selected to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value = (e.RowIndex + 1).ToString(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxSamplingT.Text = "5";
            numberofrows = dataGridView1.Rows.Count;
            numberofrows--;
            tbxNumberP.Text = numberofrows.ToString();
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 0;
            cbxplatform.Items.Add("Arduino");
            cbxplatform.SelectedIndex = 0;
            tbxwifiname.Text = "Guest";
            tbxwifipassword.Text = "Password";
            timer1.Start();
            btnopen.Enabled = true;
            btnclose.Enabled = false;
            btnupdate.Enabled = false;
            progressBar1.Value = 0;
            btnupdate.Enabled = false; 
            string[] portlist = SerialPort.GetPortNames();
            cbxcomport.Items.AddRange(portlist);
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnProperty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnIdProperty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnSensor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnIdSensor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnSocket"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnStatistic"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ColumnIdMath"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
                
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {   
                DataConfiguration.System_PATH = saveFileDialog1.FileName;
                SystemConfig = new SystemConfig(cbxplatform.Text, tbxSamplingT.Text,cbxBaudRate.Text, tbxwifiname.Text, tbxwifipassword.Text,lbltimer1.Text);
                string json = JsonConvert.SerializeObject(SystemConfig, Formatting.Indented);
                File.WriteAllText(DataConfiguration.System_PATH, json);
                string message = "Your general configuration have been saved";
                string title = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    // Do nothing
                }
                else
                {
                    // Do something
                }
            }
            else 
            {
                string message = "Your System Configuration have not been saved";
                string title = "Failed";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    // Do nothing
                }
                else
                {
                    // Do something
                }
            }
            
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            try 
            {
                serialPort1.PortName = cbxcomport.Text;
                serialPort1.Open();
                btnopen.Enabled = false;
                btnclose.Enabled = true;
                btnupdate.Enabled = true;
                progressBar1.Value = 100;
                cbxcomport.Enabled = false;                           
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) { 
                try
                {   
                    serialPort1.Close();
                    btnopen.Enabled = true;
                    btnclose.Enabled = false;
                    btnupdate.Enabled = false;
                    progressBar1.Value = 0;
                    cbxcomport.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    Updatedatetime = new Updatedatetime()
                    {
                        DTYear = DateTime.Now.Year.ToString(),
                        DTMonth = DateTime.Now.Month.ToString(),
                        DTDay = DateTime.Now.Day.ToString(),
                        DTHour = DateTime.Now.Hour.ToString(),
                        DTMinute = DateTime.Now.Minute.ToString(),
                        DTSecond = DateTime.Now.Second.ToString()
                    };
                    string json = JsonConvert.SerializeObject(Updatedatetime, Formatting.Indented);
                    File.WriteAllText(DataConfiguration.System_PATH, json);
                    serialPort1.Write(json);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void picturesavedatabase_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                var parameterselected = new List<object>();
                foreach (var item in DataConfiguration.matrixConfigs)
                {
                    parameterselected.Add(new { Property_Id = item.Property_Id, Sensor_Id = item.Sensor_Id, Statistic_Id = item.Statistic_Id });
                }
                DataConfiguration.Config_PATH = saveFileDialog2.FileName;
                string json = JsonConvert.SerializeObject(parameterselected, Formatting.Indented);
                File.WriteAllText(DataConfiguration.Config_PATH, json);
                string message = "Your Database Configuration have been saved";
                string title = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    // Do nothing
                }
                else
                {
                    // Do something
                }
            }
            else
            {
                string message = "Your Database Configuration have not been saved";
                string title = "Failed";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    // Do nothing
                }
                else
                {
                    // Do something
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");            
        }

        

    }
}
