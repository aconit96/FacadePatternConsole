using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternConsole.PageMaker
{
    /// <summary>
    /// 指定された情報を利用し、HTMLタグを生成する
    /// </summary>
    class HtmlWriter:IDisposable
    {
        public StreamWriter _writer { get; set; }

        public HtmlWriter(StreamWriter writer)
        {
            this._writer = writer;
        }

        /// <summary>
        /// HTMLページのタイトル部分を構成するタグ（html, head, title, body, h1）を生成する
        /// </summary>
        /// <param name="title">HTMLページのタイトル</param>
        public void WriteTitle(string title)
        {
            _writer.Write("<html>");
            _writer.Write("<head>");
            _writer.Write("<title>" + title + "</title>");
            _writer.Write("</head>");
            _writer.Write("<body>\n");
            _writer.Write("<h1>" + title + "<h1>");
        }
        /// <summary>
        /// HTMLページの段落を構成するタグ（p）を生成する
        /// </summary>
        /// <param name="msg"></param>
        public void WriteParagraph (string msg)
        {
            _writer.Write("<p>" + msg + "</p>\n");
        }
        /// <summary>
        /// HTMLページのリンクを構成するタグ（a href）を生成する
        /// </summary>
        /// <param name="href"></param>
        /// <param name="caption"></param>
        public void WriteLink(string href, string caption)
        {
            _writer.Write("<a href=\"" + href+ "\">" + caption + "</p>\n");
        }
        /// <summary>
        /// メールアドレス部分の文字列を生成する
        /// </summary>
        /// <param name="mailAddr"></param>
        /// <param name="userName"></param>
        public void WriteMailTo(string mailAddr, string userName)
        {
            WriteLink(("mailto:" + mailAddr), userName);
        }
        /// <summary>
        /// body, headの末尾を生成する
        /// </summary>
        public void Close()
        {
            _writer.Write("</body>");
            _writer.Write("</html>\n");
        }

        public void Dispose()
        {
            _writer.Dispose();
        }
    }
}
