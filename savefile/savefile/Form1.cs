using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savefile
{
    public partial class Form1 : Form
    {
        bool modifyFlag = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveAsFile = new SaveFileDialog();

            saveAsFile.InitialDirectory = @"C:\"; //기본 저장경로
            saveAsFile.Title = "다른이름으로 저장";
            saveAsFile.Filter = "텍스트문서(*.txt)|*.txt|모든 파일*.*";//파일형식부분
            saveAsFile.DefaultExt = "txt";
            saveAsFile.AddExtension = true;
            
            if (saveAsFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveAsFile.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(InputTextBox.Text);//저장

                int position = saveAsFile.FileName.LastIndexOf("\\");
                
                string textBoxName = saveAsFile.FileName.Substring(position + 1);

                this.Text = textBoxName + "-memo";
                modifyFlag = false;

                streamWriter.Close();
            }
            else
            {

            }

        }
    }
}
