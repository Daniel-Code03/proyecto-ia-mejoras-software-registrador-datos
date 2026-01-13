
namespace GUI_Config
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdMath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picturesavedatabase = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxSerialCOM = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.lblcomport = new System.Windows.Forms.Label();
            this.cbxcomport = new System.Windows.Forms.ComboBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxplatform = new System.Windows.Forms.ComboBox();
            this.lblplatform = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbxSamplingT = new System.Windows.Forms.TextBox();
            this.lblSampling = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxNumberP = new System.Windows.Forms.TextBox();
            this.lblNumberp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.lblbaudrate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxwifiname = new System.Windows.Forms.TextBox();
            this.lblwifiname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxwifipassword = new System.Windows.Forms.TextBox();
            this.lblwifipassword = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbltimer1 = new System.Windows.Forms.Label();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesavedatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxSerialCOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnProperty,
            this.ColumnIdProperty,
            this.ColumnUnit,
            this.ColumnSensor,
            this.ColumnIdSensor,
            this.ColumnSocket,
            this.ColumnStatistic,
            this.ColumnIdMath});
            this.dataGridView1.Location = new System.Drawing.Point(6, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnID.HeaderText = "Output Id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 80;
            // 
            // ColumnProperty
            // 
            this.ColumnProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnProperty.HeaderText = "Property";
            this.ColumnProperty.Name = "ColumnProperty";
            this.ColumnProperty.ReadOnly = true;
            this.ColumnProperty.Width = 70;
            // 
            // ColumnIdProperty
            // 
            this.ColumnIdProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnIdProperty.HeaderText = "Property Id";
            this.ColumnIdProperty.Name = "ColumnIdProperty";
            this.ColumnIdProperty.ReadOnly = true;
            this.ColumnIdProperty.Width = 70;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnUnit.HeaderText = "Unit";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            this.ColumnUnit.Width = 50;
            // 
            // ColumnSensor
            // 
            this.ColumnSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSensor.HeaderText = "Sensor";
            this.ColumnSensor.Name = "ColumnSensor";
            this.ColumnSensor.ReadOnly = true;
            this.ColumnSensor.Width = 80;
            // 
            // ColumnIdSensor
            // 
            this.ColumnIdSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnIdSensor.HeaderText = "Sensor Id";
            this.ColumnIdSensor.Name = "ColumnIdSensor";
            this.ColumnIdSensor.ReadOnly = true;
            this.ColumnIdSensor.Width = 60;
            // 
            // ColumnSocket
            // 
            this.ColumnSocket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSocket.HeaderText = "Socket Num.";
            this.ColumnSocket.Name = "ColumnSocket";
            this.ColumnSocket.ReadOnly = true;
            this.ColumnSocket.Width = 95;
            // 
            // ColumnStatistic
            // 
            this.ColumnStatistic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnStatistic.HeaderText = "Statistic";
            this.ColumnStatistic.Name = "ColumnStatistic";
            this.ColumnStatistic.ReadOnly = true;
            this.ColumnStatistic.Width = 75;
            // 
            // ColumnIdMath
            // 
            this.ColumnIdMath.HeaderText = "Statistic Id";
            this.ColumnIdMath.Name = "ColumnIdMath";
            this.ColumnIdMath.ReadOnly = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(156, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(433, 42);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Database Configuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(729, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(729, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picturesavedatabase
            // 
            this.picturesavedatabase.Image = ((System.Drawing.Image)(resources.GetObject("picturesavedatabase.Image")));
            this.picturesavedatabase.Location = new System.Drawing.Point(729, 216);
            this.picturesavedatabase.Name = "picturesavedatabase";
            this.picturesavedatabase.Size = new System.Drawing.Size(40, 40);
            this.picturesavedatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturesavedatabase.TabIndex = 5;
            this.picturesavedatabase.TabStop = false;
            this.picturesavedatabase.Click += new System.EventHandler(this.picturesavedatabase_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(729, 262);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "System.txt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 467);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxSerialCOM);
            this.tabPage1.Controls.Add(this.ptbExit);
            this.tabPage1.Controls.Add(this.pictureBoxSave);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 441);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "System Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbxSerialCOM
            // 
            this.gbxSerialCOM.Controls.Add(this.btnupdate);
            this.gbxSerialCOM.Controls.Add(this.progressBar1);
            this.gbxSerialCOM.Controls.Add(this.btnclose);
            this.gbxSerialCOM.Controls.Add(this.btnopen);
            this.gbxSerialCOM.Controls.Add(this.lblcomport);
            this.gbxSerialCOM.Controls.Add(this.cbxcomport);
            this.gbxSerialCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSerialCOM.Location = new System.Drawing.Point(21, 378);
            this.gbxSerialCOM.Name = "gbxSerialCOM";
            this.gbxSerialCOM.Size = new System.Drawing.Size(590, 51);
            this.gbxSerialCOM.TabIndex = 12;
            this.gbxSerialCOM.TabStop = false;
            this.gbxSerialCOM.Text = "Timestamp Configuration";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(372, 20);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 23);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(470, 18);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(114, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(291, 20);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(80, 23);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(210, 20);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(80, 23);
            this.btnopen.TabIndex = 13;
            this.btnopen.Text = "OPEN";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // lblcomport
            // 
            this.lblcomport.AutoSize = true;
            this.lblcomport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomport.Location = new System.Drawing.Point(6, 23);
            this.lblcomport.Name = "lblcomport";
            this.lblcomport.Size = new System.Drawing.Size(76, 13);
            this.lblcomport.TabIndex = 13;
            this.lblcomport.Text = "COM PORT:";
            // 
            // cbxcomport
            // 
            this.cbxcomport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcomport.FormattingEnabled = true;
            this.cbxcomport.Location = new System.Drawing.Point(84, 20);
            this.cbxcomport.Name = "cbxcomport";
            this.cbxcomport.Size = new System.Drawing.Size(110, 21);
            this.cbxcomport.TabIndex = 13;
            // 
            // ptbExit
            // 
            this.ptbExit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit.Image")));
            this.ptbExit.Location = new System.Drawing.Point(650, 203);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(50, 50);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 11;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(650, 147);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSave.TabIndex = 10;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 295);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbxplatform);
            this.panel5.Controls.Add(this.lblplatform);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(495, 35);
            this.panel5.TabIndex = 9;
            // 
            // cbxplatform
            // 
            this.cbxplatform.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxplatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxplatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxplatform.FormattingEnabled = true;
            this.cbxplatform.Location = new System.Drawing.Point(267, 0);
            this.cbxplatform.Name = "cbxplatform";
            this.cbxplatform.Size = new System.Drawing.Size(228, 33);
            this.cbxplatform.TabIndex = 2;
            // 
            // lblplatform
            // 
            this.lblplatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplatform.Location = new System.Drawing.Point(3, 0);
            this.lblplatform.Name = "lblplatform";
            this.lblplatform.Size = new System.Drawing.Size(225, 35);
            this.lblplatform.TabIndex = 1;
            this.lblplatform.Text = "Select Platform:";
            this.lblplatform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbxSamplingT);
            this.panel6.Controls.Add(this.lblSampling);
            this.panel6.Location = new System.Drawing.Point(3, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(495, 35);
            this.panel6.TabIndex = 5;
            // 
            // tbxSamplingT
            // 
            this.tbxSamplingT.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxSamplingT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSamplingT.Location = new System.Drawing.Point(267, 0);
            this.tbxSamplingT.Multiline = true;
            this.tbxSamplingT.Name = "tbxSamplingT";
            this.tbxSamplingT.Size = new System.Drawing.Size(228, 35);
            this.tbxSamplingT.TabIndex = 2;
            // 
            // lblSampling
            // 
            this.lblSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampling.Location = new System.Drawing.Point(3, 0);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(257, 35);
            this.lblSampling.TabIndex = 1;
            this.lblSampling.Text = "Sampling Time (sec):";
            this.lblSampling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxNumberP);
            this.panel1.Controls.Add(this.lblNumberp);
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 35);
            this.panel1.TabIndex = 6;
            // 
            // tbxNumberP
            // 
            this.tbxNumberP.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxNumberP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumberP.Location = new System.Drawing.Point(267, 0);
            this.tbxNumberP.Name = "tbxNumberP";
            this.tbxNumberP.ReadOnly = true;
            this.tbxNumberP.Size = new System.Drawing.Size(228, 31);
            this.tbxNumberP.TabIndex = 3;
            // 
            // lblNumberp
            // 
            this.lblNumberp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberp.Location = new System.Drawing.Point(3, 0);
            this.lblNumberp.Name = "lblNumberp";
            this.lblNumberp.Size = new System.Drawing.Size(257, 35);
            this.lblNumberp.TabIndex = 1;
            this.lblNumberp.Text = "Number of Parameters:";
            this.lblNumberp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxBaudRate);
            this.panel2.Controls.Add(this.lblbaudrate);
            this.panel2.Location = new System.Drawing.Point(3, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 35);
            this.panel2.TabIndex = 6;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(267, 0);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(228, 33);
            this.cbxBaudRate.TabIndex = 2;
            // 
            // lblbaudrate
            // 
            this.lblbaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaudrate.Location = new System.Drawing.Point(3, 0);
            this.lblbaudrate.Name = "lblbaudrate";
            this.lblbaudrate.Size = new System.Drawing.Size(171, 35);
            this.lblbaudrate.TabIndex = 1;
            this.lblbaudrate.Text = "Baud Rate:";
            this.lblbaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxwifiname);
            this.panel3.Controls.Add(this.lblwifiname);
            this.panel3.Location = new System.Drawing.Point(3, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 35);
            this.panel3.TabIndex = 7;
            // 
            // tbxwifiname
            // 
            this.tbxwifiname.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxwifiname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxwifiname.Location = new System.Drawing.Point(267, 0);
            this.tbxwifiname.Multiline = true;
            this.tbxwifiname.Name = "tbxwifiname";
            this.tbxwifiname.Size = new System.Drawing.Size(228, 35);
            this.tbxwifiname.TabIndex = 3;
            // 
            // lblwifiname
            // 
            this.lblwifiname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwifiname.Location = new System.Drawing.Point(3, 0);
            this.lblwifiname.Name = "lblwifiname";
            this.lblwifiname.Size = new System.Drawing.Size(187, 35);
            this.lblwifiname.TabIndex = 1;
            this.lblwifiname.Text = "Wi-Fi Name:";
            this.lblwifiname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxwifipassword);
            this.panel4.Controls.Add(this.lblwifipassword);
            this.panel4.Location = new System.Drawing.Point(3, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 35);
            this.panel4.TabIndex = 8;
            // 
            // tbxwifipassword
            // 
            this.tbxwifipassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxwifipassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxwifipassword.Location = new System.Drawing.Point(267, 0);
            this.tbxwifipassword.Multiline = true;
            this.tbxwifipassword.Name = "tbxwifipassword";
            this.tbxwifipassword.Size = new System.Drawing.Size(228, 35);
            this.tbxwifipassword.TabIndex = 3;
            // 
            // lblwifipassword
            // 
            this.lblwifipassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwifipassword.Location = new System.Drawing.Point(3, 0);
            this.lblwifipassword.Name = "lblwifipassword";
            this.lblwifipassword.Size = new System.Drawing.Size(236, 35);
            this.lblwifipassword.TabIndex = 1;
            this.lblwifipassword.Text = "Wi-Fi Password:";
            this.lblwifipassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbltimer1);
            this.panel7.Controls.Add(this.lbldatetime);
            this.panel7.Location = new System.Drawing.Point(3, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(495, 35);
            this.panel7.TabIndex = 9;
            // 
            // lbltimer1
            // 
            this.lbltimer1.AutoSize = true;
            this.lbltimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer1.Location = new System.Drawing.Point(262, 5);
            this.lbltimer1.Name = "lbltimer1";
            this.lbltimer1.Size = new System.Drawing.Size(104, 25);
            this.lbltimer1.TabIndex = 2;
            this.lbltimer1.Text = "00:00:00";
            // 
            // lbldatetime
            // 
            this.lbldatetime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbldatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatetime.Location = new System.Drawing.Point(0, 0);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(215, 35);
            this.lbldatetime.TabIndex = 1;
            this.lbldatetime.Text = "Date and Time:";
            this.lbldatetime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platform Configuration";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.labelTitle);
            this.tabPage2.Controls.Add(this.pictureBoxClose);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.picturesavedatabase);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 441);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Database Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "Config.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SOFTWARE CONFIG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesavedatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxSerialCOM.ResumeLayout(false);
            this.gbxSerialCOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picturesavedatabase;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumberp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label lblbaudrate;
        private System.Windows.Forms.TextBox tbxSamplingT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxwifiname;
        private System.Windows.Forms.Label lblwifiname;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxplatform;
        private System.Windows.Forms.Label lblplatform;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxwifipassword;
        private System.Windows.Forms.Label lblwifipassword;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbldatetime;
        public System.Windows.Forms.TextBox tbxNumberP;
        private System.Windows.Forms.Label lbltimer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.GroupBox gbxSerialCOM;
        private System.Windows.Forms.ComboBox cbxcomport;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label lblcomport;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSocket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdMath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

