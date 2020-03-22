using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public class HoltLaury
    {

        public double OptionA_Max { get; set; }
        public double OptionA_Min { get; set; }
        public double OptionB_Max { get; set; }
        public double OptionB_Min { get; set; }

        public String[] Decision_Choices { get; set; }

        public HoltLaury()
        {
            Decision_Choices = new string[10] { "A1", "A2", "A3", "A4", "B5", "B6", "B7", "B8", "B9", "B10" };
            OptionA_Max = 2.60;
            OptionA_Min = 1.60;
            OptionB_Max = 3.85;
            OptionB_Min = 0.1;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            HoltLaury holt = new HoltLaury();
            for (int i = 0; i < 10; i++)
            {
                using (StreamWriter file = File.CreateText($@"HoltLaury{i}.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, holt);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
