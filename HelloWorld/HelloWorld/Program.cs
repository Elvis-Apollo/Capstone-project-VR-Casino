using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
namespace HelloWorld
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
            Decision_Choices = new string[10] { "A1","A2", "A3", "A4", "B5", "B6", "B7", "B8", "B9", "B10" };
            OptionA_Max = 2.00;
            OptionA_Min = 1.60;
            OptionB_Max = 3.85;
            OptionB_Min = 0.1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HoltLaury movie = new HoltLaury();
          
            
            // serialize JSON to a string and then write string to a file
           
            // serialize JSON directly to a file
            for(int i = 0; i < 10; i++)
            {
                using (StreamWriter file = File.CreateText($@"C:\Users\emaad\path{i}.json"))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Serialize(file,movie);
                }
            }
           */


            //File.WriteAllText(@"c:\movie.json", JsonSerializer.Serialize(movie));
           
           
              
               SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Test;Integrated Security=True");
               //SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Users", sqlCon);
               String command = "CREATE TABLE Personss (PersonID int,LastName varchar(255),FirstName varchar(255),Address varchar(255),City varchar(255));";
               SqlCommand cmd = new SqlCommand(command, sqlCon);
               sqlCon.Open();
               cmd.ExecuteNonQuery();
               sqlCon.Close();
               
            // command to insert into database
            //String insert = "insert into Users(id,Name) values(6,'Sally')";
            //SqlCommand cmd = new SqlCommand(insert, sqlCon);
            //sqlCon.Open();
            //cmd.ExecuteNonQuery();
            //sqlCon.Close();

            //DataTable dtbl = new DataTable();
            //sqldata.Fill(dtbl);
            //foreach(DataRow row in dtbl.Rows)
            //{
            //  Console.WriteLine(row["Name"]);

            // }
        }
       
    }
}
