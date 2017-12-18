using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternConsole
{
    class Program
    {
        /// <summary>
        /// 動作確認用の実行クラス
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PageMaker.PageMaker.MakeWelcomePage("Piyo_Taroh", "welcome.html");
        }
    }
}
