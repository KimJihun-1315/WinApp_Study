using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_V2._0
{
    public partial class Form1 : Form
    {
        Timer time = new Timer();

        //get current time
        int hh = System.DateTime.Now.Hour;
        int mm = System.DateTime.Now.Minute;
        int ss = System.DateTime.Now.Second;

        public Form1()
        {
            InitializeComponent();
            ToDoList.CheckOnClick = true;
            DidList.CheckOnClick = true;
            KeyPreview = true;  //Allows keyboard input
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //timer interval
            time.Interval = 1000;  //in milliseconds
            time.Tick += new EventHandler(tickCon);
            //start timer when form loads
            time.Start(); //this will use t_Tick() method
        }


//==========================================================================
//Input text from user
//==========================================================================
        //add list to ToDoList when user click 'add_list' button
        private void add_list_Click(object sender, EventArgs e)
        {
            func_addList();
        }

        //add list to ToDoList when user click 'ENTER'key
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                func_addList();
            }
        }

        //function to add list code
        private void func_addList()
        {    
            if (string.IsNullOrWhiteSpace(input_text.Text))
            {
                MessageBox.Show("빈칸을 입력하세요");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Combohour.Text) || string.IsNullOrWhiteSpace(Combominute.Text))
                {
                    MessageBox.Show("날자를 입력하세요");
                }
                else
                {
                    ToDoList.Items.Add(Combohour.SelectedItem.ToString() + ":" + Combominute.SelectedItem.ToString() + " | " + input_text.Text);
                }
                
                input_text.Text = "";
                Combohour.SelectedItem = null;
                Combominute.SelectedItem = null;
            }
            input_text.Text = "내용을 입력하세요.";
        }

        //remove text_box(inpur_text) text
        private void input_text_Click(object sender, EventArgs e)
        {
            input_text.Clear();
        }
//===========================================================================



//===========================================================================
//Remove or move list
//===========================================================================
        //move list 'ToDoList' to 'DidList'
        private void move_list_Click(object sender, EventArgs e)
        {
            for (int i = ToDoList.Items.Count - 1; i >= 0; i--)
            {
                if (ToDoList.GetItemChecked(i))
                {
                    DidList.Items.Add(ToDoList.Items[i]);
                    ToDoList.Items.Remove(ToDoList.Items[i]);
                }
            }
        }

        //remove list if user click checkedbox list
        private void remove_Click(object sender, EventArgs e)
        {
            for (int i = DidList.Items.Count - 1; i >= 0; i--)
            {
                if (DidList.GetItemChecked(i))
                {
                    DidList.Items.Remove(DidList.Items[i]);
                }
            }
            for (int i = ToDoList.Items.Count - 1; i >= 0; i--)
            {
                if (ToDoList.GetItemChecked(i))
                {
                    ToDoList.Items.Remove(ToDoList.Items[i]);
                }
            }
        }
//===========================================================================


//===========================================================================
//Time control
//===========================================================================
        //timer eventhandler
        private void tickCon(object sender,EventArgs e)
        {
            //get current time
            int hh = System.DateTime.Now.Hour;
            int mm = System.DateTime.Now.Minute;
            int ss = System.DateTime.Now.Second;

            //time
            string time = "현재시간 ";
        
            //padding leading zero
            if (hh < 10)time += "0" + hh;
            else time += hh;
            time += ":";
            if (mm < 10) time += "0" + mm;
            else time += mm;
            time += ":";
            if (ss < 10) time += "0" + ss;
            else time += ss;

            //update label
            label_Clock.Text = time;
        }

//===========================================================================

        private void input_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}