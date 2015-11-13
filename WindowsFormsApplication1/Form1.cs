using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Boolean flag1 = new Boolean();
        const string mypath1 = @"c:\tmp\";

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
            SAClass1.Wstatus(this, "ボタンが押されました");
            // シフトJISのファイルの読み込み
            string[] lines1 = File.ReadAllLines(mypath1+"\\test.txt",
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

            SAClass1.Wstatus(this, "タイムアップ");   

                timer1.Stop();
            
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(mypath1+@"test2.txt", textBox1.Lines, System.Text.Encoding.GetEncoding("Shift_JIS"));

        }

    }
}
