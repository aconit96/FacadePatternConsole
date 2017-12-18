using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternConsole.PageMaker
{
    /// <summary>
    /// DatabaseとHtmlWriterを利用したHTMLページ作成処理を実行する
    /// </summary>
    class PageMaker
    {
        private PageMaker() { }

        /// <summary>
        /// 指定したユーザとファイル名でHTMLページを作成する
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="fileName"></param>
        public static void MakeWelcomePage(string userName, string fileName)
        {
            // メールアドレスの検索
            string mailAddr = Database.GetUserMailAddr(userName);
            // htmlの作成
            using (HtmlWriter writer = new HtmlWriter(new StreamWriter(fileName,false,Encoding.Unicode)))
            {
                writer.WriteTitle("Welcome to" + userName + "'s Page!");
                writer.WriteParagraph(userName + "のページへようこそ");
                writer.WriteParagraph("メールまってますね。");
                writer.WriteMailTo(mailAddr, userName);
                writer.Close();
            }
            // HTML出力先の表示
            Console.WriteLine(fileName + @" is created for " + mailAddr + @" (" + userName + @")");
            Console.ReadKey();
        }
    }
}
