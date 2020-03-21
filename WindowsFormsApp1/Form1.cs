using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var textBox = new TextBox();
            

        }
       
        private void Form1_Load(Object sender , EventArgs e)
        {
           
        }
        // windows form programming is event driven 
        // event args are sent with the event 
      
        
        Label addlabel(int i , int start, int end)
        {
            Label l = new Label();
            l.Name = "label";
            l.Text = "label";
            l.ForeColor = Color.Black;
            l.Width = 170;
            l.Location = new Point(100, 10);

            return l;

        }
        TextBox tBox(int i , int start , int end)
        {
            TextBox t = new TextBox();
            t.Name = "Option A Max";
            
            t.ForeColor = Color.White;
            
            t.Width = 50;
            t.Location = new Point(start, end);
          
            return t;
        }
        RadioButton option(int i,int start,int end, double max , double min)
        {
            RadioButton r = new RadioButton();
            r.Name = "label";
            r.Text = $"{i+1}/10 of ${max}  {i+9}/10 of ${min}";
            
            r.ForeColor = Color.Black;
           //r.BackColor = Color.Green;
            r.Width = 300;
            r.Location = new Point(start, end);

            return r;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // variables for radio button position and values
            int start_a = 100;// start generating radio buttons for first option at this x co-ord
            int start_b = 400;//start genertaing radio buttons for second option at this x co-ord
            int end = 20;// y co-ord to start generating radio buttons at 
            int increment = 30;// the amount we increase by  in the y direction to generate the next radio button
           


            //variables for textbox to change the payment amounts
            double min_a = 1.60;
            double max_a = 2.00;
            double min_b = 0.10;
            double max_b = 3.85;
            int start_x = 100;
            int start_y = 400;
            int increment_x = 100;
            //generate the radio buttons
            for(int i = 0; i < 10; i++)
            {

                RadioButton r = option(i,start_a, end, max_a, min_a);//option a radio buttons
                RadioButton r2 = option(i, start_b, end, max_b, min_b);// option b radio buttons
                this.Controls.Add(r);
                this.Controls.Add(r2);
                end = end + increment;
            }
            for(int i = 0; i < 4; i++)
            {
                TextBox t = tBox(1, start_x,start_y);
                this.Controls.Add(t);
                start_x = start_x + increment_x;
            }
           
        }
    }




}
