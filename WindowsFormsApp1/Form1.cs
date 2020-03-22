using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int start_px = 0;
            int start_py = 0;
            int panel_increment = 20;


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
                Panel p = new Panel();
                p.Width = 620;
                p.Height = 40;
                p.Location = new Point(0, start_py);
               
                RadioButton r = option(i,start_a, end, max_a, min_a);//option a radio buttons
                RadioButton r2 = option(i, start_b, end, max_b, min_b);// option b radio buttons
                this.Controls.Add(p);

                p.Controls.Add(r);
                p.Controls.Add(r2);
                
                start_py += 40;

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
