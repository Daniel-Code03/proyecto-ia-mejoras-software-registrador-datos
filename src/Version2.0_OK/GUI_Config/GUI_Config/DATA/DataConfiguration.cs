using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Config.DATA
{
    
    public class DataConfiguration
    {
        public static string Config_PATH = @"D:\temp\Config.txt";

        public static string System_PATH = @"C:\Users\Olivier\Desktop\temp\" + "System.txt";
        
        public static List<MatrixConfig> matrixConfigs { get; private set; }
        public static List<MatrixConfig> matrixConfigIds { get; set; }
        public List<MatrixConfig> parameterselected2 = new List<MatrixConfig>();


        public static void InitializeConfiguration()
        {
            if (File.Exists(Config_PATH))
            {
                matrixConfigs = new List<MatrixConfig>();
                matrixConfigIds = new List<MatrixConfig>();
                //string json = File.ReadAllText(Config_PATH);
                //matrixConfigs = JsonConvert.DeserializeObject<List<MatrixConfig>>(json);
            }
            else
            {
                matrixConfigs = new List<MatrixConfig>();
                matrixConfigIds = new List<MatrixConfig>();
            }
        }
        
        public static void AddConfig(MatrixConfig config)
        {
            matrixConfigs.Add(config);            
            //string json = JsonConvert.SerializeObject(matrixConfigs, Formatting.Indented);
            //File.WriteAllText(Config_PATH, json);
        }

        public static void RemoveConfig(string id)
        {            
            matrixConfigs.RemoveAll(e => e.Id.Equals(id));
            for (int i = 0; i < matrixConfigs.Count; i++)
            {
                int index = i;
                index++;
                matrixConfigs[i].Id = index.ToString();            
            }
           //string json = JsonConvert.SerializeObject(matrixConfigs, Formatting.Indented);
           //File.WriteAllText(Config_PATH, json);
        }

        public static void UpdateConfig(string idConfigold, MatrixConfig Confignew)
        {
            int indexConfigold = matrixConfigs.FindIndex(e => e.Id == idConfigold);
            if (indexConfigold != -1)
            {
                matrixConfigs[indexConfigold] = Confignew;
            }
            //string json = JsonConvert.SerializeObject(matrixConfigs, Formatting.Indented);
            //File.WriteAllText(Config_PATH, json);
        }
    }
}
