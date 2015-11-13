using System;
using System.IO;
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

        static public string GetMyPath()
        {
            // 自分の実行パスを取得し、文字列で返す
            string appPath;

            // ファイル名も含めてすべて取得
            string appDir = System.Reflection.Assembly.GetExecutingAssembly().Location;

            /* 文字列のうちパス部分だけ取得する using system.io必要 */
            appPath = Path.GetDirectoryName(appDir);
            return appPath;
            /* わははは　てすとコメント */
        }
    }

}
