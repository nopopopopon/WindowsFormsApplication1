using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    class SAClass1
    {

        static public void Wstatus(Form1 fr,string s)
        {
            fr.toolStripStatusLabel1.Text = s;

        }
    }

}
