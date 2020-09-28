using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;    //추가해야할파일

namespace learnToNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            //꼭 필요한 내용
            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.Gray;
            popup.TitleText = "어쩌라고요";
            popup.TitleColor = Color.White;
            popup.ContentText = "응 아니야.";
            popup.ContentColor = Color.White;

            popup.ButtonHoverColor = Color.White;
            popup.Popup();
        }
    }
}
