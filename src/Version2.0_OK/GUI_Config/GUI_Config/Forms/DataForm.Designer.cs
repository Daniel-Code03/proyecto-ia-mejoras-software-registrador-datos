
namespace GUI_Config.Forms
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxIdSensor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsid = new System.Windows.Forms.Label();
            this.cbxSensor = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblpid = new System.Windows.Forms.Label();
            this.cbxParameter = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxSocketNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblStaId = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbxMathAnalysis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxParameterT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxIdSensor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 25);
            this.panel1.TabIndex = 0;
            // 
            // tbxIdSensor
            // 
            this.tbxIdSensor.Location = new System.Drawing.Point(133, 3);
            this.tbxIdSensor.Name = "tbxIdSensor";
            this.tbxIdSensor.ReadOnly = true;
            this.tbxIdSensor.Size = new System.Drawing.Size(210, 22);
            this.tbxIdSensor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output lD:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblsid);
            this.panel2.Controls.Add(this.cbxSensor);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 25);
            this.panel2.TabIndex = 2;
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.Location = new System.Drawing.Point(98, 8);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(13, 9);
            this.lblsid.TabIndex = 13;
            this.lblsid.Text = "id";
            this.lblsid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSensor
            // 
            this.cbxSensor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSensor.FormattingEnabled = true;
            this.cbxSensor.Location = new System.Drawing.Point(133, 0);
            this.cbxSensor.Name = "cbxSensor";
            this.cbxSensor.Size = new System.Drawing.Size(209, 24);
            this.cbxSensor.TabIndex = 2;
            this.cbxSensor.SelectedIndexChanged += new System.EventHandler(this.cbxSensor_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(83, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sensor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblpid);
            this.panel3.Controls.Add(this.cbxParameter);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 25);
            this.panel3.TabIndex = 3;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpid.Location = new System.Drawing.Point(98, 10);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(13, 9);
            this.lblpid.TabIndex = 13;
            this.lblpid.Text = "id";
            this.lblpid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxParameter
            // 
            this.cbxParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParameter.FormattingEnabled = true;
            this.cbxParameter.Items.AddRange(new object[] {
            "Temperature_SCD30",
            "Relative Humidity_SCD30",
            "CO2_SCD30",
            "Temperature_AM2315C",
            "Relative Humidity_AM2315C",
            "Temperature_BME280",
            "Relative Humidity_BME280",
            "Pressure_BME280",
            "Temperature_IR_TERM",
            "PM1_Tera",
            "PM2.5_Tera",
            "PM10_Tera",
            "NO2_WorkingE",
            "NO2_AuxiliaryE",
            "O3_WorkingE",
            "O3_AuxiliaryE",
            "SO2_WorkingE",
            "SO2_AuxiliaryE",
            "CO_WorkingE",
            "CO_AuxiliaryE",
            "Pressure_AtlasP1",
            "Pressure_AtlasP2",
            "Temperature_AtlasT",
            "CO2_AtlasCO2",
            "ACC_X_RSX-UM7",
            "ACC_Y_RSX-UM7",
            "ACC_Z_RSX-UM7",
            "GYR_X_RSX-UM7",
            "GYR_Y_RSX-UM7",
            "GYR_Z_RSX-UM7",
            "MAG_X_RSX-UM7",
            "MAG_Y_RSX-UM7",
            "MAG_Z_RSX-UM7",
            "ROLL_RSX-UM7",
            "PITCH_RSX-UM7",
            "YAW_RSX-UM7",
            "Vibration_VS-BV203",
            "Light_VELM7700",
            "Motion_PIR",
            "Latitude_GPS",
            "Longitude_GPS",
            "Altitude_GPS",
            "Sound_LM324",
            "Oxigen_LuminOx",
            "Temperature_LuminOx",
            "Humidity_LuminOx",
            "WindSpeed_EE650",
            "CO_HIGH_CONCENTRATION",
            "WindSpeed_OMRON_DF6",
            "UV_LTR320_UF",
            "Motion_WAVERADAR",
            "Current"});
            this.cbxParameter.Location = new System.Drawing.Point(132, 0);
            this.cbxParameter.Name = "cbxParameter";
            this.cbxParameter.Size = new System.Drawing.Size(210, 24);
            this.cbxParameter.TabIndex = 2;
            this.cbxParameter.SelectedIndexChanged += new System.EventHandler(this.cbxParameter_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Property:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxSocketNumber);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 25);
            this.panel4.TabIndex = 3;
            // 
            // cbxSocketNumber
            // 
            this.cbxSocketNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSocketNumber.FormattingEnabled = true;
            this.cbxSocketNumber.Items.AddRange(new object[] {
            "socket 1 - I2C",
            "socket 2 - I2C",
            "socket 3 - I2C",
            "socket 4 - I2C",
            "socket 5 - I2C",
            "socket 6 - UART",
            "socket 7 - UART",
            "socket 8 - UART",
            "socket 9 - SPI",
            "socket 10 - AFE (voltage analog sensor)",
            "socket 11 - AFE (4 Alphasense gas sensors)",
            "socket 12 - AFE (voltage analog sensor)",
            "socket 13 - AFE (voltage analog sensor)",
            "socket 14 - AFE (voltage analog sensor)"});
            this.cbxSocketNumber.Location = new System.Drawing.Point(132, 0);
            this.cbxSocketNumber.Name = "cbxSocketNumber";
            this.cbxSocketNumber.Size = new System.Drawing.Size(210, 24);
            this.cbxSocketNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Socket Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblStaId);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.cbxMathAnalysis);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(346, 25);
            this.panel5.TabIndex = 3;
            // 
            // lblStaId
            // 
            this.lblStaId.AutoSize = true;
            this.lblStaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaId.Location = new System.Drawing.Point(98, 9);
            this.lblStaId.Name = "lblStaId";
            this.lblStaId.Size = new System.Drawing.Size(13, 9);
            this.lblStaId.TabIndex = 13;
            this.lblStaId.Text = "id";
            this.lblStaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(83, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // cbxMathAnalysis
            // 
            this.cbxMathAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMathAnalysis.FormattingEnabled = true;
            this.cbxMathAnalysis.Items.AddRange(new object[] {
            "MAX",
            "MIN",
            "AVG",
            "RMS",
            "RAW",
            "COUNT"});
            this.cbxMathAnalysis.Location = new System.Drawing.Point(132, 0);
            this.cbxMathAnalysis.Name = "cbxMathAnalysis";
            this.cbxMathAnalysis.Size = new System.Drawing.Size(210, 24);
            this.cbxMathAnalysis.TabIndex = 2;
            this.cbxMathAnalysis.SelectedIndexChanged += new System.EventHandler(this.cbxMathAnalysis_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Statistic:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 190);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxParameterT);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(3, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(346, 25);
            this.panel6.TabIndex = 4;
            // 
            // cbxParameterT
            // 
            this.cbxParameterT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParameterT.FormattingEnabled = true;
            this.cbxParameterT.Items.AddRange(new object[] {
            " *C",
            "%",
            "ppm",
            "atm",
            "degrees",
            "V",
            "lux",
            "m",
            "hPa",
            "mV",
            "ug/m3",
            "m/s",
            "mW/cm2",
            "m/s2",
            "A"});
            this.cbxParameterT.Location = new System.Drawing.Point(132, 0);
            this.cbxParameterT.Name = "cbxParameterT";
            this.cbxParameterT.Size = new System.Drawing.Size(211, 24);
            this.cbxParameterT.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Unit:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Socket Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pick Configuration Data";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(205, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxSensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxParameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxSocketNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxMathAnalysis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxParameterT;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxIdSensor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label lblpid;
        public System.Windows.Forms.Label lblsid;
        public System.Windows.Forms.Label lblStaId;
        private System.Windows.Forms.Button button2;
    }
}