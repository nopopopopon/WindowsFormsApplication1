﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Boolean flag1 = new Boolean();

        public Form1()
        {

            InitializeComponent();

  /*          var timer1 = new Timer();
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(TimerDA);
            //timer1.Start();
            */
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ボタンが押されました";
            // シフトJISのファイルの読み込み
            string[] lines1 = File.ReadAllLines("z:\\Progtmp\\test.txt",
               System.Text.Encoding.GetEncoding("Shift_JIS"));
            foreach (string s in lines1)
            {
                textBox1.Text += s;
            }
            timer1.Start();
                   
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  textBox1.Text = "初期テキスト";

            string str1;
            str1 = SAClass1.GetMyPath();
            this.textBox2.Text = str1;

            SAClass1.Wstatus(this, str1);   

                timer1.Stop();
            
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"Z:\Progtmp\test2.txt", textBox1.Lines, System.Text.Encoding.GetEncoding("Shift_JIS"));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
