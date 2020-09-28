using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer interval
            timer.Interval = 1000;  //in milliseconds

            timer.Tick += new EventHandler(this.tickCon);

            //start timer when form loads
            timer.Start();  //this will use t_Tick() method
        }

        //timer eventhandler
        private void tickCon(object sender,EventArgs e)
        {
            //get current time
            int yyyy = System.DateTime.Now.Year;
            int MM = System.DateTime.Now.Month;
            int dd = System.DateTime.Now.Day;
            int hh = System.DateTime.Now.Hour;
            int mm = System.DateTime.Now.Minute;
            int ss = System.DateTime.Now.Second;


            //time
            string day = "";
            string time = "";

            //padding leading zero
            day += yyyy;
            day += "-";
            day += MM;
            day += "-";
            day += dd;
            
            if (hh < 10){time += "0" + hh;}
            else{time += hh;}
            time += ":";
            if (mm < 10){time += "0" + mm;}
            else{time += mm;}
            time += ":";
            if (ss < 10){time += "0" + ss;}
            else{time += ss;}

            //update label
            dayLabel.Text = day;
            timeLabel.Text = time;
        }
    }
}
