using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savefile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string savepath = @"C:\Users\김지훈\source\repos\test\test.txt";
            string textVlue = "텍스트 파일 입력";
            System.IO.File.WriteAllText(savepath, textVlue, Encoding.Default);
        }
    }
}
