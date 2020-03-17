using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAdmin
{
    class HoltLauryForm : Form
    {        

        public HoltLauryForm()
        {     
            base.Dock = DockStyle.Fill;
        }

        public void CreateHoltLauryForm()
        {
            // Create a new instance of the form.
            Form form1 = new Form();
            // Create two buttons to use as the accept and cancel buttons.
            Button ok_btn = new Button();
            Button cancel_btn = new Button();

            // Set the text of button1 to "OK".
            ok_btn.Text = "OK";
            ok_btn.Click += okButtonClick;
            // Set the position of the button on the form.
            ok_btn.Location = new Point(10, 10);
            // Set the text of button2 to "Cancel".
            cancel_btn.Text = "Cancel";
            // Set the position of the button based on the location of button1.
            cancel_btn.Location
               = new Point(ok_btn.Left, ok_btn.Height + ok_btn.Top + 10);
            // Set the caption bar text of the form.   
            form1.Text = "Lottery-Choice Decisions";
            // Display a help button on the form.
            form1.HelpButton = true;

            // Define the border style of the form to a dialog box.
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            form1.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            form1.MinimizeBox = false;
            // Set the accept button of the form to button1.
            form1.AcceptButton = ok_btn;
            // Set the cancel button of the form to button2.
            form1.CancelButton = cancel_btn;
            // Set the start position of the form to the center of the screen.
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            form1.Controls.Add(ok_btn);
            // Add button2 to the form.
            form1.Controls.Add(cancel_btn);

            // Display the form as a modal dialog box.
            form1.ShowDialog();      
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("OK button clicked");
        }
    }
}
