using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Config.DATA
{
    public class MatrixConfig
    {
        public string Id { get; set; }

        public string Sensors { get; private set; }

        public string Parameters { get; private set; }

        public string Socket_Number { get; private set; }

        public string Math_Analysis { get; private set; }

        public string Parameter_Title { get; private set; }

        public string Property_Id { get; private set; } 

        public string Sensor_Id { get; private set; }

        public string Statistic_Id { get; private set; }

        public MatrixConfig(string id, string sensors, string parameters, string socket_number, string math_analysis, string parameter_title, string property_id, string sensor_id, string statistic_id)
        {
            this.Id = id;
            this.Sensors = sensors;
            this.Parameters = parameters;
            this.Socket_Number = socket_number;
            this.Math_Analysis = math_analysis;
            this.Parameter_Title = parameter_title;
            this.Property_Id = property_id;
            this.Sensor_Id = sensor_id;
            this.Statistic_Id = statistic_id;
        }
    }
    public class SystemConfig 
    {
        public string Devices { get; private set; }

        public string Sampling_Time { get; private set; }

        public string Baudrate { get; private set; }
       
        public string WiFi_Name { get; private set; }

        public string WiFi_Password { get; private set; }   

        public string Date_Time { get; private set; }        

        public SystemConfig(string devices, string sampling_time, string baudrate, string wifiname, string wifipassword, string datetime)
        {
            this.Devices = devices;
            this.Sampling_Time = sampling_time;
            this.Baudrate = baudrate;
            this.WiFi_Name = wifiname;
            this.WiFi_Password = wifipassword;
            this.Date_Time = datetime;
        }
    }
    public class Updatedatetime
    {
        public string DTYear;

        public string DTMonth;

        public string DTDay;

        public string DTHour;

        public string DTMinute;

        public string DTSecond;

    }
}