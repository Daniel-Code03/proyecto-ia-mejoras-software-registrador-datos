using GUI_Config.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Config.Forms
{
    public partial class DataForm : Form
    {
        public MatrixConfig MatrixConfig { get; private set; }

        public DataForm()
        {
            InitializeComponent();
        }

        public DataForm(MatrixConfig matrixConfig)
        {
            InitializeComponent();
            tbxIdSensor.Text = matrixConfig.Id;
            cbxSensor.Text = matrixConfig.Sensors;
            cbxParameter.Text = matrixConfig.Parameters;
            cbxSocketNumber.Text = matrixConfig.Socket_Number.ToString();
            cbxMathAnalysis.Text = matrixConfig.Math_Analysis;
            cbxParameterT.Text = matrixConfig.Parameter_Title;
            lblpid.Text = matrixConfig.Property_Id;
            lblsid.Text = matrixConfig.Sensor_Id;
            lblStaId.Text = matrixConfig.Statistic_Id;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bool validatedConfig = ValidateConfig(out string errorMsg);
            if (validatedConfig)
            {
                MatrixConfig = new MatrixConfig(tbxIdSensor.Text, cbxSensor.Text, cbxParameter.Text, cbxSocketNumber.Text, cbxMathAnalysis.Text, cbxParameterT.Text, lblpid.Text, lblsid.Text, lblStaId.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private bool ValidateConfig(out string errorMsg)
        {
            errorMsg = string.Empty;
            if (string.IsNullOrEmpty(tbxIdSensor.Text))
            {
                errorMsg += "The sensors Id can't be empty." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(cbxSensor.Text))
            {
                errorMsg += "The sensors name can't be empty." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(cbxParameter.Text))
            {
                errorMsg += "The sensors parameter can't be empty." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(cbxSocketNumber.Text))
            {
                errorMsg += "The sensors socket number can't be empty." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(cbxMathAnalysis.Text))
            {
                errorMsg += "The sensors math analysis can't be empty." + Environment.NewLine;
            }
            return errorMsg == string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cbxParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable SCD30propertyt = new DataTable();
            SCD30propertyt.Columns.Add("sensors");
            DataRow row = SCD30propertyt.NewRow();
            row["sensors"] = "SCD30";
            SCD30propertyt.Rows.Add(row);

            DataTable SCD30propertyrh = new DataTable();
            SCD30propertyrh.Columns.Add("sensors");            
            DataRow row1 = SCD30propertyrh.NewRow();
            row1["sensors"] = "SCD30";
            SCD30propertyrh.Rows.Add(row1);

            DataTable SCD30propertyco2 = new DataTable();
            SCD30propertyco2.Columns.Add("sensors");
            DataRow row2 = SCD30propertyco2.NewRow();
            row2["sensors"] = "SCD30";
            SCD30propertyco2.Rows.Add(row2);

            DataTable AM2315propertyt = new DataTable();
            AM2315propertyt.Columns.Add("sensors");
            DataRow row3 = AM2315propertyt.NewRow();
            row3["sensors"] = "AM2315";
            AM2315propertyt.Rows.Add(row3);

            DataTable AM2315propertyrh = new DataTable();
            AM2315propertyrh.Columns.Add("sensors");
            DataRow row4 = AM2315propertyrh.NewRow();
            row4["sensors"] = "AM2315";
            AM2315propertyrh.Rows.Add(row4);

            DataTable BME280propertyt = new DataTable();
            BME280propertyt.Columns.Add("sensors");
            DataRow row5 = BME280propertyt.NewRow();
            row5["sensors"] = "BME280";
            BME280propertyt.Rows.Add(row5);

            DataTable BME280propertyrh = new DataTable();
            BME280propertyrh.Columns.Add("sensors");
            DataRow row6 = BME280propertyrh.NewRow();
            row6["sensors"] = "BME280";
            BME280propertyrh.Rows.Add(row6);

            DataTable BME280propertyp = new DataTable();
            BME280propertyp.Columns.Add("sensors");
            DataRow row7 = BME280propertyp.NewRow();
            row7["sensors"] = "BME280";
            BME280propertyp.Rows.Add(row7);

            DataTable IRpropertyt = new DataTable();
            IRpropertyt.Columns.Add("sensors");
            DataRow row8 = IRpropertyt.NewRow();
            row8["sensors"] = "IRTerm";
            IRpropertyt.Rows.Add(row8);

            DataTable TeraPMpropertypm1 = new DataTable();
            TeraPMpropertypm1.Columns.Add("sensors");
            DataRow row9 = TeraPMpropertypm1.NewRow();
            row9["sensors"] = "TeraPM";
            TeraPMpropertypm1.Rows.Add(row9);

            DataTable TeraPMpropertypm25 = new DataTable();
            TeraPMpropertypm25.Columns.Add("sensors");
            DataRow row10 = TeraPMpropertypm25.NewRow();
            row10["sensors"] = "TeraPM";
            TeraPMpropertypm25.Rows.Add(row10);

            DataTable TeraPMpropertypm10 = new DataTable();
            TeraPMpropertypm10.Columns.Add("sensors");
            DataRow row11 = TeraPMpropertypm10.NewRow();
            row11["sensors"] = "TeraPM";
            TeraPMpropertypm10.Rows.Add(row11);

            DataTable NO2propertywe = new DataTable();
            NO2propertywe.Columns.Add("sensors");
            DataRow row12 = NO2propertywe.NewRow();
            row12["sensors"] = "NO2_Sensor";
            NO2propertywe.Rows.Add(row12);

            DataTable NO2propertyae = new DataTable();
            NO2propertyae.Columns.Add("sensors");
            DataRow row13 = NO2propertyae.NewRow();
            row13["sensors"] = "NO2_Sensor";
            NO2propertyae.Rows.Add(row13);

            DataTable O3propertywe = new DataTable();
            O3propertywe.Columns.Add("sensors");
            DataRow row14 = O3propertywe.NewRow();
            row14["sensors"] = "O3_Sensor";
            O3propertywe.Rows.Add(row14);

            DataTable O3propertyae = new DataTable();
            O3propertyae.Columns.Add("sensors");
            DataRow row15 = O3propertyae.NewRow();
            row15["sensors"] = "O3_Sensor";
            O3propertyae.Rows.Add(row15);

            DataTable SO2propertywe = new DataTable();
            SO2propertywe.Columns.Add("sensors");
            DataRow row16 = SO2propertywe.NewRow();
            row16["sensors"] = "SO2_Sensor";
            SO2propertywe.Rows.Add(row16);

            DataTable SO2propertyae = new DataTable();
            SO2propertyae.Columns.Add("sensors");
            DataRow row17 = SO2propertyae.NewRow();
            row17["sensors"] = "SO2_Sensor";
            SO2propertyae.Rows.Add(row17);

            DataTable COpropertywe = new DataTable();
            COpropertywe.Columns.Add("sensors");
            DataRow row18 = COpropertywe.NewRow();
            row18["sensors"] = "CO_Sensor";
            COpropertywe.Rows.Add(row18);

            DataTable COpropertyae = new DataTable();
            COpropertyae.Columns.Add("sensors");
            DataRow row19 = COpropertyae.NewRow();
            row19["sensors"] = "CO_Sensor";
            COpropertyae.Rows.Add(row19);

            DataTable Atlaspropertypressure1 = new DataTable();
            Atlaspropertypressure1.Columns.Add("sensors");
            DataRow row20 = Atlaspropertypressure1.NewRow();
            row20["sensors"] = "AtlasP1";
            Atlaspropertypressure1.Rows.Add(row20);

            DataTable Atlaspropertypressure2 = new DataTable();
            Atlaspropertypressure2.Columns.Add("sensors");
            DataRow row21 = Atlaspropertypressure2.NewRow();
            row21["sensors"] = "AtlasP2";
            Atlaspropertypressure2.Rows.Add(row21);

            DataTable Atlaspropertyt = new DataTable();
            Atlaspropertyt.Columns.Add("sensors");
            DataRow row22 = Atlaspropertyt.NewRow();
            row22["sensors"] = "AtlasT";
            Atlaspropertyt.Rows.Add(row22);

            DataTable Atlaspropertyco2 = new DataTable();
            Atlaspropertyco2.Columns.Add("sensors");
            DataRow row23 = Atlaspropertyco2.NewRow();
            row23["sensors"] = "AtlasT";
            Atlaspropertyco2.Rows.Add(row23);

            DataTable RSXpropertyaccx = new DataTable();
            RSXpropertyaccx.Columns.Add("sensors");
            DataRow row24 = RSXpropertyaccx.NewRow();
            row24["sensors"] = "RSX-UM7";
            RSXpropertyaccx.Rows.Add(row24);

            DataTable RSXpropertyaccy = new DataTable();
            RSXpropertyaccy.Columns.Add("sensors");
            DataRow row25 = RSXpropertyaccy.NewRow();
            row25["sensors"] = "RSX-UM7";
            RSXpropertyaccy.Rows.Add(row25);

            DataTable RSXpropertyaccz = new DataTable();
            RSXpropertyaccz.Columns.Add("sensors");
            DataRow row26 = RSXpropertyaccz.NewRow();
            row26["sensors"] = "RSX-UM7";
            RSXpropertyaccz.Rows.Add(row26);

            DataTable RSXpropertygyrx = new DataTable();
            RSXpropertygyrx.Columns.Add("sensors");
            DataRow row27 = RSXpropertygyrx.NewRow();
            row27["sensors"] = "RSX-UM7";
            RSXpropertygyrx.Rows.Add(row27);

            DataTable RSXpropertygyry = new DataTable();
            RSXpropertygyry.Columns.Add("sensors");
            DataRow row28 = RSXpropertygyry.NewRow();
            row28["sensors"] = "RSX-UM7";
            RSXpropertygyry.Rows.Add(row28);

            DataTable RSXpropertygyrz = new DataTable();
            RSXpropertygyrz.Columns.Add("sensors");
            DataRow row29 = RSXpropertygyrz.NewRow();
            row29["sensors"] = "RSX-UM7";
            RSXpropertygyrz.Rows.Add(row29);

            DataTable RSXpropertymagx = new DataTable();
            RSXpropertymagx.Columns.Add("sensors");
            DataRow row30 = RSXpropertymagx.NewRow();
            row30["sensors"] = "RSX-UM7";
            RSXpropertymagx.Rows.Add(row30);

            DataTable RSXpropertymagy = new DataTable();
            RSXpropertymagy.Columns.Add("sensors");
            DataRow row31 = RSXpropertymagy.NewRow();
            row31["sensors"] = "RSX-UM7";
            RSXpropertymagy.Rows.Add(row31);

            DataTable RSXpropertymagz = new DataTable();
            RSXpropertymagz.Columns.Add("sensors");
            DataRow row32 = RSXpropertymagz.NewRow();
            row32["sensors"] = "RSX-UM7";
            RSXpropertymagz.Rows.Add(row32);

            DataTable RSXpropertyroll = new DataTable();
            RSXpropertyroll.Columns.Add("sensors");
            DataRow row33 = RSXpropertyroll.NewRow();
            row33["sensors"] = "RSX-UM7";
            RSXpropertyroll.Rows.Add(row33);

            DataTable RSXpropertypitch = new DataTable();
            RSXpropertypitch.Columns.Add("sensors");
            DataRow row34 = RSXpropertypitch.NewRow();
            row34["sensors"] = "RSX-UM7";
            RSXpropertypitch.Rows.Add(row34);

            DataTable RSXpropertyyaw = new DataTable();
            RSXpropertyyaw.Columns.Add("sensors");
            DataRow row35 = RSXpropertyyaw.NewRow();
            row35["sensors"] = "RSX-UM7";
            RSXpropertyyaw.Rows.Add(row35);

            DataTable VSBV203propertyvib = new DataTable();
            VSBV203propertyvib.Columns.Add("sensors");
            DataRow row36 = VSBV203propertyvib.NewRow();
            row36["sensors"] = "VS_BV203";
            VSBV203propertyvib.Rows.Add(row36);

            DataTable VELM7700propertylight = new DataTable();
            VELM7700propertylight.Columns.Add("sensors");
            DataRow row37 = VELM7700propertylight.NewRow();
            row37["sensors"] = "VELM7700";
            VELM7700propertylight.Rows.Add(row37);

            DataTable PIRpropertymotion = new DataTable();
            PIRpropertymotion.Columns.Add("sensors");
            DataRow row38 = PIRpropertymotion.NewRow();
            row38["sensors"] = "PIR";
            PIRpropertymotion.Rows.Add(row38);

            DataTable GPSpropertylat = new DataTable();
            GPSpropertylat.Columns.Add("sensors");
            DataRow row39 = GPSpropertylat.NewRow();
            row39["sensors"] = "GPS";
            GPSpropertylat.Rows.Add(row39);

            DataTable GPSpropertylong = new DataTable();
            GPSpropertylong.Columns.Add("sensors");
            DataRow row40 = GPSpropertylong.NewRow();
            row40["sensors"] = "GPS";
            GPSpropertylong.Rows.Add(row40);

            DataTable GPSpropertyalt = new DataTable();
            GPSpropertyalt.Columns.Add("sensors");
            DataRow row41 = GPSpropertyalt.NewRow();
            row41["sensors"] = "GPS";
            GPSpropertyalt.Rows.Add(row41);

            DataTable LM324propertysound = new DataTable();
            LM324propertysound.Columns.Add("sensors");
            DataRow row42 = LM324propertysound.NewRow();
            row42["sensors"] = "LM324";
            LM324propertysound.Rows.Add(row42);

            DataTable Luminoxpropertyox = new DataTable();
            Luminoxpropertyox.Columns.Add("sensors");
            DataRow row43 = Luminoxpropertyox.NewRow();
            row43["sensors"] = "LuminOx";
            Luminoxpropertyox.Rows.Add(row43);

            DataTable Luminoxpropertyt = new DataTable();
            Luminoxpropertyt.Columns.Add("sensors");
            DataRow row44 = Luminoxpropertyt.NewRow();
            row44["sensors"] = "LuminOx";
            Luminoxpropertyt.Rows.Add(row44);

            DataTable Luminoxpropertyrh = new DataTable();
            Luminoxpropertyrh.Columns.Add("sensors");
            DataRow row45 = Luminoxpropertyrh.NewRow();
            row45["sensors"] = "LuminOx";
            Luminoxpropertyrh.Rows.Add(row45);

            DataTable EE650propertyspeedair = new DataTable();
            EE650propertyspeedair.Columns.Add("sensors");
            DataRow row46 = EE650propertyspeedair.NewRow();
            row46["sensors"] = "EE650";
            EE650propertyspeedair.Rows.Add(row46);

            DataTable AlphaCOpropertyco = new DataTable();
            AlphaCOpropertyco.Columns.Add("sensors");
            DataRow row47 = AlphaCOpropertyco.NewRow();
            row47["sensors"] = "CO High Concentration";
            AlphaCOpropertyco.Rows.Add(row47);

            DataTable Omronpropertyspeedair = new DataTable();
            Omronpropertyspeedair.Columns.Add("sensors");
            DataRow row48 = Omronpropertyspeedair.NewRow();
            row48["sensors"] = "Omron_DF6";
            Omronpropertyspeedair.Rows.Add(row48);

            DataTable LTR320propertyuv = new DataTable();
            LTR320propertyuv.Columns.Add("sensors");
            DataRow row49 = LTR320propertyuv.NewRow();
            row49["sensors"] = "LTR320_VF";
            LTR320propertyuv.Rows.Add(row49);

            DataTable Waveradarpropertymotion = new DataTable();
            Waveradarpropertymotion.Columns.Add("sensors");
            DataRow row50 = Waveradarpropertymotion.NewRow();
            row50["sensors"] = "WaveRadar";
            Waveradarpropertymotion.Rows.Add(row50);

            DataTable WCS1600propertycurrent = new DataTable();
            WCS1600propertycurrent.Columns.Add("sensors");
            DataRow row51 = WCS1600propertycurrent.NewRow();
            row51["sensors"] = "WCS1600";
            WCS1600propertycurrent.Rows.Add(row51);

            if (cbxParameter.SelectedIndex == 0)
            {
                cbxSensor.DataSource = SCD30propertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "1";                
            }
            else if (cbxParameter.SelectedIndex == 1)
            {
                cbxSensor.DataSource = SCD30propertyrh;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "2";
            }
            else if (cbxParameter.SelectedIndex == 2)
            {
                cbxSensor.DataSource = SCD30propertyco2;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "3";
            }
            else if (cbxParameter.SelectedIndex == 3)
            {
                cbxSensor.DataSource = AM2315propertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "4";
            }
            else if (cbxParameter.SelectedIndex == 4)
            {
                cbxSensor.DataSource = AM2315propertyrh;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "5";
            }
            else if (cbxParameter.SelectedIndex == 5)
            {
                cbxSensor.DataSource = BME280propertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "6";
            }
            else if (cbxParameter.SelectedIndex == 6)
            {
                cbxSensor.DataSource = BME280propertyrh;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "7";
            }
            else if (cbxParameter.SelectedIndex == 7)
            {
                cbxSensor.DataSource = BME280propertyp;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "8";
            }
            else if (cbxParameter.SelectedIndex == 8)
            {
                cbxSensor.DataSource = IRpropertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "9";
            }
            else if (cbxParameter.SelectedIndex == 9)
            {
                cbxSensor.DataSource = TeraPMpropertypm1;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "10";
            }
            else if (cbxParameter.SelectedIndex == 10)
            {
                cbxSensor.DataSource = TeraPMpropertypm25;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "11";
            }
            else if (cbxParameter.SelectedIndex == 11)
            {
                cbxSensor.DataSource = TeraPMpropertypm10;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "12";
            }
            else if (cbxParameter.SelectedIndex == 12)
            {
                cbxSensor.DataSource = NO2propertywe;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "13";
            }
            else if (cbxParameter.SelectedIndex == 13)
            {
                cbxSensor.DataSource = NO2propertyae;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "14";
            }
            else if (cbxParameter.SelectedIndex == 14)
            {
                cbxSensor.DataSource = O3propertywe;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "15";
            }
            else if (cbxParameter.SelectedIndex == 15)
            {
                cbxSensor.DataSource = O3propertyae;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "16";
            }
            else if (cbxParameter.SelectedIndex == 16)
            {
                cbxSensor.DataSource = SO2propertywe;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "17";
            }
            else if (cbxParameter.SelectedIndex == 17)
            {
                cbxSensor.DataSource = SO2propertyae;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "18";
            }
            else if (cbxParameter.SelectedIndex == 18)
            {
                cbxSensor.DataSource = COpropertywe;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "19";
            }
            else if (cbxParameter.SelectedIndex == 19)
            {
                cbxSensor.DataSource = COpropertyae;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "20";
            }
            else if (cbxParameter.SelectedIndex == 20)
            {
                cbxSensor.DataSource = Atlaspropertypressure1;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "21";
            }
            else if (cbxParameter.SelectedIndex == 21)
            {
                cbxSensor.DataSource = Atlaspropertypressure2;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "22";
            }
            else if (cbxParameter.SelectedIndex == 22)
            {
                cbxSensor.DataSource = Atlaspropertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "23";
            }
            else if (cbxParameter.SelectedIndex == 23)
            {
                cbxSensor.DataSource = Atlaspropertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "25";
            }
            else if (cbxParameter.SelectedIndex == 24)
            {
                cbxSensor.DataSource = RSXpropertyaccx;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "26";
            }
            else if (cbxParameter.SelectedIndex == 25)
            {
                cbxSensor.DataSource = RSXpropertyaccy;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "27";
            }
            else if (cbxParameter.SelectedIndex == 26)
            {
                cbxSensor.DataSource = RSXpropertyaccz;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "28";
            }
            else if (cbxParameter.SelectedIndex == 27)
            {
                cbxSensor.DataSource = RSXpropertygyrx;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "29";
            }
            else if (cbxParameter.SelectedIndex == 28)
            {
                cbxSensor.DataSource = RSXpropertygyry;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "30";
            }
            else if (cbxParameter.SelectedIndex == 29)
            {
                cbxSensor.DataSource = RSXpropertygyrz;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "31";
            }
            else if (cbxParameter.SelectedIndex == 30)
            {
                cbxSensor.DataSource = RSXpropertymagx;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "32";
            }
            else if (cbxParameter.SelectedIndex == 31)
            {
                cbxSensor.DataSource = RSXpropertymagy;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "33";
            }
            else if (cbxParameter.SelectedIndex == 32)
            {
                cbxSensor.DataSource = RSXpropertymagz;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "34";
            }
            else if (cbxParameter.SelectedIndex == 33)
            {
                cbxSensor.DataSource = RSXpropertyroll;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "35";
            }
            else if (cbxParameter.SelectedIndex == 34)
            {
                cbxSensor.DataSource = RSXpropertypitch;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "36";
            }
            else if (cbxParameter.SelectedIndex == 35)
            {
                cbxSensor.DataSource = RSXpropertyyaw;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "37";
            }
            else if (cbxParameter.SelectedIndex == 36)
            {
                cbxSensor.DataSource = VSBV203propertyvib;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "38";
            }
            else if (cbxParameter.SelectedIndex == 37)
            {
                cbxSensor.DataSource = VELM7700propertylight;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "39";
            }
            else if (cbxParameter.SelectedIndex == 38)
            {
                cbxSensor.DataSource = PIRpropertymotion;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "40";
            }
            else if (cbxParameter.SelectedIndex == 39)
            {
                cbxSensor.DataSource = GPSpropertylat;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "41";
            }
            else if (cbxParameter.SelectedIndex == 40)
            {
                cbxSensor.DataSource = PIRpropertymotion;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "42";
            }
            else if (cbxParameter.SelectedIndex == 41)
            {
                cbxSensor.DataSource = PIRpropertymotion;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "43";
            }
            else if (cbxParameter.SelectedIndex == 42)
            {
                cbxSensor.DataSource = LM324propertysound;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "44";
            }
            else if (cbxParameter.SelectedIndex == 43)
            {
                cbxSensor.DataSource = Luminoxpropertyox;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "45";
            }
            else if (cbxParameter.SelectedIndex == 44)
            {
                cbxSensor.DataSource = Luminoxpropertyt;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "46";
            }
            else if (cbxParameter.SelectedIndex == 45)
            {
                cbxSensor.DataSource = Luminoxpropertyrh;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "47";
            }
            else if (cbxParameter.SelectedIndex == 46)
            {
                cbxSensor.DataSource = EE650propertyspeedair;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "48";
            }
            else if (cbxParameter.SelectedIndex == 47)
            {
                cbxSensor.DataSource = AlphaCOpropertyco;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "49";
            }
            else if (cbxParameter.SelectedIndex == 48)
            {
                cbxSensor.DataSource = Omronpropertyspeedair;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "50";
            }
            else if (cbxParameter.SelectedIndex == 49)
            {
                cbxSensor.DataSource = LTR320propertyuv;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "51";
            }
            else if (cbxParameter.SelectedIndex == 50)
            {
                cbxSensor.DataSource = Waveradarpropertymotion;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "52";
            }
            else if (cbxParameter.SelectedIndex == 51)
            {
                cbxSensor.DataSource = WCS1600propertycurrent;
                cbxSensor.DisplayMember = "sensors";
                lblpid.Text = "53";
            }
        }

        private void cbxSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxParameter.SelectedIndex == 0)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "1";
                }               
            }
            if (cbxParameter.SelectedIndex == 1)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "1";
                }
            }
            if (cbxParameter.SelectedIndex == 2)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "1";
                }
            }
            if (cbxParameter.SelectedIndex == 3)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "2";
                }
            }
            if (cbxParameter.SelectedIndex == 4)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "2";
                }
            }
            if (cbxParameter.SelectedIndex == 5)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "3";
                }
            }
            if (cbxParameter.SelectedIndex == 6)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "3";
                }
            }
            if (cbxParameter.SelectedIndex == 7)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "3";
                }
            }
            if (cbxParameter.SelectedIndex == 8)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "4";
                }
            }
            if (cbxParameter.SelectedIndex == 9)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "5";
                }
            }
            if (cbxParameter.SelectedIndex == 10)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "5";
                }
            }
            if (cbxParameter.SelectedIndex == 11)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "5";
                }
            }
            if (cbxParameter.SelectedIndex == 12)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 13)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 14)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 15)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 16)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 17)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 18)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 19)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "6";
                }
            }
            if (cbxParameter.SelectedIndex == 20)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "7";
                }
            }
            if (cbxParameter.SelectedIndex == 21)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "8";
                }
            }
            if (cbxParameter.SelectedIndex == 22)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "9";
                }
            }
            if (cbxParameter.SelectedIndex == 23)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "10";
                }
            }
            if (cbxParameter.SelectedIndex == 23)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 24)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 25)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 26)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 27)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 28)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 29)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 30)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 31)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 32)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 33)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 34)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 35)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "11";
                }
            }
            if (cbxParameter.SelectedIndex == 36)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "12";
                }
            }
            if (cbxParameter.SelectedIndex == 37)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "13";
                }
            }
            if (cbxParameter.SelectedIndex == 38)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "14";
                }
            }
            if (cbxParameter.SelectedIndex == 39)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "15";
                }
            }
            if (cbxParameter.SelectedIndex == 40)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "15";
                }
            }
            if (cbxParameter.SelectedIndex == 41)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "15";
                }
            }
            if (cbxParameter.SelectedIndex == 42)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "16";
                }
            }
            if (cbxParameter.SelectedIndex == 43)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "17";
                }
            }
            if (cbxParameter.SelectedIndex == 44)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "17";
                }
            }
            if (cbxParameter.SelectedIndex == 45)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "17";
                }
            }
            if (cbxParameter.SelectedIndex == 46)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "18";
                }
            }
            if (cbxParameter.SelectedIndex == 47)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "19";
                }
            }
            if (cbxParameter.SelectedIndex == 48)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "20";
                }
            }
            if (cbxParameter.SelectedIndex == 49)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "21";
                }
            }
            if (cbxParameter.SelectedIndex == 50)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "22";
                }
            }
            if (cbxParameter.SelectedIndex == 51)
            {
                if (cbxSensor.SelectedIndex == 0)
                {
                    lblsid.Text = "23";
                }
            }
        }
        

        private void cbxMathAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMathAnalysis.SelectedIndex == 0)
            {
                lblStaId.Text = "1";
            }
            else if (cbxMathAnalysis.SelectedIndex == 1)
            {
                lblStaId.Text = "2";
            }
            else if (cbxMathAnalysis.SelectedIndex == 2)
            {
                lblStaId.Text = "3";
            }
            else if (cbxMathAnalysis.SelectedIndex == 3)
            {
                lblStaId.Text = "4";
            }
            else if (cbxMathAnalysis.SelectedIndex == 4)
            {
                lblStaId.Text = "5";
            }
            else if (cbxMathAnalysis.SelectedIndex == 5)
            {
                lblStaId.Text = "6";
            }
        }
    }
}
