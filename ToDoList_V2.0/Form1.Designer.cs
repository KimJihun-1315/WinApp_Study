namespace ToDoList_V2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToDoList = new System.Windows.Forms.CheckedListBox();
            this.DidList = new System.Windows.Forms.CheckedListBox();
            this.add_list = new System.Windows.Forms.Button();
            this.move_list = new System.Windows.Forms.Button();
            this.remove_list = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.TextBox();
            this.Combohour = new System.Windows.Forms.ComboBox();
            this.Combominute = new System.Windows.Forms.ComboBox();
            this.label_Clock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToDoList
            // 
            this.ToDoList.FormattingEnabled = true;
            this.ToDoList.Location = new System.Drawing.Point(12, 79);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(374, 202);
            this.ToDoList.TabIndex = 0;
            // 
            // DidList
            // 
            this.DidList.FormattingEnabled = true;
            this.DidList.Location = new System.Drawing.Point(12, 287);
            this.DidList.Name = "DidList";
            this.DidList.Size = new System.Drawing.Size(374, 158);
            this.DidList.TabIndex = 1;
            // 
            // add_list
            // 
            this.add_list.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_list.Location = new System.Drawing.Point(268, 12);
            this.add_list.Name = "add_list";
            this.add_list.Size = new System.Drawing.Size(118, 61);
            this.add_list.TabIndex = 2;
            this.add_list.Text = "추가하기";
            this.add_list.UseVisualStyleBackColor = true;
            this.add_list.Click += new System.EventHandler(this.add_list_Click);
            // 
            // move_list
            // 
            this.move_list.Location = new System.Drawing.Point(192, 451);
            this.move_list.Name = "move_list";
            this.move_list.Size = new System.Drawing.Size(94, 29);
            this.move_list.TabIndex = 3;
            this.move_list.Text = "완료";
            this.move_list.UseVisualStyleBackColor = true;
            this.move_list.Click += new System.EventHandler(this.move_list_Click);
            // 
            // remove_list
            // 
            this.remove_list.Location = new System.Drawing.Point(292, 451);
            this.remove_list.Name = "remove_list";
            this.remove_list.Size = new System.Drawing.Size(94, 29);
            this.remove_list.TabIndex = 4;
            this.remove_list.Text = "제거하기";
            this.remove_list.UseVisualStyleBackColor = true;
            this.remove_list.Click += new System.EventHandler(this.remove_Click);
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(12, 12);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(250, 27);
            this.input_text.TabIndex = 5;
            this.input_text.Text = "내용을 입력하세요.";
            this.input_text.Click += new System.EventHandler(this.input_text_Click);
            this.input_text.TextChanged += new System.EventHandler(this.input_text_TextChanged);
            // 
            // Combohour
            // 
            this.Combohour.BackColor = System.Drawing.SystemColors.Window;
            this.Combohour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combohour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combohour.FormattingEnabled = true;
            this.Combohour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.Combohour.Location = new System.Drawing.Point(116, 43);
            this.Combohour.Name = "Combohour";
            this.Combohour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Combohour.Size = new System.Drawing.Size(70, 28);
            this.Combohour.TabIndex = 8;
            // 
            // Combominute
            // 
            this.Combominute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combominute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combominute.FormattingEnabled = true;
            this.Combominute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.Combominute.Location = new System.Drawing.Point(192, 43);
            this.Combominute.Name = "Combominute";
            this.Combominute.Size = new System.Drawing.Size(70, 28);
            this.Combominute.TabIndex = 8;
            // 
            // label_Clock
            // 
            this.label_Clock.AutoSize = true;
            this.label_Clock.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Clock.Location = new System.Drawing.Point(12, 452);
            this.label_Clock.Name = "label_Clock";
            this.label_Clock.Size = new System.Drawing.Size(173, 28);
            this.label_Clock.TabIndex = 9;
            this.label_Clock.Text = "현재시간 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(398, 489);
            this.Controls.Add(this.label_Clock);
            this.Controls.Add(this.Combominute);
            this.Controls.Add(this.Combohour);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.remove_list);
            this.Controls.Add(this.move_list);
            this.Controls.Add(this.add_list);
            this.Controls.Add(this.DidList);
            this.Controls.Add(this.ToDoList);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ToDo_List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox ToDoList;
        private System.Windows.Forms.CheckedListBox DidList;
        private System.Windows.Forms.Button add_list;
        private System.Windows.Forms.Button move_list;
        private System.Windows.Forms.Button remove_list;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.ComboBox Combohour;
        private System.Windows.Forms.ComboBox Combominute;
        private System.Windows.Forms.Label label_Clock;
    }
}

